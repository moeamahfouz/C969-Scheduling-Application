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
            CustReportGrid = new DataGridView();
            label1 = new Label();
            CustReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)CustReportGrid).BeginInit();
            SuspendLayout();
            // 
            // CustReportGrid
            // 
            CustReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustReportGrid.Location = new Point(66, 96);
            CustReportGrid.Name = "CustReportGrid";
            CustReportGrid.RowHeadersWidth = 72;
            CustReportGrid.RowTemplate.Height = 37;
            CustReportGrid.Size = new Size(1015, 699);
            CustReportGrid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 44);
            label1.Name = "label1";
            label1.Size = new Size(520, 30);
            label1.TabIndex = 3;
            label1.Text = "Below is a report generated for the system's customers";
            // 
            // CustReportExit
            // 
            CustReportExit.Location = new Point(1003, 838);
            CustReportExit.Name = "CustReportExit";
            CustReportExit.Size = new Size(131, 40);
            CustReportExit.TabIndex = 7;
            CustReportExit.Text = "Exit";
            CustReportExit.UseVisualStyleBackColor = true;
            // 
            // CustReportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 890);
            Controls.Add(CustReportExit);
            Controls.Add(label1);
            Controls.Add(CustReportGrid);
            Name = "CustReportForm";
            Text = "Customer Reports";
            ((System.ComponentModel.ISupportInitialize)CustReportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustReportGrid;
        private Label label1;
        private Button CustReportExit;
    }
}