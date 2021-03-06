/**********************************************************
** 文件名： AddTextForm.cs
** 文件作用:添加文本窗体
** 
**---------------------------------------------------------
**修改历史记录：
**修改时间      修改人    修改内容概要
**2018-09-14    xwj       增加
**
**********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawTools
{
    public partial class AddTextForm : Form
    {
        string text;
        public AddTextForm(string text)
        {
            InitializeComponent();

            this.text = text;
            this.textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text.Trim();
        }

        public string Textvalues
        {
            get { return text; }
            set { text = value; }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
                e.Cancel = true; 
        }
    }
}