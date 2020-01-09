namespace SlidePuzzle
{
    partial class ImageScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageScannerForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.TrimLinePictureBox = new System.Windows.Forms.PictureBox();
            this.OpenImagePictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TrimLocationToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImageSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomedImageSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomLevelTrackBar = new System.Windows.Forms.TrackBar();
            this.ZoomLevelTitleLabel = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrimLinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenImagePictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomLevelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(432, 399);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 31);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "キャンセル(&C)";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(351, 399);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 31);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "確定(&O)";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.AutoScroll = true;
            this.BackgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPanel.BackgroundImage")));
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.TrimLinePictureBox);
            this.BackgroundPanel.Controls.Add(this.OpenImagePictureBox);
            this.BackgroundPanel.Location = new System.Drawing.Point(-1, -1);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(546, 390);
            this.BackgroundPanel.TabIndex = 5;
            // 
            // TrimLinePictureBox
            // 
            this.TrimLinePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TrimLinePictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TrimLinePictureBox.Location = new System.Drawing.Point(0, 0);
            this.TrimLinePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrimLinePictureBox.Name = "TrimLinePictureBox";
            this.TrimLinePictureBox.Size = new System.Drawing.Size(300, 300);
            this.TrimLinePictureBox.TabIndex = 1;
            this.TrimLinePictureBox.TabStop = false;
            this.TrimLinePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrimLinePictureBox_MouseDown);
            this.TrimLinePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrimLinePictureBox_MouseMove);
            this.TrimLinePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrimLinePictureBox_MouseUp);
            // 
            // OpenImagePictureBox
            // 
            this.OpenImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.OpenImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OpenImagePictureBox.Name = "OpenImagePictureBox";
            this.OpenImagePictureBox.Size = new System.Drawing.Size(350, 350);
            this.OpenImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OpenImagePictureBox.TabIndex = 0;
            this.OpenImagePictureBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrimLocationToolStripStatusLabel,
            this.ImageSizeToolStripStatusLabel,
            this.ZoomedImageSizeToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TrimLocationToolStripStatusLabel
            // 
            this.TrimLocationToolStripStatusLabel.Name = "TrimLocationToolStripStatusLabel";
            this.TrimLocationToolStripStatusLabel.Size = new System.Drawing.Size(93, 17);
            this.TrimLocationToolStripStatusLabel.Text = "起点座標：(0, 0)";
            // 
            // ImageSizeToolStripStatusLabel
            // 
            this.ImageSizeToolStripStatusLabel.Name = "ImageSizeToolStripStatusLabel";
            this.ImageSizeToolStripStatusLabel.Size = new System.Drawing.Size(166, 17);
            this.ImageSizeToolStripStatusLabel.Text = "|  画像のサイズ：(横0px, 縦0px)";
            // 
            // ZoomedImageSizeToolStripStatusLabel
            // 
            this.ZoomedImageSizeToolStripStatusLabel.Name = "ZoomedImageSizeToolStripStatusLabel";
            this.ZoomedImageSizeToolStripStatusLabel.Size = new System.Drawing.Size(202, 17);
            this.ZoomedImageSizeToolStripStatusLabel.Text = "|  拡大後の画像サイズ：(横0px, 縦0px)";
            // 
            // ZoomLevelTrackBar
            // 
            this.ZoomLevelTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZoomLevelTrackBar.LargeChange = 0;
            this.ZoomLevelTrackBar.Location = new System.Drawing.Point(81, 392);
            this.ZoomLevelTrackBar.Maximum = 20;
            this.ZoomLevelTrackBar.Name = "ZoomLevelTrackBar";
            this.ZoomLevelTrackBar.Size = new System.Drawing.Size(200, 45);
            this.ZoomLevelTrackBar.SmallChange = 0;
            this.ZoomLevelTrackBar.TabIndex = 7;
            this.ZoomLevelTrackBar.TabStop = false;
            this.ZoomLevelTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ZoomLevelTrackBar.Value = 10;
            this.ZoomLevelTrackBar.Scroll += new System.EventHandler(this.ZoomLevelTrackBar_Scroll);
            // 
            // ZoomLevelTitleLabel
            // 
            this.ZoomLevelTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZoomLevelTitleLabel.AutoSize = true;
            this.ZoomLevelTitleLabel.Location = new System.Drawing.Point(12, 399);
            this.ZoomLevelTitleLabel.Name = "ZoomLevelTitleLabel";
            this.ZoomLevelTitleLabel.Size = new System.Drawing.Size(72, 30);
            this.ZoomLevelTitleLabel.TabIndex = 8;
            this.ZoomLevelTitleLabel.Text = "拡大レベル：\r\n(+0)";
            this.ZoomLevelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.ZoomLevelTitleLabel);
            this.Controls.Add(this.ZoomLevelTrackBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConfirmButton);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 500);
            this.Name = "ImageScannerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "画像切り取り";
            this.Load += new System.EventHandler(this.ImageScannerForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrimLinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenImagePictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomLevelTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.PictureBox TrimLinePictureBox;
        private System.Windows.Forms.PictureBox OpenImagePictureBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TrimLocationToolStripStatusLabel;
        private System.Windows.Forms.TrackBar ZoomLevelTrackBar;
        private System.Windows.Forms.Label ZoomLevelTitleLabel;
        private System.Windows.Forms.ToolStripStatusLabel ImageSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomedImageSizeToolStripStatusLabel;
    }
}