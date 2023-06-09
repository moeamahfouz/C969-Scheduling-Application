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
            ConsReportGrid = new DataGridView();
            ConsReportExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ConsReportGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 48);
            label1.Name = "label1";
            label1.Size = new Size(531, 30);
            label1.TabIndex = 4;
            label1.Text = "Below is a report generated for the system's consultants";
            // 
            // ConsReportGrid
            // 
            ConsReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConsReportGrid.Location = new Point(66, 96);
            ConsReportGrid.Name = "ConsReportGrid";
            ConsReportGrid.RowHeadersWidth = 72;
            ConsReportGrid.RowTemplate.Height = 37;
            ConsReportGrid.Size = new Size(1015, 699);
            ConsReportGrid.TabIndex = 5;
            // 
            // ConsReportExit
            // 
            ConsReportExit.Location = new Point(1003, 838);
            ConsReportExit.Name = "ConsReportExit";
            ConsReportExit.Size = new Size(131, 40);
            ConsReportExit.TabIndex = 6;
            ConsReportExit.Text = "Exit";
            ConsReportExit.UseVisualStyleBackColor = true;
            // 
            // ConsReportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 890);
            Controls.Add(ConsReportExit);
            Controls.Add(ConsReportGrid);
            Controls.Add(label1);
            Name = "ConsReportForm";
            Text = "ConsReportForm";
            ((System.ComponentModel.ISupportInitialize)ConsReportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ConsReportGrid;
        private Button ConsReportExit;
    }
}