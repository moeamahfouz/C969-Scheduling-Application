namespace C969_Scheduling_Application
{
    partial class UpdAppForm
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
            label5 = new Label();
            UpdAppID = new TextBox();
            UpdAppSearch = new Button();
            label3 = new Label();
            UpdAppCustID = new TextBox();
            label4 = new Label();
            UpdAppType = new TextBox();
            label2 = new Label();
            UpdAppStart = new DateTimePicker();
            label6 = new Label();
            UpdAppEnd = new DateTimePicker();
            UpdAppSave = new Button();
            UpdAppCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(616, 15);
            label1.TabIndex = 1;
            label1.Text = "Please enter the ID of the appointment you want to update. Once finished updating, hit Save to apply your changes.";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 47);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 25;
            label5.Text = "Appointment ID:";
            // 
            // UpdAppID
            // 
            UpdAppID.Location = new Point(267, 46);
            UpdAppID.Name = "UpdAppID";
            UpdAppID.Size = new Size(107, 23);
            UpdAppID.TabIndex = 26;
            // 
            // UpdAppSearch
            // 
            UpdAppSearch.Location = new Point(388, 43);
            UpdAppSearch.Name = "UpdAppSearch";
            UpdAppSearch.Size = new Size(75, 23);
            UpdAppSearch.TabIndex = 27;
            UpdAppSearch.Text = "Search";
            UpdAppSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 84);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 28;
            label3.Text = "Customer ID:";
            // 
            // UpdAppCustID
            // 
            UpdAppCustID.Location = new Point(130, 82);
            UpdAppCustID.Name = "UpdAppCustID";
            UpdAppCustID.Size = new Size(94, 23);
            UpdAppCustID.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 126);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 31;
            label4.Text = "Appointment Type:";
            // 
            // UpdAppType
            // 
            UpdAppType.Location = new Point(130, 124);
            UpdAppType.Name = "UpdAppType";
            UpdAppType.Size = new Size(182, 23);
            UpdAppType.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 84);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 33;
            label2.Text = "Start Time:";
            // 
            // UpdAppStart
            // 
            UpdAppStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            UpdAppStart.Format = DateTimePickerFormat.Custom;
            UpdAppStart.Location = new Point(435, 82);
            UpdAppStart.Name = "UpdAppStart";
            UpdAppStart.Size = new Size(200, 23);
            UpdAppStart.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 124);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 35;
            label6.Text = "End Time:";
            // 
            // UpdAppEnd
            // 
            UpdAppEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            UpdAppEnd.Format = DateTimePickerFormat.Custom;
            UpdAppEnd.Location = new Point(435, 122);
            UpdAppEnd.Name = "UpdAppEnd";
            UpdAppEnd.Size = new Size(200, 23);
            UpdAppEnd.TabIndex = 36;
            // 
            // UpdAppSave
            // 
            UpdAppSave.Location = new Point(235, 182);
            UpdAppSave.Name = "UpdAppSave";
            UpdAppSave.Size = new Size(88, 28);
            UpdAppSave.TabIndex = 37;
            UpdAppSave.Text = "Save";
            UpdAppSave.UseVisualStyleBackColor = true;
            // 
            // UpdAppCancel
            // 
            UpdAppCancel.Location = new Point(359, 182);
            UpdAppCancel.Name = "UpdAppCancel";
            UpdAppCancel.Size = new Size(88, 28);
            UpdAppCancel.TabIndex = 38;
            UpdAppCancel.Text = "Cancel";
            UpdAppCancel.UseVisualStyleBackColor = true;
            // 
            // UpdAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 228);
            Controls.Add(UpdAppCancel);
            Controls.Add(UpdAppSave);
            Controls.Add(UpdAppEnd);
            Controls.Add(label6);
            Controls.Add(UpdAppStart);
            Controls.Add(label2);
            Controls.Add(UpdAppType);
            Controls.Add(label4);
            Controls.Add(UpdAppCustID);
            Controls.Add(label3);
            Controls.Add(UpdAppSearch);
            Controls.Add(UpdAppID);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UpdAppForm";
            Text = "Update Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox UpdAppID;
        private Button UpdAppSearch;
        private Label label3;
        private TextBox UpdAppCustID;
        private Label label4;
        private TextBox UpdAppType;
        private Label label2;
        private DateTimePicker UpdAppStart;
        private Label label6;
        private DateTimePicker UpdAppEnd;
        private Button UpdAppSave;
        private Button UpdAppCancel;
    }
}