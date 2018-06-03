namespace WannaFly
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.urlAddress = new System.Windows.Forms.ToolStripComboBox();
            this.searchTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pageBack = new System.Windows.Forms.ToolStripButton();
            this.pageForward = new System.Windows.Forms.ToolStripButton();
            this.pageRefresh = new System.Windows.Forms.ToolStripButton();
            this.pageRevoke = new System.Windows.Forms.ToolStripButton();
            this.pageHome = new System.Windows.Forms.ToolStripButton();
            this.SelectEngine = new System.Windows.Forms.ToolStripDropDownButton();
            this.chromium内核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPage1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchGo = new System.Windows.Forms.ToolStripButton();
            this.menuList = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressBar = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网页源码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网页源码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.Unicode = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFavorites = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlAddress
            // 
            this.urlAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.urlAddress.AutoToolTip = true;
            this.urlAddress.Items.AddRange(new object[] {
            "https://www.baidu.com/",
            "https://www.google.com/?gl=us&hl=en&pws=0&gws_rd=cr",
            "https://ie.icoa.cn/",
            "http://www.runoob.com/",
            "https://www.cnblogs.com/1175429393wljblog/p/5398928.html"});
            this.urlAddress.Name = "urlAddress";
            this.urlAddress.Size = new System.Drawing.Size(650, 43);
            this.urlAddress.SelectedIndexChanged += new System.EventHandler(this.urlAddress_SelectedIndexChanged);
            this.urlAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlAddress_KeyDown);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(280, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageBack,
            this.pageForward,
            this.pageRefresh,
            this.pageRevoke,
            this.pageHome,
            this.SelectEngine,
            this.urlAddress,
            this.newPage1,
            this.toolStripSeparator3,
            this.searchTextbox,
            this.SearchGo,
            this.toolStripSeparator2,
            this.menuList,
            this.btnFavorites});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1750, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pageBack
            // 
            this.pageBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageBack.Image = global::WannaFly.Properties.Resources.icons8_左_96;
            this.pageBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageBack.Name = "pageBack";
            this.pageBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageBack.Size = new System.Drawing.Size(34, 40);
            this.pageBack.Text = "后退";
            this.pageBack.Click += new System.EventHandler(this.pageBack_Click);
            // 
            // pageForward
            // 
            this.pageForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageForward.Image = global::WannaFly.Properties.Resources.icons8_右_96;
            this.pageForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageForward.Name = "pageForward";
            this.pageForward.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageForward.Size = new System.Drawing.Size(34, 40);
            this.pageForward.Text = "前进";
            this.pageForward.Click += new System.EventHandler(this.pageForward_Click);
            // 
            // pageRefresh
            // 
            this.pageRefresh.AutoSize = false;
            this.pageRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pageRefresh.Image")));
            this.pageRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageRefresh.Name = "pageRefresh";
            this.pageRefresh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageRefresh.Size = new System.Drawing.Size(34, 30);
            this.pageRefresh.Text = "刷新";
            this.pageRefresh.Click += new System.EventHandler(this.pageRefresh_Click);
            // 
            // pageRevoke
            // 
            this.pageRevoke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageRevoke.Image = global::WannaFly.Properties.Resources.icons8_左上_96;
            this.pageRevoke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageRevoke.Name = "pageRevoke";
            this.pageRevoke.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageRevoke.Size = new System.Drawing.Size(34, 40);
            this.pageRevoke.Text = "撤销";
            // 
            // pageHome
            // 
            this.pageHome.AutoSize = false;
            this.pageHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageHome.Image = global::WannaFly.Properties.Resources.icons8_首页_480;
            this.pageHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageHome.Size = new System.Drawing.Size(40, 40);
            this.pageHome.Text = "主页";
            this.pageHome.Click += new System.EventHandler(this.pageHome_Click);
            // 
            // SelectEngine
            // 
            this.SelectEngine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectEngine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chromium内核ToolStripMenuItem});
            this.SelectEngine.Image = global::WannaFly.Properties.Resources.icons8_ie浏览器_480;
            this.SelectEngine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectEngine.Name = "SelectEngine";
            this.SelectEngine.Size = new System.Drawing.Size(34, 40);
            // 
            // chromium内核ToolStripMenuItem
            // 
            this.chromium内核ToolStripMenuItem.Name = "chromium内核ToolStripMenuItem";
            this.chromium内核ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.chromium内核ToolStripMenuItem.Text = "Chromium内核";
            this.chromium内核ToolStripMenuItem.Click += new System.EventHandler(this.chromium内核ToolStripMenuItem_Click);
            // 
            // newPage1
            // 
            this.newPage1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPage1.Image = global::WannaFly.Properties.Resources.icons8_加2数学_96;
            this.newPage1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPage1.Name = "newPage1";
            this.newPage1.Size = new System.Drawing.Size(24, 40);
            this.newPage1.Text = "新建页面";
            this.newPage1.Click += new System.EventHandler(this.newPage1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // SearchGo
            // 
            this.SearchGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchGo.Image = global::WannaFly.Properties.Resources.icons8_谷歌徽标_96;
            this.SearchGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchGo.Name = "SearchGo";
            this.SearchGo.Size = new System.Drawing.Size(24, 40);
            this.SearchGo.Text = "搜索";
            this.SearchGo.Click += new System.EventHandler(this.SearchGo_Click);
            // 
            // menuList
            // 
            this.menuList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.favoriteFile,
            this.menuHistory,
            this.网页源码ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuList.Image = global::WannaFly.Properties.Resources.icons8_菜单_480;
            this.menuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuList.Name = "menuList";
            this.menuList.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menuList.Size = new System.Drawing.Size(44, 40);
            this.menuList.Text = "菜单";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(181, 26);
            this.menuSave.Text = "保存";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // favoriteFile
            // 
            this.favoriteFile.Name = "favoriteFile";
            this.favoriteFile.Size = new System.Drawing.Size(181, 26);
            this.favoriteFile.Text = "收藏夹";
            this.favoriteFile.Click += new System.EventHandler(this.favoriteFile_Click);
            // 
            // menuHistory
            // 
            this.menuHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddressBar,
            this.浏览记录ToolStripMenuItem});
            this.menuHistory.Name = "menuHistory";
            this.menuHistory.Size = new System.Drawing.Size(181, 26);
            this.menuHistory.Text = "历史";
            this.menuHistory.Click += new System.EventHandler(this.menuHistory_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(181, 26);
            this.AddressBar.Text = "地址栏";
            this.AddressBar.Click += new System.EventHandler(this.AddressBar_Click);
            // 
            // 浏览记录ToolStripMenuItem
            // 
            this.浏览记录ToolStripMenuItem.Name = "浏览记录ToolStripMenuItem";
            this.浏览记录ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.浏览记录ToolStripMenuItem.Text = "浏览记录";
            this.浏览记录ToolStripMenuItem.Click += new System.EventHandler(this.浏览记录ToolStripMenuItem_Click);
            // 
            // 网页源码ToolStripMenuItem
            // 
            this.网页源码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.网页源码ToolStripMenuItem1});
            this.网页源码ToolStripMenuItem.Name = "网页源码ToolStripMenuItem";
            this.网页源码ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.网页源码ToolStripMenuItem.Text = "查看";
            // 
            // 网页源码ToolStripMenuItem1
            // 
            this.网页源码ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GB2312,
            this.Unicode});
            this.网页源码ToolStripMenuItem1.Name = "网页源码ToolStripMenuItem1";
            this.网页源码ToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.网页源码ToolStripMenuItem1.Text = "网页源码";
            // 
            // GB2312
            // 
            this.GB2312.Name = "GB2312";
            this.GB2312.Size = new System.Drawing.Size(218, 26);
            this.GB2312.Text = "简体中文（GB2312）";
            this.GB2312.Click += new System.EventHandler(this.GB2312_Click);
            // 
            // Unicode
            // 
            this.Unicode.Name = "Unicode";
            this.Unicode.Size = new System.Drawing.Size(218, 26);
            this.Unicode.Text = "Unicode(UTF-8)";
            this.Unicode.Click += new System.EventHandler(this.Unicode_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavorites.Image = global::WannaFly.Properties.Resources.icons8_星_96;
            this.btnFavorites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(24, 40);
            this.btnFavorites.Text = "收藏";
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 597);
            this.panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1750, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(500, 20);
            this.toolStripStatusLabel1.Text = "Status";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(680, 3, 0, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(220, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1750, 597);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 40);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 40);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "WannaFly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripButton pageBack;
        private System.Windows.Forms.ToolStripButton pageForward;
        private System.Windows.Forms.ToolStripButton pageRefresh;
        private System.Windows.Forms.ToolStripButton pageRevoke;
        private System.Windows.Forms.ToolStripButton pageHome;
        private System.Windows.Forms.ToolStripComboBox urlAddress;
        private System.Windows.Forms.ToolStripTextBox searchTextbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton SearchGo;
        private System.Windows.Forms.ToolStripDropDownButton menuList;
        private System.Windows.Forms.ToolStripDropDownButton SelectEngine;
        private System.Windows.Forms.ToolStripButton btnFavorites;
        private System.Windows.Forms.ToolStripMenuItem chromium内核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 网页源码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网页源码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem GB2312;
        private System.Windows.Forms.ToolStripMenuItem Unicode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton newPage1;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem favoriteFile;
        private System.Windows.Forms.ToolStripMenuItem menuHistory;
        private System.Windows.Forms.ToolStripMenuItem AddressBar;
        private System.Windows.Forms.ToolStripMenuItem 浏览记录ToolStripMenuItem;
    }
}

