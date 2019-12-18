using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTools
{
    public partial class ExcelToDB : Form
    {
        public ExcelToDB()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }

        private void LoadDataFromFile()
        {
            var filePath = txtFile.Text;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)

                //var conf = new ExcelDataSetConfiguration
                //{
                //    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                //    {
                //        UseHeaderRow = true
                //    }
                //};

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    //// 1. Use the reader methods
                    //do
                    //{
                    //    while (reader.Read())
                    //    {
                    //        // reader.GetDouble(0);
                    //    }
                    //} while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    txtResult.Text = SaveDB(result);
                    // The result of each spreadsheet is in result.Tables
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }

        private string SaveDB(DataSet ds)
        {
            string consString = ConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            var sb = new StringBuilder();
            using (SqlConnection con = new SqlConnection(consString))
            {
                con.Open();
                for (var i = 0; i < ds.Tables.Count; i++)
                {
                    var dt = ds.Tables[i];
                    RemoveFirstRow(dt);
                    if (dt.Rows.Count > 0)
                    {
                        var tableName = $"dbo.[_{DateTime.Now.Ticks}_{dt.TableName.Replace(" ", "")}]";
                        var sql = CreateScriptTable(tableName, dt);
                        using (var sqlCommand = new SqlCommand(sql, con))
                        {
                            sqlCommand.ExecuteNonQuery();
                        }

                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = tableName;

                            //[OPTIONAL]: Map the DataTable columns with that of the database table
                            //sqlBulkCopy.ColumnMappings.Add("CountryName", "CountryName");
                            //sqlBulkCopy.ColumnMappings.Add("CityName", "CityName");
                            //sqlBulkCopy.ColumnMappings.Add("City Code", "CityCode");

                            sqlBulkCopy.WriteToServer(dt);
                        }
                        sb.AppendLine($"Created table {tableName}");
                    }
                }
                con.Close();
            }
            return sb.ToString();
        }

        private string CreateScriptTable(string tableName, DataTable dt)
        {
            var sql = new StringBuilder();
            sql.AppendLine($"Create TABLE {tableName}(");
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                var colName = (dt.Columns[i].ColumnName ?? "").Replace(" ", "");
                colName = colName == "" ? $"Col{i}" : colName;
                sql.AppendLine($"[{colName}] [nvarchar](MAX) NULL,");
            }
            sql.AppendLine(")");

            return sql.ToString();
        }

        private void RemoveFirstRow(DataTable dt)
        {
            if (cbRemoveFirstRow.Checked && dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }
        }
    }
}
