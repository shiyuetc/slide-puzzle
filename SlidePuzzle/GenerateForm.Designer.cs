namespace SlidePuzzle
{
    partial class GenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateForm));
            this.InfomationGroupBox = new System.Windows.Forms.GroupBox();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.ReferenceButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FromImageRadioButton = new System.Windows.Forms.RadioButton();
            this.FromNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.PreviewTitleLabel = new System.Windows.Forms.Label();
            this.LevelTitleLabel = new System.Windows.Forms.Label();
            this.FromTitleLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InfomationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfomationGroupBox
            // 
            this.InfomationGroupBox.Controls.Add(this.BorderLabel);
            this.InfomationGroupBox.Controls.Add(this.PreviewPictureBox);
            this.InfomationGroupBox.Controls.Add(this.LevelComboBox);
            this.InfomationGroupBox.Controls.Add(this.ReferenceButton);
            this.InfomationGroupBox.Controls.Add(this.FilePathTextBox);
            this.InfomationGroupBox.Controls.Add(this.FromImageRadioButton);
            this.InfomationGroupBox.Controls.Add(this.FromNumberRadioButton);
            this.InfomationGroupBox.Controls.Add(this.PreviewTitleLabel);
            this.InfomationGroupBox.Controls.Add(this.LevelTitleLabel);
            this.InfomationGroupBox.Controls.Add(this.FromTitleLabel);
            this.InfomationGroupBox.Location = new System.Drawing.Point(12, 13);
            this.InfomationGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfomationGroupBox.Name = "InfomationGroupBox";
            this.InfomationGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfomationGroupBox.Size = new System.Drawing.Size(447, 228);
            this.InfomationGroupBox.TabIndex = 0;
            this.InfomationGroupBox.TabStop = false;
            this.InfomationGroupBox.Text = "★ 生成情報";
            // 
            // BorderLabel
            // 
            this.BorderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BorderLabel.Location = new System.Drawing.Point(251, 21);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(1, 192);
            this.BorderLabel.TabIndex = 9;
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPictureBox.Location = new System.Drawing.Point(277, 56);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(150, 150);
            this.PreviewPictureBox.TabIndex = 8;
            this.PreviewPictureBox.TabStop = false;
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "Lv1: 3x3マス(9マス)",
            "Lv2: 4x4マス(16マス)",
            "Lv3: 5x5マス(25マス)"});
            this.LevelComboBox.Location = new System.Drawing.Point(41, 164);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(140, 23);
            this.LevelComboBox.TabIndex = 7;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            // 
            // ReferenceButton
            // 
            this.ReferenceButton.Enabled = false;
            this.ReferenceButton.Location = new System.Drawing.Point(181, 106);
            this.ReferenceButton.Name = "ReferenceButton";
            this.ReferenceButton.Size = new System.Drawing.Size(50, 23);
            this.ReferenceButton.TabIndex = 6;
            this.ReferenceButton.Text = "参照";
            this.ReferenceButton.UseVisualStyleBackColor = true;
            this.ReferenceButton.Click += new System.EventHandler(this.ReferenceButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Font = new System.Drawing.Font("Meiryo UI", 8F);
            this.FilePathTextBox.Location = new System.Drawing.Point(41, 107);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(140, 21);
            this.FilePathTextBox.TabIndex = 5;
            // 
            // FromImageRadioButton
            // 
            this.FromImageRadioButton.AutoSize = true;
            this.FromImageRadioButton.Location = new System.Drawing.Point(31, 82);
            this.FromImageRadioButton.Name = "FromImageRadioButton";
            this.FromImageRadioButton.Size = new System.Drawing.Size(164, 19);
            this.FromImageRadioButton.TabIndex = 4;
            this.FromImageRadioButton.TabStop = true;
            this.FromImageRadioButton.Text = "画像ファイルからパズルを生成";
            this.FromImageRadioButton.UseVisualStyleBackColor = true;
            this.FromImageRadioButton.CheckedChanged += new System.EventHandler(this.FromImageRadioButton_CheckedChanged);
            // 
            // FromNumberRadioButton
            // 
            this.FromNumberRadioButton.AutoSize = true;
            this.FromNumberRadioButton.Location = new System.Drawing.Point(31, 57);
            this.FromNumberRadioButton.Name = "FromNumberRadioButton";
            this.FromNumberRadioButton.Size = new System.Drawing.Size(130, 19);
            this.FromNumberRadioButton.TabIndex = 3;
            this.FromNumberRadioButton.TabStop = true;
            this.FromNumberRadioButton.Text = "番号からパズルを生成";
            this.FromNumberRadioButton.UseVisualStyleBackColor = true;
            this.FromNumberRadioButton.CheckedChanged += new System.EventHandler(this.FromNumberRadioButton_CheckedChanged);
            // 
            // PreviewTitleLabel
            // 
            this.PreviewTitleLabel.AutoSize = true;
            this.PreviewTitleLabel.Location = new System.Drawing.Point(268, 30);
            this.PreviewTitleLabel.Name = "PreviewTitleLabel";
            this.PreviewTitleLabel.Size = new System.Drawing.Size(67, 15);
            this.PreviewTitleLabel.TabIndex = 2;
            this.PreviewTitleLabel.Text = "♦ プレビュー";
            // 
            // LevelTitleLabel
            // 
            this.LevelTitleLabel.AutoSize = true;
            this.LevelTitleLabel.Location = new System.Drawing.Point(18, 140);
            this.LevelTitleLabel.Name = "LevelTitleLabel";
            this.LevelTitleLabel.Size = new System.Drawing.Size(99, 15);
            this.LevelTitleLabel.TabIndex = 1;
            this.LevelTitleLabel.Text = "♦ パズルの難易度";
            // 
            // FromTitleLabel
            // 
            this.FromTitleLabel.AutoSize = true;
            this.FromTitleLabel.Location = new System.Drawing.Point(18, 30);
            this.FromTitleLabel.Name = "FromTitleLabel";
            this.FromTitleLabel.Size = new System.Drawing.Size(93, 15);
            this.FromTitleLabel.TabIndex = 0;
            this.FromTitleLabel.Text = "♦ 生成元の画像";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(278, 248);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 31);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "生成(&O)";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(359, 248);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 31);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "キャンセル(&C)";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 291);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.InfomationGroupBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新規パズル生成";
            this.Load += new System.EventHandler(this.GenerateForm_Load);
            this.InfomationGroupBox.ResumeLayout(false);
            this.InfomationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InfomationGroupBox;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Button ReferenceButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.RadioButton FromImageRadioButton;
        private System.Windows.Forms.RadioButton FromNumberRadioButton;
        private System.Windows.Forms.Label PreviewTitleLabel;
        private System.Windows.Forms.Label LevelTitleLabel;
        private System.Windows.Forms.Label FromTitleLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CloseButton;
    }
}