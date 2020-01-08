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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.AssistLabel = new System.Windows.Forms.Label();
            this.StateTitleLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.LevelTitleLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.TimeTitleLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CountTitleLabel = new System.Windows.Forms.Label();
            this.SlideCountLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateToolStripMenuItem
            // 
            this.GenerateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GenerateToolStripMenuItem.Image")));
            this.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem";
            this.GenerateToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.GenerateToolStripMenuItem.Text = "新規パズル生成(&G)";
            this.GenerateToolStripMenuItem.Click += new System.EventHandler(this.GenerateToolStripMenuItem_Click);
            // 
            // BoardPanel
            // 
            this.BoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoardPanel.Location = new System.Drawing.Point(12, 37);
            this.BoardPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(300, 300);
            this.BoardPanel.TabIndex = 1;
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
            // StateTitleLabel
            // 
            this.StateTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StateTitleLabel.Location = new System.Drawing.Point(318, 37);
            this.StateTitleLabel.Name = "StateTitleLabel";
            this.StateTitleLabel.Size = new System.Drawing.Size(117, 25);
            this.StateTitleLabel.TabIndex = 22;
            this.StateTitleLabel.Text = "状態";
            this.StateTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateLabel
            // 
            this.StateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StateLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StateLabel.Location = new System.Drawing.Point(318, 62);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(117, 43);
            this.StateLabel.TabIndex = 23;
            this.StateLabel.Text = "待機中";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // SlideCountLabel
            // 
            this.SlideCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SlideCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SlideCountLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SlideCountLabel.Location = new System.Drawing.Point(318, 275);
            this.SlideCountLabel.Name = "SlideCountLabel";
            this.SlideCountLabel.Size = new System.Drawing.Size(117, 43);
            this.SlideCountLabel.TabIndex = 29;
            this.SlideCountLabel.Text = "0回";
            this.SlideCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewLineToolStripMenuItem,
            this.ViewNumberToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ViewToolStripMenuItem.Text = "表示(&V)";
            // 
            // ViewLineToolStripMenuItem
            // 
            this.ViewLineToolStripMenuItem.CheckOnClick = true;
            this.ViewLineToolStripMenuItem.Name = "ViewLineToolStripMenuItem";
            this.ViewLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ViewLineToolStripMenuItem.Text = "仕切り線";
            this.ViewLineToolStripMenuItem.Click += new System.EventHandler(this.ViewLineToolStripMenuItem_Click);
            // 
            // ViewNumberToolStripMenuItem
            // 
            this.ViewNumberToolStripMenuItem.CheckOnClick = true;
            this.ViewNumberToolStripMenuItem.Name = "ViewNumberToolStripMenuItem";
            this.ViewNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ViewNumberToolStripMenuItem.Text = "項番";
            this.ViewNumberToolStripMenuItem.Click += new System.EventHandler(this.ViewNumberToolStripMenuItem_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 363);
            this.Controls.Add(this.SlideCountLabel);
            this.Controls.Add(this.CountTitleLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTitleLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelTitleLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.StateTitleLabel);
            this.Controls.Add(this.AssistLabel);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PlayForm";
            this.Text = "SlidePuzzle";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GenerateToolStripMenuItem;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Label AssistLabel;
        private System.Windows.Forms.Label StateTitleLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label LevelTitleLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label TimeTitleLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CountTitleLabel;
        private System.Windows.Forms.Label SlideCountLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewNumberToolStripMenuItem;
    }
}

