namespace C969_Scheduling_Application
{
    partial class NewAppForm
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
            label3 = new Label();
            AddAppCustID = new TextBox();
            label4 = new Label();
            AddAppType = new TextBox();
            label2 = new Label();
            AddAppStart = new DateTimePicker();
            label5 = new Label();
            AddAppEnd = new DateTimePicker();
            AddAppSave = new Button();
            AddAppCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(772, 30);
            label1.TabIndex = 0;
            label1.Text = "Please fill out the information below and hit Save to schedule a new appointment.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 109);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 5;
            label3.Text = "Customer ID:";
            // 
            // AddAppCustID
            // 
            AddAppCustID.Location = new Point(205, 106);
            AddAppCustID.Margin = new Padding(5, 6, 5, 6);
            AddAppCustID.Name = "AddAppCustID";
            AddAppCustID.Size = new Size(158, 35);
            AddAppCustID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 197);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 30);
            label4.TabIndex = 8;
            label4.Text = "Appointment Type:";
            // 
            // AddAppType
            // 
            AddAppType.Location = new Point(205, 194);
            AddAppType.Margin = new Padding(5, 6, 5, 6);
            AddAppType.Name = "AddAppType";
            AddAppType.Size = new Size(309, 35);
            AddAppType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(606, 109);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 10;
            label2.Text = "Start Time:";
            // 
            // AddAppStart
            // 
            AddAppStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            AddAppStart.Format = DateTimePickerFormat.Custom;
            AddAppStart.Location = new Point(727, 106);
            AddAppStart.Margin = new Padding(5, 6, 5, 6);
            AddAppStart.Name = "AddAppStart";
            AddAppStart.Size = new Size(340, 35);
            AddAppStart.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 197);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 30);
            label5.TabIndex = 12;
            label5.Text = "End Time:";
            // 
            // AddAppEnd
            // 
            AddAppEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            AddAppEnd.Format = DateTimePickerFormat.Custom;
            AddAppEnd.Location = new Point(727, 192);
            AddAppEnd.Margin = new Padding(5, 6, 5, 6);
            AddAppEnd.Name = "AddAppEnd";
            AddAppEnd.Size = new Size(340, 35);
            AddAppEnd.TabIndex = 13;
            // 
            // AddAppSave
            // 
            AddAppSave.Location = new Point(384, 340);
            AddAppSave.Margin = new Padding(5, 6, 5, 6);
            AddAppSave.Name = "AddAppSave";
            AddAppSave.Size = new Size(151, 55);
            AddAppSave.TabIndex = 14;
            AddAppSave.Text = "Save";
            AddAppSave.UseVisualStyleBackColor = true;
            // 
            // AddAppCancel
            // 
            AddAppCancel.Location = new Point(620, 340);
            AddAppCancel.Margin = new Padding(5, 6, 5, 6);
            AddAppCancel.Name = "AddAppCancel";
            AddAppCancel.Size = new Size(151, 55);
            AddAppCancel.TabIndex = 15;
            AddAppCancel.Text = "Cancel";
            AddAppCancel.UseVisualStyleBackColor = true;
            // 
            // NewAppForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 425);
            Controls.Add(AddAppCancel);
            Controls.Add(AddAppSave);
            Controls.Add(AddAppEnd);
            Controls.Add(label5);
            Controls.Add(AddAppStart);
            Controls.Add(label2);
            Controls.Add(AddAppType);
            Controls.Add(label4);
            Controls.Add(AddAppCustID);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "NewAppForm";
            Text = "New Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox AddAppCustID;
        private Label label4;
        private TextBox AddAppType;
        private Label label2;
        private DateTimePicker AddAppStart;
        private Label label5;
        private DateTimePicker AddAppEnd;
        private Button AddAppSave;
        private Button AddAppCancel;
    }
}