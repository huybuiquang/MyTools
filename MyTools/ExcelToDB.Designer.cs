namespace MyTools
{
    partial class ExcelToDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRemoveFirstRow = new System.Windows.Forms.CheckBox();
            this.cbUseFirstRowName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(67, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(439, 22);
            this.txtFile.TabIndex = 0;
            this.txtFile.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(505, 20);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(38, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(549, 20);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(132, 23);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Process";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(67, 88);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(614, 259);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results";
            // 
            // cbRemoveFirstRow
            // 
            this.cbRemoveFirstRow.AutoSize = true;
            this.cbRemoveFirstRow.Checked = true;
            this.cbRemoveFirstRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveFirstRow.Location = new System.Drawing.Point(67, 59);
            this.cbRemoveFirstRow.Name = "cbRemoveFirstRow";
            this.cbRemoveFirstRow.Size = new System.Drawing.Size(113, 17);
            this.cbRemoveFirstRow.TabIndex = 7;
            this.cbRemoveFirstRow.Text = "Remove First Row";
            this.cbRemoveFirstRow.UseVisualStyleBackColor = true;
            // 
            // cbUseFirstRowName
            // 
            this.cbUseFirstRowName.AutoSize = true;
            this.cbUseFirstRowName.Checked = true;
            this.cbUseFirstRowName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseFirstRowName.Location = new System.Drawing.Point(202, 59);
            this.cbUseFirstRowName.Name = "cbUseFirstRowName";
            this.cbUseFirstRowName.Size = new System.Drawing.Size(175, 17);
            this.cbUseFirstRowName.TabIndex = 8;
            this.cbUseFirstRowName.Text = "Use First Row as Column Name";
            this.cbUseFirstRowName.UseVisualStyleBackColor = true;
            // 
            // ExcelToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 366);
            this.Controls.Add(this.cbUseFirstRowName);
            this.Controls.Add(this.cbRemoveFirstRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Name = "ExcelToDB";
            this.Text = "Excel to DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRemoveFirstRow;
        private System.Windows.Forms.CheckBox cbUseFirstRowName;
    }
}

