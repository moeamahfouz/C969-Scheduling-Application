namespace C969_Scheduling_Application
{
    partial class HomeForm
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
            DashboardAppGrid = new DataGridView();
            HomeRadioWeek = new RadioButton();
            HomeRadioMonth = new RadioButton();
            HomeAddApp = new Button();
            HomeUpdApp = new Button();
            HomeDelApp = new Button();
            label2 = new Label();
            HomeAddCust = new Button();
            HomeUpdCust = new Button();
            HomeDelCust = new Button();
            label3 = new Label();
            HomeAppReport = new Button();
            HomeCustReport = new Button();
            HomeConsReport = new Button();
            HomeExit = new Button();
            ((System.ComponentModel.ISupportInitialize)DashboardAppGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 47);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // DashboardAppGrid
            // 
            DashboardAppGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DashboardAppGrid.Location = new Point(22, 182);
            DashboardAppGrid.Margin = new Padding(3, 4, 3, 4);
            DashboardAppGrid.Name = "DashboardAppGrid";
            DashboardAppGrid.RowHeadersWidth = 72;
            DashboardAppGrid.RowTemplate.Height = 25;
            DashboardAppGrid.Size = new Size(1042, 758);
            DashboardAppGrid.TabIndex = 5;
            // 
            // HomeRadioWeek
            // 
            HomeRadioWeek.AutoSize = true;
            HomeRadioWeek.Location = new Point(22, 134);
            HomeRadioWeek.Margin = new Padding(5, 6, 5, 6);
            HomeRadioWeek.Name = "HomeRadioWeek";
            HomeRadioWeek.Size = new Size(160, 34);
            HomeRadioWeek.TabIndex = 15;
            HomeRadioWeek.TabStop = true;
            HomeRadioWeek.Text = "Sort By Week";
            HomeRadioWeek.UseVisualStyleBackColor = true;
            // 
            // HomeRadioMonth
            // 
            HomeRadioMonth.AutoSize = true;
            HomeRadioMonth.Location = new Point(249, 134);
            HomeRadioMonth.Margin = new Padding(5, 6, 5, 6);
            HomeRadioMonth.Name = "HomeRadioMonth";
            HomeRadioMonth.Size = new Size(171, 34);
            HomeRadioMonth.TabIndex = 16;
            HomeRadioMonth.TabStop = true;
            HomeRadioMonth.Text = "Sort By Month";
            HomeRadioMonth.UseVisualStyleBackColor = true;
            // 
            // HomeAddApp
            // 
            HomeAddApp.Location = new Point(22, 972);
            HomeAddApp.Margin = new Padding(5, 6, 5, 6);
            HomeAddApp.Name = "HomeAddApp";
            HomeAddApp.Size = new Size(206, 46);
            HomeAddApp.TabIndex = 17;
            HomeAddApp.Text = "New Appointment";
            HomeAddApp.UseVisualStyleBackColor = true;
            // 
            // HomeUpdApp
            // 
            HomeUpdApp.Location = new Point(279, 972);
            HomeUpdApp.Margin = new Padding(5, 6, 5, 6);
            HomeUpdApp.Name = "HomeUpdApp";
            HomeUpdApp.Size = new Size(233, 46);
            HomeUpdApp.TabIndex = 18;
            HomeUpdApp.Text = "Update Appointment";
            HomeUpdApp.UseVisualStyleBackColor = true;
            // 
            // HomeDelApp
            // 
            HomeDelApp.Location = new Point(566, 972);
            HomeDelApp.Margin = new Padding(5, 6, 5, 6);
            HomeDelApp.Name = "HomeDelApp";
            HomeDelApp.Size = new Size(233, 46);
            HomeDelApp.TabIndex = 19;
            HomeDelApp.Text = "Delete Appointment";
            HomeDelApp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1236, 72);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 20;
            label2.Text = "Settings";
            // 
            // HomeAddCust
            // 
            HomeAddCust.Location = new Point(1198, 182);
            HomeAddCust.Margin = new Padding(5, 6, 5, 6);
            HomeAddCust.Name = "HomeAddCust";
            HomeAddCust.Size = new Size(195, 46);
            HomeAddCust.TabIndex = 21;
            HomeAddCust.Text = "New Customer";
            HomeAddCust.UseVisualStyleBackColor = true;
            // 
            // HomeUpdCust
            // 
            HomeUpdCust.Location = new Point(1198, 266);
            HomeUpdCust.Margin = new Padding(5, 6, 5, 6);
            HomeUpdCust.Name = "HomeUpdCust";
            HomeUpdCust.Size = new Size(195, 46);
            HomeUpdCust.TabIndex = 22;
            HomeUpdCust.Text = "Update Customer";
            HomeUpdCust.UseVisualStyleBackColor = true;
            // 
            // HomeDelCust
            // 
            HomeDelCust.Location = new Point(1198, 348);
            HomeDelCust.Margin = new Padding(5, 6, 5, 6);
            HomeDelCust.Name = "HomeDelCust";
            HomeDelCust.Size = new Size(195, 46);
            HomeDelCust.TabIndex = 23;
            HomeDelCust.Text = "Delete Customer";
            HomeDelCust.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1236, 482);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 24;
            label3.Text = "Reports";
            // 
            // HomeAppReport
            // 
            HomeAppReport.Location = new Point(1198, 574);
            HomeAppReport.Margin = new Padding(5, 6, 5, 6);
            HomeAppReport.Name = "HomeAppReport";
            HomeAppReport.Size = new Size(195, 46);
            HomeAppReport.TabIndex = 25;
            HomeAppReport.Text = "Appointments";
            HomeAppReport.UseVisualStyleBackColor = true;
            // 
            // HomeCustReport
            // 
            HomeCustReport.Location = new Point(1198, 744);
            HomeCustReport.Margin = new Padding(5, 6, 5, 6);
            HomeCustReport.Name = "HomeCustReport";
            HomeCustReport.Size = new Size(195, 46);
            HomeCustReport.TabIndex = 26;
            HomeCustReport.Text = "Customers";
            HomeCustReport.UseVisualStyleBackColor = true;
            // 
            // HomeConsReport
            // 
            HomeConsReport.Location = new Point(1198, 661);
            HomeConsReport.Margin = new Padding(5, 6, 5, 6);
            HomeConsReport.Name = "HomeConsReport";
            HomeConsReport.Size = new Size(195, 46);
            HomeConsReport.TabIndex = 27;
            HomeConsReport.Text = "Consultants";
            HomeConsReport.UseVisualStyleBackColor = true;
            // 
            // HomeExit
            // 
            HomeExit.Location = new Point(1409, 972);
            HomeExit.Margin = new Padding(5, 6, 5, 6);
            HomeExit.Name = "HomeExit";
            HomeExit.Size = new Size(105, 66);
            HomeExit.TabIndex = 28;
            HomeExit.Text = "Exit";
            HomeExit.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 1062);
            Controls.Add(HomeExit);
            Controls.Add(HomeConsReport);
            Controls.Add(HomeCustReport);
            Controls.Add(HomeAppReport);
            Controls.Add(label3);
            Controls.Add(HomeDelCust);
            Controls.Add(HomeUpdCust);
            Controls.Add(HomeAddCust);
            Controls.Add(label2);
            Controls.Add(HomeDelApp);
            Controls.Add(HomeUpdApp);
            Controls.Add(HomeAddApp);
            Controls.Add(HomeRadioMonth);
            Controls.Add(HomeRadioWeek);
            Controls.Add(DashboardAppGrid);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeForm";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)DashboardAppGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DashboardAppGrid;
        private RadioButton HomeRadioWeek;
        private RadioButton HomeRadioMonth;
        private Button HomeAddApp;
        private Button HomeUpdApp;
        private Button HomeDelApp;
        private Label label2;
        private Button HomeAddCust;
        private Button HomeUpdCust;
        private Button HomeDelCust;
        private Label label3;
        private Button HomeAppReport;
        private Button HomeCustReport;
        private Button HomeConsReport;
        private Button HomeExit;
    }
}