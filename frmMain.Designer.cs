
namespace YoutubeThumbnailImageDownloader
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            txtYoutubeLink = new TextBox();
            btnParse = new Button();
            groupBox1 = new GroupBox();
            previewImage = new PictureBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Youtube Video Link:";
            // 
            // txtYoutubeLink
            // 
            txtYoutubeLink.Location = new Point(173, 13);
            txtYoutubeLink.Name = "txtYoutubeLink";
            txtYoutubeLink.Size = new Size(541, 27);
            txtYoutubeLink.TabIndex = 1;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(720, 11);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(75, 29);
            btnParse.TabIndex = 2;
            btnParse.Text = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(previewImage);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 415);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thumbnail Image";
            // 
            // previewImage
            // 
            previewImage.BorderStyle = BorderStyle.FixedSingle;
            previewImage.Dock = DockStyle.Fill;
            previewImage.Location = new Point(3, 23);
            previewImage.Name = "previewImage";
            previewImage.Size = new Size(780, 389);
            previewImage.SizeMode = PictureBoxSizeMode.Zoom;
            previewImage.TabIndex = 0;
            previewImage.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(670, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 63);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 555);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnParse);
            Controls.Add(txtYoutubeLink);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Youtube Thumbnail Image Downloader";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)previewImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtYoutubeLink;
        private Button btnParse;
        private GroupBox groupBox1;
        private PictureBox previewImage;
        private Button btnSave;
    }
}
