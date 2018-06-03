using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;


namespace WannaFly
{
    public partial class favoritesForm : Form
    {
        public favoritesForm()
        {
            InitializeComponent();
        }

        //获取收藏夹路径
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

        private void favoritesForm_Load(object sender, EventArgs e)
        {
            scan(path);
        }

        //获取收藏夹所有的文件
        private void scan(string Dpath)
        {
            DirectoryInfo DInfo = new DirectoryInfo(Dpath);
            FileSystemInfo[] FSInfo = DInfo.GetFiles();
            for (int i = 0; i < FSInfo.Length; i++)
            {
                favorDisPlay.Items.Add(FSInfo[i].ToString());
            }
        }


        //收藏夹删除操作
        private void delFavor_Click(object sender, EventArgs e)
        {
            if (favorDisPlay.SelectedItems.Count == 0)             //判断是否选择项目
            { }
            else
            {
                //获取选择项的路径
                string Path = path + "\\" + favorDisPlay.SelectedItem.ToString();
                //获取选择项目的扩展名
                string Stype = Path.Substring(Path.LastIndexOf(".") + 1);
                if (Stype == "url")                             //如果扩展名为“url”
                {
                    FileInfo info = new FileInfo(Path);         //根据选择项的路径实例化FileInfo
                    info.Delete();                              //然后调用FileInfo类的Delete方法进行删除  
                    favorDisPlay.Items.Clear();                 //清空ListBox控件的项目
                    scan(path);                                 //重新遍历收藏夹
                }
                else
                { }
            }
        }

    }
}
