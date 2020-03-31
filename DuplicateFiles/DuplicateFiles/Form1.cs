using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFiles
{
    public partial class Form1 : Form
    {
        List<List<string>> lstResult = new List<List<string>>();
        string strPath;

        public Form1()
        {
            InitializeComponent();
        }

        public static string GetMD5HashFromFile(string filename)
        {
            try
            {
                FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                byte[] buff = new byte[1024 * 1024];
                file.Read(buff, 0, 1024 * 1024);
                file.Close();
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(buff);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString().ToUpper();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("错误信息：" + ex);
                return null;
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            if (strPath != "")
            {
                fbd.SelectedPath = strPath;
            }
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            lblTime.Text = "正在检测";
            lblTime.Refresh();
            strPath = fbd.SelectedPath;
            lstResult.Clear();
            lbGroup.Items.Clear();
            lbFiles.Items.Clear();
            lblFileCount.Text = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (string strFile in Directory.GetFiles(fbd.SelectedPath))
            {
                bool bAdded = false;
                string strMd5 = GetMD5HashFromFile(strFile);
                foreach (List<string> l in lstResult)
                {
                    if (strMd5 == l[0])
                    {
                        l.Add(strFile);
                        bAdded = true;
                    }
                }
                if (!bAdded)
                {
                    List<string> lstnew = new List<string>();
                    lstnew.Add(strMd5);
                    lstnew.Add(strFile);
                    lstResult.Add(lstnew);
                }
            }
            foreach (List<string> l in lstResult)
            {
                if (l.Count > 2)
                {
                    lbGroup.Items.Add(l[0]);
                }
            }
            //MessageBox.Show(GetMD5HashFromFile(@"D:\文档.rar"));
            lblGroupCount.Text = String.Format("共 {0} 组重复文件", lbGroup.Items.Count.ToString());
            sw.Stop();
            lblTime.Text = string.Format("用时: {0:0} 秒", sw.Elapsed.TotalSeconds);
        }

        private void lbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroup.SelectedIndex != -1)
            {
                lbFiles.Items.Clear();
                foreach (List<string> l in lstResult)
                {
                    if (l[0] == lbGroup.SelectedItem.ToString())
                    {
                        for (int i = 1; i < l.Count; i++)
                        {
                            lbFiles.Items.Add(Path.GetFileName(l[i]));
                        }
                    }
                }
            }
            lblFileCount.Text = string.Format("共 {0} 个重复文件", lbFiles.Items.Count.ToString());
        }

        private void lbFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex != -1)
            {
                Process p = new Process();
                p.StartInfo.FileName = Path.Combine(strPath, lbFiles.SelectedItem.ToString());
                p.Start();
            }
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex != -1)
            {
                FileInfo fi = new FileInfo(Path.Combine(strPath, lbFiles.SelectedItem.ToString()));
                if(!File.Exists(Path.Combine(strPath, lbFiles.SelectedItem.ToString())))
                {
                    MessageBox.Show("文件不存在");
                    return;
                }
                lblSizeValue.Text = fi.Length.ToString();
                lblCreationTimeValue.Text = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
                lblLastWriteTimeValue.Text = fi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex != -1)
            {
                Process p = new Process();
                p.StartInfo.FileName = "explorer.exe";
                p.StartInfo.Arguments = "/select, " + Path.Combine(strPath, lbFiles.SelectedItem.ToString());
                p.Start();
            }
        }

        private void DeleteFile()
        {
            if (lbFiles.SelectedIndex != -1)
            {
                if (lbFiles.Items.Count == 1)
                {
                    MessageBox.Show("当前组重复文件只剩一个，需要手动删除", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("确认删除文件" + Environment.NewLine + Environment.NewLine +
                    Path.Combine(strPath, lbFiles.SelectedItem.ToString()), this.Text,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    File.Delete(Path.Combine(strPath, lbFiles.SelectedItem.ToString()));
                    for (int i = 0; i < lstResult.Count; i++)
                    {
                        if (lstResult[i][0].ToString() == lbGroup.SelectedItem.ToString())
                        {
                            lstResult[i].RemoveAt(lbFiles.SelectedIndex + 1);
                        }
                    }
                    lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DeleteFile();
            }
        }
    }
}