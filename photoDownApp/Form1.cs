using photoDownLibrary.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoDownApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                tbxFilePath.Text = foldPath;
            }
        }

        private void btnStartDown_Click(object sender, EventArgs e)
        {
            if(tbxInNumber.Text == "")
            {
                MessageBox.Show("下载的In号码不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tbxFilePath.Text == "")
            {
                MessageBox.Show("文件保存文件夹不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Thread thread = new Thread(() =>
            {
                string inNumber = tbxInNumber.Text;
                string path = tbxFilePath.Text;
                List<string> getUrl = new List<string>();
                string uid = baseTool.getUidByInNumber(inNumber);
                if (string.IsNullOrEmpty(uid))
                {
                    MessageBox.Show("用户不存在！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<string> albumIdList = baseTool.getAlbumList(uid).ToList();
                if (albumIdList != null && albumIdList.Count > 0)
                {
                    albumIdList.ForEach(a =>
                    {
                        getUrl.AddRange(baseTool.getPersonPhotoList(a));
                    });
                }
                baseTool.ChangeLabel += ChangeLabel;
                baseTool.getPhotoByUrl(path, getUrl);               
                this.BeginInvoke(new Action(() => { btnOpenFold.Visible = true; }));
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public void ChangeLabel(string text)
        {
            //非创建控件的线程不可修改控件
            this.BeginInvoke(new Action(() => { label4.Text = text; }));
            //label4.Text = text;
        }

        private void btnOpenFold_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(tbxFilePath.Text);
        }
    }
}
