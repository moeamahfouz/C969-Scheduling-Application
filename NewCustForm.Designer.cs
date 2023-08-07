namespace C969_Scheduling_Application
{
    partial class NewCustForm
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
            label2 = new Label();
            NewCustName = new TextBox();
            label3 = new Label();
            NewCustPhone = new TextBox();
            label8 = new Label();
            NewCustActiveYes = new RadioButton();
            NewCustActiveNo = new RadioButton();
            label4 = new Label();
            NewCustStreet = new TextBox();
            label5 = new Label();
            NewCustCity = new TextBox();
            label6 = new Label();
            NewCustZip = new TextBox();
            label7 = new Label();
            NewCustCountry = new TextBox();
            NewCustSave = new Button();
            NewCustCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(491, 20);
            label1.TabIndex = 0;
            label1.Text = "Please fill out the information below and hit Save to add a new customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 55);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // NewCustName
            // 
            NewCustName.Location = new Point(119, 52);
            NewCustName.Name = "NewCustName";
            NewCustName.Size = new Size(174, 23);
            NewCustName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "Phone Number:";
            label3.Click += label3_Click;
            // 
            // NewCustPhone
            // 
            NewCustPhone.Location = new Point(119, 94);
            NewCustPhone.Name = "NewCustPhone";
            NewCustPhone.Size = new Size(174, 23);
            NewCustPhone.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 142);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "Customer Active:";
            // 
            // NewCustActiveYes
            // 
            NewCustActiveYes.AutoSize = true;
            NewCustActiveYes.Location = new Point(142, 140);
            NewCustActiveYes.Name = "NewCustActiveYes";
            NewCustActiveYes.Size = new Size(42, 19);
            NewCustActiveYes.TabIndex = 15;
            NewCustActiveYes.TabStop = true;
            NewCustActiveYes.Text = "Yes";
            NewCustActiveYes.UseVisualStyleBackColor = true;

            // 
            // NewCustActiveNo
            // 
            NewCustActiveNo.AutoSize = true;
            NewCustActiveNo.Location = new Point(221, 140);
            NewCustActiveNo.Name = "NewCustActiveNo";
            NewCustActiveNo.Size = new Size(41, 19);
            NewCustActiveNo.TabIndex = 16;
            NewCustActiveNo.TabStop = true;
            NewCustActiveNo.Text = "No";
            NewCustActiveNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 55);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 17;
            label4.Text = "Street Address:";
            // 
            // NewCustStreet
            // 
            NewCustStreet.Location = new Point(407, 52);
            NewCustStreet.Name = "NewCustStreet";
            NewCustStreet.Size = new Size(174, 23);
            NewCustStreet.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 94);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 19;
            label5.Text = "City:";
            // 
            // NewCustCity
            // 
            NewCustCity.Location = new Point(407, 91);
            NewCustCity.Name = "NewCustCity";
            NewCustCity.Size = new Size(174, 23);
            NewCustCity.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 133);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 21;
            label6.Text = "Zip Code:";
            // 
            // NewCustZip
            // 
            NewCustZip.Location = new Point(407, 130);
            NewCustZip.Name = "NewCustZip";
            NewCustZip.Size = new Size(174, 23);
            NewCustZip.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 175);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 23;
            label7.Text = "Country:";
            // 
            // NewCustCountry
            // 
            NewCustCountry.Location = new Point(407, 172);
            NewCustCountry.Name = "NewCustCountry";
            NewCustCountry.Size = new Size(174, 23);
            NewCustCountry.TabIndex = 24;
            // 
            // NewCustSave
            // 
            NewCustSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NewCustSave.Location = new Point(22, 214);
            NewCustSave.Name = "NewCustSave";
            NewCustSave.Size = new Size(79, 36);
            NewCustSave.TabIndex = 25;
            NewCustSave.Text = "Save";
            NewCustSave.UseVisualStyleBackColor = true;
            this.NewCustSave.Click += new System.EventHandler(this.NewCustSave_Click);

            // 
            // NewCustCancel
            // 
            NewCustCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NewCustCancel.Location = new Point(119, 214);
            NewCustCancel.Name = "NewCustCancel";
            NewCustCancel.Size = new Size(79, 36);
            NewCustCancel.TabIndex = 26;
            NewCustCancel.Text = "Cancel";
            NewCustCancel.UseVisualStyleBackColor = true;
            this.NewCustCancel.Click += new System.EventHandler(this.NewCustCancel_Click);

            // 
            // NewCustForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 262);
            Controls.Add(NewCustCancel);
            Controls.Add(NewCustSave);
            Controls.Add(NewCustCountry);
            Controls.Add(label7);
            Controls.Add(NewCustZip);
            Controls.Add(label6);
            Controls.Add(NewCustCity);
            Controls.Add(label5);
            Controls.Add(NewCustStreet);
            Controls.Add(label4);
            Controls.Add(NewCustActiveNo);
            Controls.Add(NewCustActiveYes);
            Controls.Add(label8);
            Controls.Add(NewCustPhone);
            Controls.Add(label3);
            Controls.Add(NewCustName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewCustForm";
            Text = "New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NewCustName;
        private Label label3;
        private TextBox NewCustPhone;
        private Label label8;
        private RadioButton NewCustActiveYes;
        private RadioButton NewCustActiveNo;
        private Label label4;
        private TextBox NewCustStreet;
        private Label label5;
        private TextBox NewCustCity;
        private Label label6;
        private TextBox NewCustZip;
        private Label label7;
        private TextBox NewCustCountry;
        private Button NewCustSave;
        private Button NewCustCancel;
    }
}