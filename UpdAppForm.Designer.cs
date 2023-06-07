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
            ModAppID = new TextBox();
            ModAppSearch = new Button();
            label3 = new Label();
            ModAppCustID = new TextBox();
            label4 = new Label();
            ModAppType = new TextBox();
            label2 = new Label();
            ModAppStart = new DateTimePicker();
            label6 = new Label();
            ModAppEnd = new DateTimePicker();
            AddAppSave = new Button();
            AddAppCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(1090, 30);
            label1.TabIndex = 1;
            label1.Text = "Please enter the ID of the appointment you want to update. Once finished updating, hit Save to apply your changes.";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 94);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 30);
            label5.TabIndex = 25;
            label5.Text = "Appointment ID:";
            // 
            // ModAppID
            // 
            ModAppID.Location = new Point(458, 91);
            ModAppID.Margin = new Padding(5, 6, 5, 6);
            ModAppID.Name = "ModAppID";
            ModAppID.Size = new Size(180, 35);
            ModAppID.TabIndex = 26;
            // 
            // ModAppSearch
            // 
            ModAppSearch.Location = new Point(665, 86);
            ModAppSearch.Margin = new Padding(5, 6, 5, 6);
            ModAppSearch.Name = "ModAppSearch";
            ModAppSearch.Size = new Size(129, 46);
            ModAppSearch.TabIndex = 27;
            ModAppSearch.Text = "Search";
            ModAppSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 168);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 28;
            label3.Text = "Customer ID:";
            // 
            // ModAppCustID
            // 
            ModAppCustID.Location = new Point(223, 165);
            ModAppCustID.Margin = new Padding(5, 6, 5, 6);
            ModAppCustID.Name = "ModAppCustID";
            ModAppCustID.Size = new Size(158, 35);
            ModAppCustID.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 251);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 30);
            label4.TabIndex = 31;
            label4.Text = "Appointment Type:";
            // 
            // ModAppType
            // 
            ModAppType.Location = new Point(223, 248);
            ModAppType.Margin = new Padding(5, 6, 5, 6);
            ModAppType.Name = "ModAppType";
            ModAppType.Size = new Size(309, 35);
            ModAppType.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 168);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 33;
            label2.Text = "Start Time:";
            // 
            // ModAppStart
            // 
            ModAppStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            ModAppStart.Format = DateTimePickerFormat.Custom;
            ModAppStart.Location = new Point(746, 165);
            ModAppStart.Margin = new Padding(5, 6, 5, 6);
            ModAppStart.Name = "ModAppStart";
            ModAppStart.Size = new Size(340, 35);
            ModAppStart.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(625, 248);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 35;
            label6.Text = "End Time:";
            // 
            // ModAppEnd
            // 
            ModAppEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            ModAppEnd.Format = DateTimePickerFormat.Custom;
            ModAppEnd.Location = new Point(746, 243);
            ModAppEnd.Margin = new Padding(5, 6, 5, 6);
            ModAppEnd.Name = "ModAppEnd";
            ModAppEnd.Size = new Size(340, 35);
            ModAppEnd.TabIndex = 36;
            // 
            // AddAppSave
            // 
            AddAppSave.Location = new Point(403, 364);
            AddAppSave.Margin = new Padding(5, 6, 5, 6);
            AddAppSave.Name = "AddAppSave";
            AddAppSave.Size = new Size(151, 55);
            AddAppSave.TabIndex = 37;
            AddAppSave.Text = "Save";
            AddAppSave.UseVisualStyleBackColor = true;
            // 
            // AddAppCancel
            // 
            AddAppCancel.Location = new Point(616, 364);
            AddAppCancel.Margin = new Padding(5, 6, 5, 6);
            AddAppCancel.Name = "AddAppCancel";
            AddAppCancel.Size = new Size(151, 55);
            AddAppCancel.TabIndex = 38;
            AddAppCancel.Text = "Cancel";
            AddAppCancel.UseVisualStyleBackColor = true;
            // 
            // UpdAppForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 455);
            Controls.Add(AddAppCancel);
            Controls.Add(AddAppSave);
            Controls.Add(ModAppEnd);
            Controls.Add(label6);
            Controls.Add(ModAppStart);
            Controls.Add(label2);
            Controls.Add(ModAppType);
            Controls.Add(label4);
            Controls.Add(ModAppCustID);
            Controls.Add(label3);
            Controls.Add(ModAppSearch);
            Controls.Add(ModAppID);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UpdAppForm";
            Text = "Update Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox ModAppID;
        private Button ModAppSearch;
        private Label label3;
        private TextBox ModAppCustID;
        private Label label4;
        private TextBox ModAppType;
        private Label label2;
        private DateTimePicker ModAppStart;
        private Label label6;
        private DateTimePicker ModAppEnd;
        private Button AddAppSave;
        private Button AddAppCancel;
    }
}