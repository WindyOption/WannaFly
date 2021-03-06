﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;

namespace WannaFly
{
    public partial class viewHistory : Form
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.History);

        public viewHistory()
        {
            InitializeComponent();
        }


        //浏览记录，先读IE的然后读当前的
        private void viewHistory_Load(object sender, EventArgs e)
        {
            IUrlHistoryStg2 vUrlHistoryStg2 = (IUrlHistoryStg2)new UrlHistory();
            IEnumSTATURL vEnumSTATURL = vUrlHistoryStg2.EnumUrls();
            STATURL vSTATURL;
            uint vFectched;

            while (vEnumSTATURL.Next(1, out vSTATURL, out vFectched) == 0)
            {
                listBox1.Items.Add(string.Format("{0}\r\n{1}\r\n", vSTATURL.pwcsTitle, vSTATURL.pwcsUrl));
            }

            
         

        }


        

        public void readtext2list()
        {
            //获取项目根目录UrlTxt.txt的路径
            //string path = Application.StartupPath.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path += @"\UrlTxt.txt";
            try
            {
                StreamReader sr = new StreamReader(path); //读取记事本中的内容
                while (sr.ReadLine() != null) //将内容添加listbox
                {
                    listBox1.Items.Add(sr.ReadLine().ToString());
                }
                sr.Close();
            }
            catch
            { }
        }



        #region COM接口实现获取IE历史记录  
        //自定义结构 IUrlHistory  
        public struct STATURL
        {
            public static uint SIZEOF_STATURL =
                (uint)Marshal.SizeOf(typeof(STATURL));
            public uint cbSize;                    //网页大小  
            [MarshalAs(UnmanagedType.LPWStr)]      //网页Url  
            public string pwcsUrl;
            [MarshalAs(UnmanagedType.LPWStr)]      //网页标题  
            public string pwcsTitle;
            public System.Runtime.InteropServices.ComTypes.FILETIME
                ftLastVisited,                     //网页最近访问时间  
                ftLastUpdated,                     //网页最近更新时间  
                ftExpires;
            public uint dwFlags;
        }

        //ComImport属性通过guid调用com组件  
        [ComImport, Guid("3C374A42-BAE4-11CF-BF7D-00AA006946EE"),
            InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IEnumSTATURL
        {
            [PreserveSig]
            //搜索IE历史记录匹配的搜索模式并复制到指定缓冲区  
            uint Next(uint celt, out STATURL rgelt, out uint pceltFetched);
            void Skip(uint celt);
            void Reset();
            void Clone(out IEnumSTATURL ppenum);
            void SetFilter(
                [MarshalAs(UnmanagedType.LPWStr)] string poszFilter,
                uint dwFlags);
        }

        [ComImport, Guid("AFA0DC11-C313-11d0-831A-00C04FD5AE38"),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IUrlHistoryStg2
        {
            #region IUrlHistoryStg methods  
            void AddUrl(
                [MarshalAs(UnmanagedType.LPWStr)] string pocsUrl,
                [MarshalAs(UnmanagedType.LPWStr)] string pocsTitle,
                uint dwFlags);

            void DeleteUrl(
                [MarshalAs(UnmanagedType.LPWStr)] string pocsUrl,
                uint dwFlags);

            void QueryUrl(
                [MarshalAs(UnmanagedType.LPWStr)] string pocsUrl,
                uint dwFlags,
                ref STATURL lpSTATURL);

            void BindToObject(
                [MarshalAs(UnmanagedType.LPWStr)] string pocsUrl,
                ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object ppvOut);

            IEnumSTATURL EnumUrls();
            #endregion

            void AddUrlAndNotify(
          [MarshalAs(UnmanagedType.LPWStr)] string pocsUrl,
          [MarshalAs(UnmanagedType.LPWStr)] string pocsTitle,
          uint dwFlags,
          [MarshalAs(UnmanagedType.Bool)] bool fWriteHistory,
          [MarshalAs(UnmanagedType.IUnknown)] object    /*IOleCommandTarget*/
          poctNotify,
          [MarshalAs(UnmanagedType.IUnknown)] object punkISFolder);

            void ClearHistory();       //清除历史记录  
        }

        [ComImport, Guid("3C374A40-BAE4-11CF-BF7D-00AA006946EE")]
        class UrlHistory /* : IUrlHistoryStg[2] */ { }
        #endregion

        private void viewlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

        private void viewHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
