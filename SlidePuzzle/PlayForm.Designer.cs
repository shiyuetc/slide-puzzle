namespace SlidePuzzle
{
    partial class PlayForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoardPannel = new System.Windows.Forms.Panel();
            this.AssistLabel = new System.Windows.Forms.Label();
            this.StatusTitleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LevelTitleLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.TimeTitleLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CountTitleLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateToolStripMenuItem
            // 
            this.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem";
            this.GenerateToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.GenerateToolStripMenuItem.Text = "新規パズル生成";
            // 
            // BoardPannel
            // 
            this.BoardPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoardPannel.Location = new System.Drawing.Point(12, 37);
            this.BoardPannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoardPannel.Name = "BoardPannel";
            this.BoardPannel.Size = new System.Drawing.Size(300, 300);
            this.BoardPannel.TabIndex = 1;
            // 
            // AssistLabel
            // 
            this.AssistLabel.AutoSize = true;
            this.AssistLabel.Font = new System.Drawing.Font("Meiryo UI", 8F);
            this.AssistLabel.Location = new System.Drawing.Point(12, 341);
            this.AssistLabel.Name = "AssistLabel";
            this.AssistLabel.Size = new System.Drawing.Size(258, 14);
            this.AssistLabel.TabIndex = 21;
            this.AssistLabel.Text = "※W,A,S,Dキー、矢印キーまたは左クリックでパネルを移動";
            // 
            // StatusTitleLabel
            // 
            this.StatusTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusTitleLabel.Location = new System.Drawing.Point(318, 37);
            this.StatusTitleLabel.Name = "StatusTitleLabel";
            this.StatusTitleLabel.Size = new System.Drawing.Size(117, 25);
            this.StatusTitleLabel.TabIndex = 22;
            this.StatusTitleLabel.Text = "状態";
            this.StatusTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusLabel.Location = new System.Drawing.Point(318, 62);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(117, 43);
            this.StatusLabel.TabIndex = 23;
            this.StatusLabel.Text = "待機中";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelTitleLabel
            // 
            this.LevelTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LevelTitleLabel.Location = new System.Drawing.Point(318, 108);
            this.LevelTitleLabel.Name = "LevelTitleLabel";
            this.LevelTitleLabel.Size = new System.Drawing.Size(117, 25);
            this.LevelTitleLabel.TabIndex = 24;
            this.LevelTitleLabel.Text = "難易度";
            this.LevelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LevelLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LevelLabel.Location = new System.Drawing.Point(318, 133);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(117, 43);
            this.LevelLabel.TabIndex = 25;
            this.LevelLabel.Text = "Lv1";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeTitleLabel
            // 
            this.TimeTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeTitleLabel.Location = new System.Drawing.Point(318, 179);
            this.TimeTitleLabel.Name = "TimeTitleLabel";
            this.TimeTitleLabel.Size = new System.Drawing.Size(117, 25);
            this.TimeTitleLabel.TabIndex = 26;
            this.TimeTitleLabel.Text = "経過時間";
            this.TimeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(318, 204);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(117, 43);
            this.TimeLabel.TabIndex = 27;
            this.TimeLabel.Text = "0秒";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountTitleLabel
            // 
            this.CountTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountTitleLabel.Location = new System.Drawing.Point(318, 250);
            this.CountTitleLabel.Name = "CountTitleLabel";
            this.CountTitleLabel.Size = new System.Drawing.Size(117, 25);
            this.CountTitleLabel.TabIndex = 28;
            this.CountTitleLabel.Text = "回転回数";
            this.CountTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CountLabel.Location = new System.Drawing.Point(318, 275);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(117, 43);
            this.CountLabel.TabIndex = 29;
            this.CountLabel.Text = "0回";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 363);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountTitleLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTitleLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelTitleLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusTitleLabel);
            this.Controls.Add(this.AssistLabel);
            this.Controls.Add(this.BoardPannel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PlayForm";
            this.Text = "SlidePuzzle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GenerateToolStripMenuItem;
        private System.Windows.Forms.Panel BoardPannel;
        private System.Windows.Forms.Label AssistLabel;
        private System.Windows.Forms.Label StatusTitleLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LevelTitleLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label TimeTitleLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CountTitleLabel;
        private System.Windows.Forms.Label CountLabel;
    }
}

