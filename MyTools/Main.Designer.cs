namespace MyTools
{
    partial class Main
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
            this.btnImportExcelToDB = new System.Windows.Forms.Button();
            this.btnConcatFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportExcelToDB
            // 
            this.btnImportExcelToDB.Location = new System.Drawing.Point(39, 21);
            this.btnImportExcelToDB.Name = "btnImportExcelToDB";
            this.btnImportExcelToDB.Size = new System.Drawing.Size(296, 23);
            this.btnImportExcelToDB.TabIndex = 0;
            this.btnImportExcelToDB.Text = "Import excel to db";
            this.btnImportExcelToDB.UseVisualStyleBackColor = true;
            this.btnImportExcelToDB.Click += new System.EventHandler(this.btnImportExcelToDB_Click);
            // 
            // btnConcatFile
            // 
            this.btnConcatFile.Location = new System.Drawing.Point(39, 61);
            this.btnConcatFile.Name = "btnConcatFile";
            this.btnConcatFile.Size = new System.Drawing.Size(296, 23);
            this.btnConcatFile.TabIndex = 1;
            this.btnConcatFile.Text = "Concat File";
            this.btnConcatFile.UseVisualStyleBackColor = true;
            this.btnConcatFile.Click += new System.EventHandler(this.btnConcatFile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 222);
            this.Controls.Add(this.btnConcatFile);
            this.Controls.Add(this.btnImportExcelToDB);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcelToDB;
        private System.Windows.Forms.Button btnConcatFile;
    }
}