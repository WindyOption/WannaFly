using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using CefSharp;
using CefSharp.WinForms;
using FarsiLibrary.Win;
using System.Web;
using IWshRuntimeLibrary;



namespace WannaFly
{
    public partial class mainForm : Form
    {
        int TITLE_COUNT = 12;
        string urlHomePage = "https://www.baidu.com/";
        Stack<string> st = new Stack<string>();
        int flag = 0;

        public mainForm()
        {
            InitializeComponent();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        { 
           initMainForm();
           ReadText();
        }

        #region 初始化当前的浏览器窗体
        private void initMainForm()
        {
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            mypage.Text = tempBrowser.DocumentTitle;
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.Dock = DockStyle.Fill;//动态的需要用代码来控制页面填充
            tempBrowser.GoHome() ;//启动导航到主页
            mypage.Controls.Add(tempBrowser);//一个page可以添加很多控件进来          
            tabControl1.TabPages.Add(mypage);
        }
        #endregion


        #region 工具栏
        private void pageBack_Click(object sender, EventArgs e)
        {
            
            getCurrentBrowser().GoBack();
            setStatusButton();
        }
        private void pageForward_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoForward();
            setStatusButton();
        }
        private void pageRefresh_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }
        private void pageHome_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoHome();
        }


        #region 地址栏相关
        //记录历史URL
        private void addItem_urlAddress()
        {
            int addressIndex = urlAddress.FindStringExact(urlAddress.Text);
            if (addressIndex < 100)
                urlAddress.Items.Add(urlAddress.Text);
        }

        //地址栏回车：一种手动输入，一种下拉表选择
        private void urlAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //statusStrip1.Text = "正在打开网页" + urlAddress.Text + "...";
                newCurrentPageUrl(urlAddress.Text);
                addItem_urlAddress();
                
            }
        }

        //地址栏选中地址直接跳转到此页面
        private void urlAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            urlAddress.Text = urlAddress.SelectedItem.ToString();
            getCurrentBrowser().Navigate(urlAddress.Text);
            
        }

        //在当前页先处理地址再跳转
        private void newCurrentPageUrl(String address)
        {
            getCurrentBrowser().Navigate(getUrl(address));
            
        }

        //处理地址栏中的字符串
        private Uri getUrl(string address)
        {
            string tempaddress = address;
            if ((!address.StartsWith("http://")) && (!address.StartsWith("https://")) && (!address.StartsWith("ftp://")))
            {
                tempaddress = "http://" + address;
            }
            Uri myurl;
            try
            {
                myurl = new Uri(tempaddress);
            }
            catch
            {
                myurl = new Uri("about:blank");
            }
            return myurl;
        }

      
        #endregion

        //新建页面
        private void newPage1_Click(object sender, EventArgs e)
        {
            newPage();
        }

        #region 集成搜索引擎
        private void SearchGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTextbox.Text))
            {
               GoogleSearch();
            }
       
        }

        //百度搜索就实现啦
        void BaiduSearch()
        {
            /*Encoding gb2312Encoding = Encoding.GetEncoding("UTF-8");
            string uri = "http://www.baidu.com/s?wd=" + HttpUtility.UrlEncode(searchTextbox.Text, gb2312Encoding);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream, Encoding.UTF8);
            getCurrentBrowser().DocumentText = sr.ReadToEnd();
            sr.Close();
            stream.Close();*/

            //getCurrentBrowser().Navigate("http://www.baidu.com/s?wd="+searchTextbox.Text);
            

        }

        //谷歌搜索的方法实现
        void GoogleSearch()
        {
            getCurrentBrowser().Navigate("http://www.google.com/search?q=" + searchTextbox.Text);
        }
        #endregion


        private void pageSave_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowSaveAsDialog();
        }
        #endregion


        #region 常用方法

        //设置前进、后退按钮的状态
        private void setStatusButton()
        {
            pageBack.Enabled = getCurrentBrowser().CanGoBack;
            pageForward.Enabled = getCurrentBrowser().CanGoForward;
        }

        //获取当前的浏览器
        private WebBrowser getCurrentBrowser()
        {
            WebBrowser currentBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            return currentBrowser;
        }



        //新建空白页面方法
        void newPage()
        {
            urlAddress.Text = "about:blank";
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            mypage.Text = tempBrowser.DocumentTitle;
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tabControl1.TabPages.Add(mypage);
            tabControl1.SelectedTab = mypage;
        }

        private void pageRevoke_Click(object sender, EventArgs e)
        {
            int size = st.Count();
            if(size>0)
            {
                returnPage(st.Peek());
                st.Pop();
                flag--;
                size--;
            }
           
        }

        void returnPage(string address)
        {
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.Url = getUrl(address);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tabControl1.TabPages.Add(mypage);
        }

      


        //控制进度条变化
        void tempBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                //----进度条有bug----页面跳转时-----例如：百度新闻页面的跳转提示是值的问题
                //bug解决！！！
                toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
                toolStripProgressBar1.Step = (int)e.CurrentProgress;
                toolStripProgressBar1.PerformStep();
            }
            else if (getCurrentBrowser().ReadyState== WebBrowserReadyState.Complete)
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = false;
            }
            setStatusButton();
        }

        //截取字符串为指定长度，显示在tabpage标题栏
        private string newstring(string oldstring)
        {
            string temp;
            if(oldstring.Length<TITLE_COUNT)
            {
                temp = oldstring;
            }
            else
            {
                temp = oldstring.Substring(0, TITLE_COUNT);
            }
            return temp;
        }

        #endregion


        #region 临时浏览器的相关事件

        //临时浏览器状态变化
        void tempBrowser_StatusTextChanged(object sender,EventArgs e)
        {
            WebBrowser myBrowser = (WebBrowser)sender;
            if (myBrowser != getCurrentBrowser())
                return;
            else
                toolStripStatusLabel1.Text = myBrowser.StatusText;
        }

        //临时浏览器定向完毕
        private void tempBrowser_Navigated(object sender,WebBrowserNavigatedEventArgs e)
        {
            urlAddress.Text = getCurrentBrowser().Url.ToString();//获取浏览器的当前网址
            WebBrowser myBrowser = (WebBrowser)sender;//实例化webbrowser
            TabPage mypage = (TabPage)myBrowser.Parent;//实例化tabpage
            mypage.Text = newstring(myBrowser.DocumentTitle);//设置临时浏览器所在的tab标题
        }

        //临时浏览器产生新窗体事件
        void tempBrowser_NewWindow(object sender, CancelEventArgs e)
        {

            WebBrowser myBrowser = (WebBrowser)sender;//获取触发该事件的浏览器
            TabPage mypage = (TabPage)myBrowser.Parent;//获取触发该事件的浏览器所在的tabpage
            if(flag==0)
            {
                string newURL = ((WebBrowser)sender).StatusText;//通过点击的statustext属性获得新的url
                if (ModifierKeys == Keys.Control)
                {
                    TabPage tabpageTEMP = new TabPage();//生成新的一页
                    WebBrowser tempBrowser = new WebBrowser();//生成新的临时浏览器
                    tempBrowser.Navigate(newURL);//临时浏览器定向到新的url

                    tabpageTEMP.Text = newstring(tempBrowser.DocumentTitle);
                    tempBrowser.Dock = DockStyle.Fill;
                    //为临时浏览器关联new window等事件
                    tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
                    tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
                    tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
                    tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
                    tabpageTEMP.Controls.Add(tempBrowser);//将临时浏览器添加到临时tabpage中
                    this.tabControl1.TabPages.Add(tabpageTEMP);//将临时tabpage添加到主窗体中
                                                               //-------------这是他么怎么解决这些问题（自动刷新，跳转显示）的----我就加了下面这个---------------
                    this.tabControl1.SelectedTab = tabpageTEMP;
                    e.Cancel = true;//使外部无法捕获此事件
                }
                else
                {
                    getCurrentBrowser().Navigate(newURL);
                    mypage.Text = getCurrentBrowser().DocumentTitle;
                    urlAddress.Text = newURL;
                    e.Cancel = true;
                }
            }
            if(flag>0)
            {                                   
                TabPage TabPageTemp = new TabPage();        
                WebBrowser tempBrowser = new WebBrowser();
                tempBrowser.Navigate(urlAddress.Text);
                tempBrowser.Dock = DockStyle.Fill;
                tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
                tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);            
                tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
                tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
                //将临时浏览器添加到临时TabPage中
                TabPageTemp.Controls.Add(tempBrowser);
                //将临时TabPage添加到主窗体中            
                this.tabControl1.TabPages.Add(TabPageTemp);
                //使外部无法捕获此事件            
                e.Cancel = true;
            }        
        }   
        #endregion


        #region 菜单
        //关于：显示内核版本
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(getCurrentBrowser().Version.ToString(), "IE Kernal Version");
        }

        //查看源码GB2312方式
        private void GB2312_Click(object sender, EventArgs e)
        {
            frmCodeView dlgCodeView = new frmCodeView();
            dlgCodeView.Text = "网页源码(采用GB2312编码)";
            dlgCodeView.Show();
            StreamReader sr = new StreamReader(getCurrentBrowser().DocumentStream, Encoding.Default);    //首先必须解码
            dlgCodeView.setCode = sr.ReadToEnd();
            sr.Close();
        }
        //查看源码UTF-8方式
        private void Unicode_Click(object sender, EventArgs e)
        {
            frmCodeView dlgCodeView = new frmCodeView();
            dlgCodeView.Text = "网页源码(采用UTF-8编码)";
            dlgCodeView.Show();
            StreamReader sr = new StreamReader(getCurrentBrowser().DocumentStream, Encoding.UTF8);    //解析采用UTF-8编码形式的网页
            dlgCodeView.setCode = sr.ReadToEnd();
            sr.Close();
        }
        #endregion


        #region tabcontrol1相关事件
        //切换不同的tab触发的事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser mybor = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            if (mybor.Url != null)
            {
                //地址输入框
                urlAddress.Text = mybor.Url.ToString();
                tabControl1.SelectedTab.Text = newstring(mybor.DocumentTitle);
            }
            else
            {
               urlAddress.Text = "about:blank";
                tabControl1.SelectedTab.Text = "空白页";
            }
            setStatusButton();
        }

        //关闭指定的tab
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            st.Push(urlAddress.Text);
            //仅仅剩下一个tab时返回
            if (tabControl1.TabPages.Count <= 1)
            {
                tabControl1.SelectedTab.Text = "空白页";
                getCurrentBrowser().Navigate("about:blank");
                flag++;
            }
            else
            {   
                //先将tabControl1隐藏然后remove掉目标tab（如果不隐藏则出现闪烁，即系统自动调转到tabControl1的第一个tab然后跳会。）最后显示tabControl1。
                tabControl1.Visible = false;
                WebBrowser mybor = getCurrentBrowser();
                //释放资源
                mybor.Dispose();
                mybor.Controls.Clear();
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                //重新设置当前tab
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                tabControl1.Visible = true;
                flag++;
            }
        }

        #endregion


        #region 已解决的问题
        //很多页面提示的脚本错误》》》已解决：修改注册表，提高IE渲染版本
        //进度条的异常
        //ctrl新页面打开点击链接，没有则当前页面打开
        //切换选项卡的网页自动刷新----改善：从缓存中读
        //嵌入引擎+内核的选择控制如何生效
        //页面内访问的时候选择在新标签页打开和自身打开，在新标签也打开时，要自动显示那个标签页
        #endregion


        #region 待解决的问题
        //撤销功能的实现
        //同步集成IE
      
        //标签页text的显示问题
        //查看网页源码的优化：排版，正确显示！
        //地址栏选中跳转一些相关的事件触发，比如进度条显示
        #endregion

        private void chromium内核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeForm cf = new chromeForm(urlAddress.Text);
            cf.Owner = this;
            this.Hide();
            cf.Show();

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowSaveAsDialog();
        }

     

        //收藏的函数实现
        private void addFavorites(string url, string filename, string savepath)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            if (!System.IO.File.Exists(path + "\\" + filename + savepath + ".url"))
            {
                IWshShell_Class shell = new IWshShell_ClassClass();
                IWshURLShortcut shortcut = null;
                if (savepath == "Favorites")
                {
                    shortcut = shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + filename + ".url") as IWshURLShortcut;
                    toolStripStatusLabel1.Text = "...当前页面收藏完成";
                }
                else
                {
                    shortcut = shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + savepath + "\\" + filename + ".url") as IWshURLShortcut;
                }
                shortcut.TargetPath = url;
                shortcut.Save();
            }
        }


        //点击收藏按钮的功能
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            //if (urlAddress.Text.Trim() == "about:blank" || urlAddress.Text.Trim() == " " || !urlAddress.Text.Trim().StartsWith("http://"))
            if (urlAddress.Text.Trim() == "about:blank" || urlAddress.Text.Trim() == " ")
            { }
            else
            {
                string favoURL = urlAddress.Text.Trim();
                string favoTitle = getCurrentBrowser().DocumentTitle;

                try
                {
                    addFavorites(favoURL, favoTitle, "Favorites");
                 
                }
                catch(Exception ex)
                {
                    toolStripStatusLabel1.Text = "..?.收藏.?..";
                }
            }
        }


        //整理收藏夹
        private void favoriteFile_Click(object sender, EventArgs e)
        {
            favoritesForm favorForm = new favoritesForm();
            favorForm.ShowDialog();
        }

        private void menuHistory_Click(object sender, EventArgs e)
        {
           
        }

        private void AddressBar_Click(object sender, EventArgs e)
        {
            historyForm history = new historyForm();
            history.ShowDialog();
        }

        private void 浏览记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewHistory form = new viewHistory();
            form.ShowDialog();
        }

        //只要是webbrowser访问的自动进入IE历史记录文件的
        //将浏览过的网址写入记事本中
        public void WriteText(string s)                                              
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.History);
           //获取项目根目录UrlTxt.txt的路径
           //string path = Application.StartupPath.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path += @"\UrlTxt.txt";
            System.IO.StreamWriter sw = new StreamWriter(path, true); //实例化StreamWriter
            sw.WriteLine(s);  //将网址写入记事本
            sw.Close();
        }

     
        public void ReadText() // 读取记事本中的文件
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.History);
            //获取项目根目录UrlTxt.txt的路径
            //string path = Application.StartupPath.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path += @"\UrlTxt.txt";
            try
            {
                StreamReader sr = new StreamReader(path); //读取记事本中的内容
                while (sr.ReadLine() != null) //将内容添加到地址栏的下拉框中
                {
                    urlAddress.Items.Add(sr.ReadLine().ToString());
                }
                sr.Close();
            }
            catch
            { }
        }

        
    }
}
