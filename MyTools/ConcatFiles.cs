using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyTools
{
    public partial class ConcatFiles : Form
    {
        private List<string> AllFiles;
        public ConcatFiles()
        {
            AllFiles = new List<string>();
            InitializeComponent();
            listViewFiles.CheckBoxes = true;

            var defaultFolder = ConfigurationManager.AppSettings["defaultFolder"];
            openFileDialog.InitialDirectory = defaultFolder;
            folderBrowserDialog.SelectedPath = defaultFolder;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                var dirs = new[] { folderBrowserDialog.SelectedPath };
                foreach (var dir in dirs)
                {
                    var files = Directory.GetFiles(dir);

                    foreach (var file in files)
                    {
                        if (AllFiles.Any(i => i == file)) continue;
                        listViewFiles.Items.Add(Path.GetFileName(file), file);
                        AllFiles.Add(file);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listViewFiles.Items.Clear();
            AllFiles.Clear();
        }

        private void btnGenfile_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewFiles.Items)
                {
                    if (item.Checked)
                    {
                        var text = File.ReadAllText(item.ImageKey);
                        sb.AppendLine(text);
                    }
                }
            }
            File.WriteAllText(saveFileDialog.FileName, sb.ToString());
        }

        private void listViewFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                //do something
                ListViewItem item = clickedItem as ListViewItem;
                var text = File.ReadAllText(item.ImageKey);
                (new ViewText(text)).Show();
            }
        }
    }
}
