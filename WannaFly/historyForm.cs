using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WannaFly
{
    public partial class historyForm : Form
    {
        public historyForm()
        {
            InitializeComponent();
           
        }



        private void historyForm_Load(object sender, EventArgs e)
        {

            
            //定义注册表顶级节点 其命名空间是using Microsoft.Win32;  
            RegistryKey historykey;
            //检索当前用户CurrentUser子项Software\\Microsoft\\Internet Explorer\\typedURLs  
            historykey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\typedURLs", true);
            if (historykey == null) { }
            else
            {
                //获取检索的所有值  
                String[] names = historykey.GetValueNames();
                foreach (String str in names)
                {
                      historyDisplay.Items.Add(historykey.GetValue(str).ToString());
                }
            }
            ReadText();
        }


        public void ReadText() // 读取记事本中的文件
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.History);
            //获取项目根目录UrlTxt.txt的路径
            string path = Application.StartupPath.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path += @"\UrlTxt.txt";
            try
            {
                StreamReader sr = new StreamReader(path); //读取记事本中的内容
                while (sr.ReadLine() != null) //将内容添加到地址栏的下拉框中
                {
                    historyDisplay.Items.Add(sr.ReadLine().ToString());
                }
                sr.Close();
            }
            catch
            { }
        }

        private void historyDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
    }
}
