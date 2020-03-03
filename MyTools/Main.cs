using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnImportExcelToDB_Click(object sender, EventArgs e)
        {
            var excelImport = new ExcelToDB();
            excelImport.ShowDialog();
        }

        private void btnConcatFile_Click(object sender, EventArgs e)
        {
            var form = new ConcatFiles();
            form.ShowDialog();
        }
    }
}
