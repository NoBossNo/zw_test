using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 条码解析测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //C:\Users\Administrator\Desktop\FTP文件测试
            InitializeComponent();
            String file_str = null;

            string[] dirs=Directory.GetFiles(@"C:\\Users\\Administrator\\Desktop\\FTP文件测试", "*.jpg");
            foreach (string dir in dirs)
            {
                file_str += "*****" + dir;
            }

            MessageBox.Show(file_str);
        }
    }
}
