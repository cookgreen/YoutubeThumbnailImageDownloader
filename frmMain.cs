using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Text;

namespace YoutubeThumbnailImageDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            txtYoutubeLink.Enabled = false;
            btnParse.Enabled = false;
            btnSave.Enabled = false;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            txtYoutubeLink.Enabled = true;
            btnParse.Enabled = true;
            btnSave.Enabled = true;
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYoutubeLink.Text))
            {
                if (isValidYoutubeLink(txtYoutubeLink.Text))
                {
                    string youtubeVideoId = extractYoutubeId(txtYoutubeLink.Text);
                    string youtubeVideoThumbnail = string.Format("https://img.youtube.com/vi/{0}/maxresdefault.jpg", youtubeVideoId);

                    string tempDir = Path.Combine(Environment.CurrentDirectory, "Temp");
                    if (!Directory.Exists(tempDir))
                    {
                        Directory.CreateDirectory(tempDir);
                    }

                    try
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                               | SecurityProtocolType.Tls11
                               | SecurityProtocolType.Tls12;

                        HttpClient client = new HttpClient();
                        var task = Task.Run(() => client.GetAsync(youtubeVideoThumbnail));
                        task.Wait();
                        var response = task.Result;
                        var ms = response.Content.ReadAsStream();

                        Image downloadImage = Image.FromStream(ms);
                        Invoke(new Action(() =>
                        {
                            previewImage.Image = downloadImage;
                        }));
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("Invalid Youtube Link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Youtube Link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string extractYoutubeId(string link)
        {
            int headerLen = "https://www.youtube.com/watch?v=".Length;
            return link.Substring(headerLen, link.Length - headerLen);
        }

        private bool isValidYoutubeLink(string link)
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(link))
            {
                if(link.StartsWith("https://www.youtube.com/watch?v="))
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (previewImage.Image != null) 
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JPG Image|*.jpg";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    previewImage.Image.Save(dialog.FileName);
                }
            }
        }
    }
}
