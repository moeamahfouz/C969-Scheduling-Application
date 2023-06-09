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
            AppReportGrid = new DataGridView();
            AppReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)AppReportGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 37);
            label1.Name = "label1";
            label1.Size = new Size(553, 30);
            label1.TabIndex = 0;
            label1.Text = "Below is a report generated for the system's appointments";
            // 
            // AppReportGrid
            // 
            AppReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppReportGrid.Location = new Point(52, 97);
            AppReportGrid.Name = "AppReportGrid";
            AppReportGrid.RowHeadersWidth = 72;
            AppReportGrid.RowTemplate.Height = 37;
            AppReportGrid.Size = new Size(1015, 699);
            AppReportGrid.TabIndex = 1;
            AppReportGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppReportExit
            // 
            AppReportExit.Location = new Point(1003, 838);
            AppReportExit.Name = "AppReportExit";
            AppReportExit.Size = new Size(131, 40);
            AppReportExit.TabIndex = 8;
            AppReportExit.Text = "Exit";
            AppReportExit.UseVisualStyleBackColor = true;
            // 
            // AppReportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 890);
            Controls.Add(AppReportExit);
            Controls.Add(AppReportGrid);
            Controls.Add(label1);
            Name = "AppReportForm";
            Text = "Appointments Report";
            ((System.ComponentModel.ISupportInitialize)AppReportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView AppReportGrid;
        private Button AppReportExit;
    }
}