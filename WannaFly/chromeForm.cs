using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System.Reflection;
using System.Drawing;
using FarsiLibrary.Win;
using System.IO;
using System.Web;
using System.Threading;
using System.Net;

namespace WannaFly
{
    public partial class chromeForm : Form
    {
        private int TITLE_COUNT = 10;
        private const string blankPage = "about:blank";
        private const string homePage = "https://www.google.com/";

        public chromeForm(string url)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            TabPage curpage = new TabPage();
            urlAddress.Text = url;
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(urlAddress.Text);
            chrome.Dock = DockStyle.Fill;
            curpage.Controls.Add(chrome);
            tabControl1.TabPages.Add(curpage);
            tabControl1.SelectedTab = curpage;

            chrome.LoadingStateChanged += OnLoadingStateChanged;
            chrome.StatusMessage += OnBrowserStatusMessage;
            chrome.TitleChanged += OnBrowserTitleChanged;
            chrome.AddressChanged += OnBrowserAddressChanged;
            //AddTab(url);
            //ResizeBegin += (s, e) => SuspendLayout();
            //ResizeEnd += (s, e) => ResumeLayout(true);
        }


        private void chromeForm_Load(object sender, EventArgs e)
        {

        }

        #region 工具栏

        private void pageBack_Click(object sender, EventArgs e)
        {
            var chromeBrowser = GetCurrentBrowser();
            if (chromeBrowser != null)
            {
                chromeBrowser.Back();
            }
        }

        private void pageForward_Click(object sender, EventArgs e)
        {
            var chromeBrowser = GetCurrentBrowser();
            if (chromeBrowser != null)
            {
                chromeBrowser.Forward();
            }
        }

        private void pageRefresh_Click(object sender, EventArgs e)
        {
            var chromeBrowser = GetCurrentBrowser();
            if (chromeBrowser != null)
            {
                chromeBrowser.Load(urlAddress.Text);
            }
        }

        //撤销关闭！！！
        private void pageRevoke_Click(object sender, EventArgs e)
        {
            var chromeBrowser = GetCurrentBrowser();
            if (chromeBrowser != null)
            {
                chromeBrowser.Undo();
            }
        }

        private void pageHome_Click(object sender, EventArgs e)
        {
            var browser = GetCurrentBrowser();
            browser.Load(homePage);
        }


        private void goButton_Click(object sender, EventArgs e)
        {
            var browser = GetCurrentBrowser();
            browser.Load(urlAddress.Text);
        }

        //新建空白页面
        private void NewPage2_Click(object sender, EventArgs e)
        {
            newTab();
        }
        #endregion




        #region 常用方法
        void newTab()
        {
            TabPage tabpage = new TabPage();//新建一个页面
            urlAddress.Text = homePage;//更新地址栏
            ChromiumWebBrowser browser = new ChromiumWebBrowser(homePage);//新建一个浏览器对象
            browser.Parent = tabpage;//浏览器放入新建页面中
            browser.Dock = DockStyle.Fill;//浏览器在新家页面中的格式
            tabControl1.Controls.Add(tabpage);//把页面加入到tabcontrol上
            tabControl1.SelectedTab = tabpage;
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.TitleChanged += OnBrowserTitleChanged;
        }

      

        //获得当前浏览器ko
        private ChromiumWebBrowser GetCurrentBrowser()
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return null;
            }

            var tabPage = tabControl1.Controls[tabControl1.SelectedIndex];
            var chromeBrowser = (ChromiumWebBrowser)tabPage.Controls[0];

            return chromeBrowser;
        }


        //地址栏记录访问历史
        private void addItem_urlAddress()
        {
            int addressIndex = urlAddress.FindStringExact(urlAddress.Text);
            if (addressIndex < 100)
                urlAddress.Items.Add(urlAddress.Text);
        }


        //内核选择
        private void SelectEngine_Click(object sender, EventArgs e)
        {

        }


        //搜索引擎功能KO
        private void SearchGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTextbox.Text))
            {
                GetCurrentBrowser().Load("http://www.google.com/search?q=" + searchTextbox.Text);
            }
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => pageBack.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            this.InvokeOnUiThreadIfRequired(() => pageForward.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ?
                "Stop" :
                "Go";
            goButton.Image = isLoading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            HandleToolStripLayout();
        }

        private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlAddress)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlAddress.Width = Math.Max(0, width - urlAddress.Margin.Horizontal - 18);
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }

        #endregion


        #region 相关事件
        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        { 
            this.InvokeOnUiThreadIfRequired(() => tabControl1.SelectedTab.Text = args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlAddress.Text = args.Address);
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => toolStripStatusLabel1.Text = args.Value);
        }

        #endregion


        #region 关闭子窗体时，父窗体也关闭
        private void chromeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            var parent = Owner;
            parent.RemoveOwnedForm(this);
            parent.Close();
        }

        private void chromeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        #endregion

        //截取字符串为指定长度，用于显示标题栏
        private string newstring(string oldstring)
        {
            string temp;
            if (oldstring.Length < TITLE_COUNT)
            {
                temp = oldstring;
            }
            else
            {
                temp = oldstring.Substring(0, TITLE_COUNT);
            }
            return temp;
        }

        //标签页双击KO
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count <= 1)
            {
                var browser = GetCurrentBrowser();
                browser.Load("about:blank");
                tabControl1.SelectedTab.Text = "空白页";
            }
            else
            {
                //先将tabControl1隐藏然后remove掉目标tab（如果不隐藏则出现闪烁，即系统自动调转到tabControl1的第一个tab然后跳会。）最后显示tabControl1。
                tabControl1.Visible = false;
                var mybor = GetCurrentBrowser();
                //释放资源
                mybor.Delete();
                mybor.Controls.Clear();
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                //重新设置当前tab
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                tabControl1.Visible = true;
            }
        }


      



        //源码查看：打开一个记事本窗口，而不是在一个Tab页内，暂时就这样
        private void Unicode_Click(object sender, EventArgs e)
        {
            var browser = GetCurrentBrowser();
            browser.ViewSource();
        }


        //地址栏回车
        private void urlAddress_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Enter)
            {
                GetCurrentBrowser().Load(urlAddress.Text);
            }
        }

    }
}
