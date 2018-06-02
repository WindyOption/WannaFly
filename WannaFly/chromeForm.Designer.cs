namespace WannaFly
{
    partial class chromeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chromeForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pageBack = new System.Windows.Forms.ToolStripButton();
            this.pageForward = new System.Windows.Forms.ToolStripButton();
            this.pageRefresh = new System.Windows.Forms.ToolStripButton();
            this.pageRevoke = new System.Windows.Forms.ToolStripButton();
            this.pageHome = new System.Windows.Forms.ToolStripButton();
            this.SelectEngine = new System.Windows.Forms.ToolStripDropDownButton();
            this.chromium内核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chrome内核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlAddress = new System.Windows.Forms.ToolStripComboBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.NewPage2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuList = new System.Windows.Forms.ToolStripDropDownButton();
            this.网页源码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网页源码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.Unicode = new System.Windows.Forms.ToolStripMenuItem();
            this.历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSave = new System.Windows.Forms.ToolStripButton();
            this.pageCollect = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.goButton,
            this.NewPage2,
            this.toolStripSeparator3,
            this.searchTextbox,
            this.SearchGo,
            this.toolStripSeparator2,
            this.menuList,
            this.pageSave,
            this.pageCollect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1497, 43);
            this.toolStrip1.TabIndex = 1;
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
            this.pageRevoke.Click += new System.EventHandler(this.pageRevoke_Click);
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
            this.chromium内核ToolStripMenuItem,
            this.chrome内核ToolStripMenuItem});
            this.SelectEngine.Image = global::WannaFly.Properties.Resources.icons8_ie浏览器_480;
            this.SelectEngine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectEngine.Name = "SelectEngine";
            this.SelectEngine.Size = new System.Drawing.Size(34, 40);
            // 
            // chromium内核ToolStripMenuItem
            // 
            this.chromium内核ToolStripMenuItem.Name = "chromium内核ToolStripMenuItem";
            this.chromium内核ToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.chromium内核ToolStripMenuItem.Text = "IE内核";
            // 
            // chrome内核ToolStripMenuItem
            // 
            this.chrome内核ToolStripMenuItem.Name = "chrome内核ToolStripMenuItem";
            this.chrome内核ToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.chrome内核ToolStripMenuItem.Text = "Chrome内核";
            // 
            // urlAddress
            // 
            this.urlAddress.AutoToolTip = true;
            this.urlAddress.Items.AddRange(new object[] {
            "https://www.baidu.com/",
            "https://www.google.com/?gl=us&hl=en&pws=0&gws_rd=cr",
            "https://ie.icoa.cn/",
            "http://www.runoob.com/",
            "https://www.cnblogs.com/1175429393wljblog/p/5398928.html"});
            this.urlAddress.Name = "urlAddress";
            this.urlAddress.Size = new System.Drawing.Size(650, 43);
            this.urlAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlAddress_KeyDown);
            // 
            // goButton
            // 
            this.goButton.Image = global::WannaFly.Properties.Resources.nav_plain_green;
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(47, 40);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // NewPage2
            // 
            this.NewPage2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewPage2.Image = global::WannaFly.Properties.Resources.icons8_加2数学_96;
            this.NewPage2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewPage2.Name = "NewPage2";
            this.NewPage2.Size = new System.Drawing.Size(24, 40);
            this.NewPage2.Text = "新建页面";
            this.NewPage2.Click += new System.EventHandler(this.NewPage2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(280, 43);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // menuList
            // 
            this.menuList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.网页源码ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuList.Image = global::WannaFly.Properties.Resources.icons8_菜单_480;
            this.menuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuList.Name = "menuList";
            this.menuList.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.menuList.Size = new System.Drawing.Size(44, 40);
            this.menuList.Text = "菜单";
            // 
            // 网页源码ToolStripMenuItem
            // 
            this.网页源码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.网页源码ToolStripMenuItem1,
            this.历史ToolStripMenuItem});
            this.网页源码ToolStripMenuItem.Name = "网页源码ToolStripMenuItem";
            this.网页源码ToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
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
            // 
            // Unicode
            // 
            this.Unicode.Name = "Unicode";
            this.Unicode.Size = new System.Drawing.Size(218, 26);
            this.Unicode.Text = "Unicode(UTF-8)";
            this.Unicode.Click += new System.EventHandler(this.Unicode_Click);
            // 
            // 历史ToolStripMenuItem
            // 
            this.历史ToolStripMenuItem.Name = "历史ToolStripMenuItem";
            this.历史ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.历史ToolStripMenuItem.Text = "历史";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // pageSave
            // 
            this.pageSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageSave.Image = global::WannaFly.Properties.Resources.icons8_保存_96;
            this.pageSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageSave.Name = "pageSave";
            this.pageSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pageSave.Size = new System.Drawing.Size(34, 40);
            this.pageSave.Text = "保存";
            // 
            // pageCollect
            // 
            this.pageCollect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageCollect.Image = global::WannaFly.Properties.Resources.icons8_星_96;
            this.pageCollect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageCollect.Name = "pageCollect";
            this.pageCollect.Size = new System.Drawing.Size(24, 40);
            this.pageCollect.Text = "收藏";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1497, 500);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1497, 25);
            this.statusStrip1.TabIndex = 3;
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
            // chromeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chromeForm";
            this.Text = "WannaFly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chromeForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.chromeForm_FormClosed);
            this.Load += new System.EventHandler(this.chromeForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pageBack;
        private System.Windows.Forms.ToolStripButton pageForward;
        private System.Windows.Forms.ToolStripButton pageRefresh;
        private System.Windows.Forms.ToolStripButton pageRevoke;
        private System.Windows.Forms.ToolStripButton pageHome;
        private System.Windows.Forms.ToolStripDropDownButton SelectEngine;
        private System.Windows.Forms.ToolStripMenuItem chromium内核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox urlAddress;
        private System.Windows.Forms.ToolStripButton NewPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox searchTextbox;
        private System.Windows.Forms.ToolStripButton SearchGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton menuList;
        private System.Windows.Forms.ToolStripMenuItem 网页源码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网页源码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GB2312;
        private System.Windows.Forms.ToolStripMenuItem Unicode;
        private System.Windows.Forms.ToolStripMenuItem 历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton pageSave;
        private System.Windows.Forms.ToolStripButton pageCollect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem chrome内核ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton goButton;
    }
}