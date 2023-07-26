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
            HomeCalendar = new DataGridView();
            HomeRadioWeek = new RadioButton();
            HomeRadioMonth = new RadioButton();
            HomeNewApp = new Button();
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
            ((System.ComponentModel.ISupportInitialize)HomeCalendar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // HomeCalendar
            // 
            HomeCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HomeCalendar.Location = new Point(13, 91);
            HomeCalendar.Margin = new Padding(2, 2, 2, 2);
            HomeCalendar.Name = "HomeCalendar";
            HomeCalendar.RowHeadersWidth = 72;
            HomeCalendar.RowTemplate.Height = 25;
            HomeCalendar.Size = new Size(608, 379);
            HomeCalendar.TabIndex = 5;
            // 
            // HomeRadioWeek
            // 
            HomeRadioWeek.AutoSize = true;
            HomeRadioWeek.Location = new Point(13, 67);
            HomeRadioWeek.Name = "HomeRadioWeek";
            HomeRadioWeek.Size = new Size(94, 19);
            HomeRadioWeek.TabIndex = 15;
            HomeRadioWeek.TabStop = true;
            HomeRadioWeek.Text = "Sort By Week";
            HomeRadioWeek.UseVisualStyleBackColor = true;
            // 
            // HomeRadioMonth
            // 
            HomeRadioMonth.AutoSize = true;
            HomeRadioMonth.Location = new Point(145, 67);
            HomeRadioMonth.Name = "HomeRadioMonth";
            HomeRadioMonth.Size = new Size(101, 19);
            HomeRadioMonth.TabIndex = 16;
            HomeRadioMonth.TabStop = true;
            HomeRadioMonth.Text = "Sort By Month";
            HomeRadioMonth.UseVisualStyleBackColor = true;
            // 
            // HomeNewApp
            // 
            HomeNewApp.Location = new Point(13, 486);
            HomeNewApp.Name = "HomeNewApp";
            HomeNewApp.Size = new Size(120, 23);
            HomeNewApp.TabIndex = 17;
            HomeNewApp.Text = "New Appointment";
            HomeNewApp.UseVisualStyleBackColor = true;
            // 
            // HomeUpdApp
            // 
            HomeUpdApp.Location = new Point(163, 486);
            HomeUpdApp.Name = "HomeUpdApp";
            HomeUpdApp.Size = new Size(136, 23);
            HomeUpdApp.TabIndex = 18;
            HomeUpdApp.Text = "Update Appointment";
            HomeUpdApp.UseVisualStyleBackColor = true;
            // 
            // HomeDelApp
            // 
            HomeDelApp.Location = new Point(330, 486);
            HomeDelApp.Name = "HomeDelApp";
            HomeDelApp.Size = new Size(136, 23);
            HomeDelApp.TabIndex = 19;
            HomeDelApp.Text = "Delete Appointment";
            HomeDelApp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(721, 36);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 20;
            label2.Text = "Settings";
            // 
            // HomeAddCust
            // 
            HomeAddCust.Location = new Point(699, 91);
            HomeAddCust.Name = "HomeAddCust";
            HomeAddCust.Size = new Size(114, 23);
            HomeAddCust.TabIndex = 21;
            HomeAddCust.Text = "New Customer";
            HomeAddCust.UseVisualStyleBackColor = true;
            // 
            // HomeUpdCust
            // 
            HomeUpdCust.Location = new Point(699, 133);
            HomeUpdCust.Name = "HomeUpdCust";
            HomeUpdCust.Size = new Size(114, 23);
            HomeUpdCust.TabIndex = 22;
            HomeUpdCust.Text = "Update Customer";
            HomeUpdCust.UseVisualStyleBackColor = true;
            // 
            // HomeDelCust
            // 
            HomeDelCust.Location = new Point(699, 174);
            HomeDelCust.Name = "HomeDelCust";
            HomeDelCust.Size = new Size(114, 23);
            HomeDelCust.TabIndex = 23;
            HomeDelCust.Text = "Delete Customer";
            HomeDelCust.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(721, 241);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 24;
            label3.Text = "Reports";
            // 
            // HomeAppReport
            // 
            HomeAppReport.Location = new Point(699, 287);
            HomeAppReport.Name = "HomeAppReport";
            HomeAppReport.Size = new Size(114, 23);
            HomeAppReport.TabIndex = 25;
            HomeAppReport.Text = "Appointments";
            HomeAppReport.UseVisualStyleBackColor = true;
            // 
            // HomeCustReport
            // 
            HomeCustReport.Location = new Point(699, 372);
            HomeCustReport.Name = "HomeCustReport";
            HomeCustReport.Size = new Size(114, 23);
            HomeCustReport.TabIndex = 26;
            HomeCustReport.Text = "Customers";
            HomeCustReport.UseVisualStyleBackColor = true;
            // 
            // HomeConsReport
            // 
            HomeConsReport.Location = new Point(699, 331);
            HomeConsReport.Name = "HomeConsReport";
            HomeConsReport.Size = new Size(114, 23);
            HomeConsReport.TabIndex = 27;
            HomeConsReport.Text = "Consultants";
            HomeConsReport.UseVisualStyleBackColor = true;
            // 
            // HomeExit
            // 
            HomeExit.Location = new Point(822, 486);
            HomeExit.Name = "HomeExit";
            HomeExit.Size = new Size(61, 33);
            HomeExit.TabIndex = 28;
            HomeExit.Text = "Exit";
            HomeExit.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 531);
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
            Controls.Add(HomeNewApp);
            Controls.Add(HomeRadioMonth);
            Controls.Add(HomeRadioWeek);
            Controls.Add(HomeCalendar);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomeForm";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)HomeCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView HomeCalendar;
        private RadioButton HomeRadioWeek;
        private RadioButton HomeRadioMonth;
        private Button HomeNewApp;
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