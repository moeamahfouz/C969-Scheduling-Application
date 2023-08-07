namespace C969_Scheduling_Application
{
    partial class CustReportForm
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
            CustReport = new DataGridView();
            label1 = new Label();
            CustReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)CustReport).BeginInit();
            SuspendLayout();
            // 
            // CustReport
            // 
            CustReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustReport.Location = new Point(38, 48);
            CustReport.Margin = new Padding(2, 2, 2, 2);
            CustReport.Name = "CustReport";
            CustReport.RowHeadersWidth = 72;
            CustReport.RowTemplate.Height = 37;
            CustReport.Size = new Size(592, 350);
            CustReport.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 15);
            label1.TabIndex = 3;
            label1.Text = "Below is a report generated for the system's customers";
            // 
            // CustReportExit
            // 
            CustReportExit.Location = new Point(585, 419);
            CustReportExit.Margin = new Padding(2, 2, 2, 2);
            CustReportExit.Name = "CustReportExit";
            CustReportExit.Size = new Size(76, 20);
            CustReportExit.TabIndex = 7;
            CustReportExit.Text = "Exit";
            CustReportExit.UseVisualStyleBackColor = true;
            this.CustReportExit.Click += new System.EventHandler(this.CustReportExit_Click);

            // 
            // CustReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 445);
            Controls.Add(CustReportExit);
            Controls.Add(label1);
            Controls.Add(CustReport);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CustReportForm";
            Text = "Customer Reports";
            ((System.ComponentModel.ISupportInitialize)CustReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustReport;
        private Label label1;
        private Button CustReportExit;
    }
}