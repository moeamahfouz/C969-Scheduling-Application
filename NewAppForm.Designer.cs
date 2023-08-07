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
            NewAppCustID = new TextBox();
            label4 = new Label();
            NewAppType = new TextBox();
            label2 = new Label();
            NewAppStart = new DateTimePicker();
            label5 = new Label();
            NewAppEnd = new DateTimePicker();
            NewAppSave = new Button();
            NewAppCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 15);
            label1.TabIndex = 0;
            label1.Text = "Please fill out the information below and hit Save to schedule a new appointment.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 54);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Customer ID:";
            // 
            // NewAppCustID
            // 
            NewAppCustID.Location = new Point(120, 53);
            NewAppCustID.Name = "NewAppCustID";
            NewAppCustID.Size = new Size(94, 23);
            NewAppCustID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 98);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 8;
            label4.Text = "Appointment Type:";
            // 
            // NewAppType
            // 
            NewAppType.Location = new Point(120, 97);
            NewAppType.Name = "NewAppType";
            NewAppType.Size = new Size(182, 23);
            NewAppType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 54);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Start Time:";
            // 
            // NewAppStart
            // 
            NewAppStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            NewAppStart.Format = DateTimePickerFormat.Custom;
            NewAppStart.Location = new Point(424, 53);
            NewAppStart.Name = "NewAppStart";
            NewAppStart.Size = new Size(200, 23);
            NewAppStart.TabIndex = 11;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 98);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "End Time:";
            // 
            // NewAppEnd
            // 
            NewAppEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            NewAppEnd.Format = DateTimePickerFormat.Custom;
            NewAppEnd.Location = new Point(424, 96);
            NewAppEnd.Name = "NewAppEnd";
            NewAppEnd.Size = new Size(200, 23);
            NewAppEnd.TabIndex = 13;
            // 
            // NewAppSave
            // 
            NewAppSave.Location = new Point(224, 170);
            NewAppSave.Name = "NewAppSave";
            NewAppSave.Size = new Size(88, 28);
            NewAppSave.TabIndex = 14;
            NewAppSave.Text = "Save";
            NewAppSave.UseVisualStyleBackColor = true;
            this.NewAppSave.Click += new System.EventHandler(this.NewAppSave_Click);

            // 
            // NewAppCancel
            // 
            NewAppCancel.Location = new Point(362, 170);
            NewAppCancel.Name = "NewAppCancel";
            NewAppCancel.Size = new Size(88, 28);
            NewAppCancel.TabIndex = 15;
            NewAppCancel.Text = "Cancel";
            NewAppCancel.UseVisualStyleBackColor = true;
            this.NewAppCancel.Click += new System.EventHandler(this.NewAppCancel_Click);

            // 
            // NewAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 212);
            Controls.Add(NewAppCancel);
            Controls.Add(NewAppSave);
            Controls.Add(NewAppEnd);
            Controls.Add(label5);
            Controls.Add(NewAppStart);
            Controls.Add(label2);
            Controls.Add(NewAppType);
            Controls.Add(label4);
            Controls.Add(NewAppCustID);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewAppForm";
            Text = "New Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox NewAppCustID;
        private Label label4;
        private TextBox NewAppType;
        private Label label2;
        private DateTimePicker NewAppStart;
        private Label label5;
        private DateTimePicker NewAppEnd;
        private Button NewAppSave;
        private Button NewAppCancel;
    }
}