using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileApp
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFolderPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            string searchPattern = txtSearchPattern.Text;

            if(Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern);
                foreach(string file in files)
                {
                    listViewFiles.Items.Add(file);
                }
            }
            else
            {
                MessageBox.Show("Невірний шлях до папки", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
