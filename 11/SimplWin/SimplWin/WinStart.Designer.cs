namespace SimplWin
{
    partial class WinStart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Butstart = new System.Windows.Forms.Button();
            this.Butexit = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Simplemode = new System.Windows.Forms.ToolStripMenuItem();
            this.Standardmode = new System.Windows.Forms.ToolStripMenuItem();
            this.深度优化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义优化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menabout = new System.Windows.Forms.ToolStripMenuItem();
            this.开发者日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Texmain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Labmain = new System.Windows.Forms.Label();
            this.Labsecondly = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Butstart
            // 
            this.Butstart.Location = new System.Drawing.Point(132, 322);
            this.Butstart.Name = "Butstart";
            this.Butstart.Size = new System.Drawing.Size(128, 36);
            this.Butstart.TabIndex = 10;
            this.Butstart.Text = "开始优化";
            this.Butstart.UseVisualStyleBackColor = true;
            this.Butstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Butexit
            // 
            this.Butexit.Location = new System.Drawing.Point(324, 322);
            this.Butexit.Name = "Butexit";
            this.Butexit.Size = new System.Drawing.Size(128, 36);
            this.Butexit.TabIndex = 11;
            this.Butexit.Text = "退  出";
            this.Butexit.UseVisualStyleBackColor = true;
            this.Butexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Simplemode,
            this.设置ToolStripMenuItem,
            this.Menabout,
            this.开发者日志ToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(584, 25);
            this.Menu.TabIndex = 13;
            this.Menu.Text = "菜单";
            // 
            // Simplemode
            // 
            this.Simplemode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Standardmode,
            this.深度优化ToolStripMenuItem,
            this.自定义优化ToolStripMenuItem});
            this.Simplemode.Name = "Simplemode";
            this.Simplemode.Size = new System.Drawing.Size(68, 21);
            this.Simplemode.Text = "优化模式";
            // 
            // Standardmode
            // 
            this.Standardmode.Name = "Standardmode";
            this.Standardmode.Size = new System.Drawing.Size(136, 22);
            this.Standardmode.Text = "标准优化";
            // 
            // 深度优化ToolStripMenuItem
            // 
            this.深度优化ToolStripMenuItem.Name = "深度优化ToolStripMenuItem";
            this.深度优化ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.深度优化ToolStripMenuItem.Text = "完全优化";
            // 
            // 自定义优化ToolStripMenuItem
            // 
            this.自定义优化ToolStripMenuItem.Name = "自定义优化ToolStripMenuItem";
            this.自定义优化ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.自定义优化ToolStripMenuItem.Text = "自定义优化";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存设置ToolStripMenuItem,
            this.保存设置ToolStripMenuItem1});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设置ToolStripMenuItem.Text = "设置相关";
            // 
            // 保存设置ToolStripMenuItem
            // 
            this.保存设置ToolStripMenuItem.Name = "保存设置ToolStripMenuItem";
            this.保存设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存设置ToolStripMenuItem.Text = "载入设置";
            // 
            // 保存设置ToolStripMenuItem1
            // 
            this.保存设置ToolStripMenuItem1.Name = "保存设置ToolStripMenuItem1";
            this.保存设置ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.保存设置ToolStripMenuItem1.Text = "保存设置";
            // 
            // Menabout
            // 
            this.Menabout.Name = "Menabout";
            this.Menabout.Size = new System.Drawing.Size(44, 21);
            this.Menabout.Text = "关于";
            // 
            // 开发者日志ToolStripMenuItem
            // 
            this.开发者日志ToolStripMenuItem.Name = "开发者日志ToolStripMenuItem";
            this.开发者日志ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.开发者日志ToolStripMenuItem.Text = "开发者日志";
            // 
            // Texmain
            // 
            this.Texmain.BackColor = System.Drawing.Color.White;
            this.Texmain.Location = new System.Drawing.Point(73, 166);
            this.Texmain.Multiline = true;
            this.Texmain.Name = "Texmain";
            this.Texmain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Texmain.Size = new System.Drawing.Size(440, 129);
            this.Texmain.TabIndex = 14;
            this.Texmain.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "-14像素 实际586像素";
            // 
            // Labmain
            // 
            this.Labmain.AutoSize = true;
            this.Labmain.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Labmain.Location = new System.Drawing.Point(85, 76);
            this.Labmain.Name = "Labmain";
            this.Labmain.Size = new System.Drawing.Size(416, 48);
            this.Labmain.TabIndex = 16;
            this.Labmain.Text = "欢迎使用SimplWin";
            // 
            // Labsecondly
            // 
            this.Labsecondly.AutoSize = true;
            this.Labsecondly.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.Labsecondly.Location = new System.Drawing.Point(120, 177);
            this.Labsecondly.Name = "Labsecondly";
            this.Labsecondly.Size = new System.Drawing.Size(345, 40);
            this.Labsecondly.TabIndex = 17;
            this.Labsecondly.Text = "正在等待您的操作";
            // 
            // WinStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.Labsecondly);
            this.Controls.Add(this.Labmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Texmain);
            this.Controls.Add(this.Butexit);
            this.Controls.Add(this.Butstart);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "WinStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.WinStart_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Butstart;
        private System.Windows.Forms.Button Butexit;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Simplemode;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Standardmode;
        private System.Windows.Forms.ToolStripMenuItem 深度优化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义优化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menabout;
        private System.Windows.Forms.ToolStripMenuItem 开发者日志ToolStripMenuItem;
        private System.Windows.Forms.TextBox Texmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labmain;
        private System.Windows.Forms.Label Labsecondly;
    }
}

