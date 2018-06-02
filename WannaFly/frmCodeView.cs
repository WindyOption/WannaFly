using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WannaFly
{
    public partial class frmCodeView : Form
    {
        public frmCodeView()
        {
            InitializeComponent();
        }

        //frmCodeView的存取器
        public string setCode
        {
            set
            {
                rTBxCodeView.Text = value;
            }
        }



    
        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "文本文件(*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveDialog.FileName, false, System.Text.Encoding.UTF8);
                sw.Write(rTBxCodeView.Text);
                sw.Close();
            }
        }

        private void btnCloseCodeView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
