using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class MVNhac : Form
    {
        public MVNhac()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile;
        string[] filePaths;
        string[] fileNames;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "AVI File|*.avi | MP4 File|*.mp4";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFile.FileName;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFile.Multiselect = true;
            openFile.Title = "Open";


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFile.FileNames;
                fileNames = openFile.SafeFileNames;
                foreach (var item in fileNames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int choose = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = filePaths[choose];
                this.textBox1.Text = fileNames[choose];
            }
        }

        private void MVNhac_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
