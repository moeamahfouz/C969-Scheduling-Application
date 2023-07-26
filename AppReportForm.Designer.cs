namespace C969_Scheduling_Application
{
    partial class AppReportForm
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
            label1 = new Label();
            AppReport = new DataGridView();
            AppReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)AppReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 15);
            label1.TabIndex = 0;
            label1.Text = "Below is a report generated for the system's appointments";
            // 
            // AppReport
            // 
            AppReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppReport.Location = new Point(30, 48);
            AppReport.Margin = new Padding(2, 2, 2, 2);
            AppReport.Name = "AppReport";
            AppReport.RowHeadersWidth = 72;
            AppReport.RowTemplate.Height = 37;
            AppReport.Size = new Size(592, 350);
            AppReport.TabIndex = 1;
            AppReport.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppReportExit
            // 
            AppReportExit.Location = new Point(585, 419);
            AppReportExit.Margin = new Padding(2, 2, 2, 2);
            AppReportExit.Name = "AppReportExit";
            AppReportExit.Size = new Size(76, 20);
            AppReportExit.TabIndex = 8;
            AppReportExit.Text = "Exit";
            AppReportExit.UseVisualStyleBackColor = true;
            // 
            // AppReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 445);
            Controls.Add(AppReportExit);
            Controls.Add(AppReport);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AppReportForm";
            Text = "Appointments Report";
            ((System.ComponentModel.ISupportInitialize)AppReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView AppReport;
        private Button AppReportExit;
    }
}