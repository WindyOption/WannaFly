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
            if (historykey != null)
            {
                //获取检索的所有值  
                String[] names = historykey.GetValueNames();
                foreach (String str in names)
                {
                      historyDisplay.Items.Add(historykey.GetValue(str).ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "IE地址栏没有要删除的网址", "提示对话框", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void historyDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (historyDisplay.SelectedItems.Count == 0) { }
            else
                historyDisplay.Items.Remove(historyDisplay.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            historyDisplay.Items.Clear();
        }
    }
}
