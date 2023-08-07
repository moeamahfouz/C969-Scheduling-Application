namespace C969_Scheduling_Application
{
    partial class ConsReportForm
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
            ConsReport = new DataGridView();
            ConsReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ConsReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 15);
            label1.TabIndex = 4;
            label1.Text = "Below is a report generated for the system's consultants";
            // 
            // ConsReport
            // 
            ConsReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConsReport.Location = new Point(38, 48);
            ConsReport.Margin = new Padding(2, 2, 2, 2);
            ConsReport.Name = "ConsReport";
            ConsReport.RowHeadersWidth = 72;
            ConsReport.RowTemplate.Height = 37;
            ConsReport.Size = new Size(592, 350);
            ConsReport.TabIndex = 5;
            // 
            // ConsReportExit
            // 
            ConsReportExit.Location = new Point(585, 419);
            ConsReportExit.Margin = new Padding(2, 2, 2, 2);
            ConsReportExit.Name = "ConsReportExit";
            ConsReportExit.Size = new Size(76, 20);
            ConsReportExit.TabIndex = 6;
            ConsReportExit.Text = "Exit";
            ConsReportExit.UseVisualStyleBackColor = true;
            this.ConsReportExit.Click += new System.EventHandler(this.ConsReportExit_Click);

            // 
            // ConsReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 445);
            Controls.Add(ConsReportExit);
            Controls.Add(ConsReport);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsReportForm";
            Text = "ConsReportForm";
            ((System.ComponentModel.ISupportInitialize)ConsReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ConsReport;
        private Button ConsReportExit;
    }
}