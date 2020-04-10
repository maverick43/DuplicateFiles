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
        List<string> lstMD5 = new List<string>();   //每组重复文件的MD5
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
                //FileStream file2 = new FileStream(filename + "aaaa", FileMode.Create, FileAccess.Write);
                byte[] buff = new byte[1024 * 1024];
                file.Read(buff, 0, 1024 * 1024);
                file.Close();
                //file2.Write(buff, 0, buff.Length);
                //file2.Close();
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
            if (txtPath.Text == "" || Directory.Exists(txtPath.Text) == false)
            {
                if (SelectDirectory() == false)
                {
                    return;
                }
            }
            strPath = txtPath.Text;
            lblTime.Text = "正在检测";
            lblTime.Refresh();
            lstResult.Clear();
            lstMD5.Clear();
            lbGroup.Items.Clear();
            lbFiles.Items.Clear();
            lblFileCount.Text = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string strMd5 = "";
            foreach (string strFile in Directory.GetFiles(strPath))
            {
                bool bAdded = false;
                strMd5 = GetMD5HashFromFile(strFile);
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
            int nCount = 0;
            foreach (List<string> l in lstResult)
            {
                if (l.Count > 2)
                {
                    nCount++;
                    lbGroup.Items.Add(nCount.ToString());
                    lstMD5.Add(l[0]);
                }
            }
            //MessageBox.Show(GetMD5HashFromFile(@"D:\文档.rar"));
            lblGroupCount.Text = String.Format("共 {0} 组重复文件", lbGroup.Items.Count);
            sw.Stop();
            lblTime.Text = string.Format("用时: {0:0} 秒", sw.Elapsed.TotalSeconds);
        }

        private void lbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroup.SelectedIndex != -1)
            {
                lbFiles.Items.Clear();
                //TODO:显示的文件名错误
                //foreach (List<string> l in lstResult)
                //{
                //    if (l[0] == lbGroup.SelectedItem.ToString())
                //    {
                //        for (int i = 1; i < l.Count; i++)
                //        {
                //            lbFiles.Items.Add(Path.GetFileName(l[i]));
                //        }
                //    }
                //}
                foreach (List<string> l in lstResult)
                {
                    if (l[0] == lstMD5[lbGroup.SelectedIndex])
                    {
                        for (int j = 1; j < l.Count; j++)
                        {
                            lbFiles.Items.Add(Path.GetFileName(l[j]));
                        }
                    }
                }
                //for (int i = 1; i < lstResult[lbGroup.SelectedIndex].Count; i++)
                //{
                //    lbFiles.Items.Add(Path.GetFileName(lstResult[lbGroup.SelectedIndex][i]));
                //}
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
                if (!File.Exists(Path.Combine(strPath, lbFiles.SelectedItem.ToString())))
                {
                    MessageBox.Show("文件不存在");
                    return;
                }
                long FileSize = fi.Length;
                string strFileSize = "";
                if (FileSize > 1024 * 1024 * 1024)
                {
                    strFileSize = string.Format("{0} GB", ((double)FileSize / 1024 / 1024 / 1024).ToString("0.0"));
                }
                else if (FileSize > 1024 * 1024)
                {
                    strFileSize = string.Format("{0} MB", ((double)FileSize / 1024 / 1024).ToString("0.0"));
                }
                else if (FileSize > 1024)
                {
                    strFileSize = string.Format("{0} KB", ((double)FileSize / 1024).ToString("0.0"));
                }
                lblSizeValue.Text = strFileSize;
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
                    int nSelectedIndex = lbGroup.SelectedIndex;
                    int i;
                    for (i = 0; nSelectedIndex >= 0; i++)
                    {
                        if (lstResult[i].Count > 2)
                        {
                            nSelectedIndex--;
                        }
                    }
                    lstResult[i - 1].RemoveAt(lbFiles.SelectedIndex + 1);
                    lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
                    lblFileCount.Text = string.Format("共 {0} 个重复文件", lbFiles.Items.Count);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteFile();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSizeValue.Text = "";
            lblCreationTimeValue.Text = "";
            lblLastWriteTimeValue.Text = "";
            lblTime.Text = "";
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        private bool SelectDirectory()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            if (strPath != "")
            {
                fbd.SelectedPath = strPath;
            }
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            txtPath.Text = fbd.SelectedPath;
            return true;
        }
    }
}