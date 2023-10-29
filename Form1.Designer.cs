namespace DbStudentApp_1204663
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCourses = new ComboBox();
            dg1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            SuspendLayout();
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(34, 37);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(182, 33);
            cmbCourses.TabIndex = 0;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(34, 128);
            dg1.Name = "dg1";
            dg1.RowHeadersWidth = 62;
            dg1.RowTemplate.Height = 33;
            dg1.Size = new Size(705, 225);
            dg1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dg1);
            Controls.Add(cmbCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCourses;
        private DataGridView dg1;
    }
}