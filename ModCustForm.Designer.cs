namespace C969_Scheduling_Application
{
    partial class ModCustForm
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
            label9 = new Label();
            ModCustID = new TextBox();
            ModCustIDSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ModCustName = new TextBox();
            ModCustPhone = new TextBox();
            ModCustActiveYes = new RadioButton();
            ModCustActiveNo = new RadioButton();
            ModCustStreet = new TextBox();
            ModCustCity = new TextBox();
            ModCustZip = new TextBox();
            ModCustCountry = new TextBox();
            ModCustSave = new Button();
            ModCustCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(703, 19);
            label1.TabIndex = 0;
            label1.Text = "Please enter the ID of the customer you want to modify. Once finished modifying, hit Save to apply your changes.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(205, 45);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 37;
            label9.Text = "Customer ID:";
            // 
            // ModCustID
            // 
            ModCustID.Location = new Point(287, 42);
            ModCustID.Name = "ModCustID";
            ModCustID.Size = new Size(100, 23);
            ModCustID.TabIndex = 38;
            // 
            // ModCustIDSearch
            // 
            ModCustIDSearch.Location = new Point(406, 42);
            ModCustIDSearch.Name = "ModCustIDSearch";
            ModCustIDSearch.Size = new Size(73, 24);
            ModCustIDSearch.TabIndex = 39;
            ModCustIDSearch.Text = "Search";
            ModCustIDSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 92);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 40;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 136);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 41;
            label3.Text = "Phone Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 180);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 42;
            label8.Text = "Active:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 92);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 43;
            label4.Text = "Street Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 136);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 44;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 180);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 45;
            label6.Text = "Zip Code:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 227);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 46;
            label7.Text = "Country:";
            // 
            // ModCustName
            // 
            ModCustName.Location = new Point(154, 89);
            ModCustName.Name = "ModCustName";
            ModCustName.Size = new Size(174, 23);
            ModCustName.TabIndex = 47;
            // 
            // ModCustPhone
            // 
            ModCustPhone.Location = new Point(154, 133);
            ModCustPhone.Name = "ModCustPhone";
            ModCustPhone.Size = new Size(174, 23);
            ModCustPhone.TabIndex = 48;
            // 
            // ModCustActiveYes
            // 
            ModCustActiveYes.AutoSize = true;
            ModCustActiveYes.Location = new Point(176, 178);
            ModCustActiveYes.Name = "ModCustActiveYes";
            ModCustActiveYes.Size = new Size(42, 19);
            ModCustActiveYes.TabIndex = 49;
            ModCustActiveYes.TabStop = true;
            ModCustActiveYes.Text = "Yes";
            ModCustActiveYes.UseVisualStyleBackColor = true;
            // 
            // ModCustActiveNo
            // 
            ModCustActiveNo.AutoSize = true;
            ModCustActiveNo.Location = new Point(254, 178);
            ModCustActiveNo.Name = "ModCustActiveNo";
            ModCustActiveNo.Size = new Size(41, 19);
            ModCustActiveNo.TabIndex = 50;
            ModCustActiveNo.TabStop = true;
            ModCustActiveNo.Text = "No";
            ModCustActiveNo.UseVisualStyleBackColor = true;
            // 
            // ModCustStreet
            // 
            ModCustStreet.Location = new Point(508, 89);
            ModCustStreet.Name = "ModCustStreet";
            ModCustStreet.Size = new Size(174, 23);
            ModCustStreet.TabIndex = 51;
            // 
            // ModCustCity
            // 
            ModCustCity.Location = new Point(508, 133);
            ModCustCity.Name = "ModCustCity";
            ModCustCity.Size = new Size(174, 23);
            ModCustCity.TabIndex = 52;
            // 
            // ModCustZip
            // 
            ModCustZip.Location = new Point(508, 177);
            ModCustZip.Name = "ModCustZip";
            ModCustZip.Size = new Size(174, 23);
            ModCustZip.TabIndex = 53;
            // 
            // ModCustCountry
            // 
            ModCustCountry.Location = new Point(508, 224);
            ModCustCountry.Name = "ModCustCountry";
            ModCustCountry.Size = new Size(174, 23);
            ModCustCountry.TabIndex = 54;
            // 
            // ModCustSave
            // 
            ModCustSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModCustSave.Location = new Point(29, 274);
            ModCustSave.Name = "ModCustSave";
            ModCustSave.Size = new Size(91, 41);
            ModCustSave.TabIndex = 55;
            ModCustSave.Text = "Save";
            ModCustSave.UseVisualStyleBackColor = true;
            // 
            // ModCustCancel
            // 
            ModCustCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModCustCancel.Location = new Point(154, 274);
            ModCustCancel.Name = "ModCustCancel";
            ModCustCancel.Size = new Size(91, 41);
            ModCustCancel.TabIndex = 56;
            ModCustCancel.Text = "Cancel";
            ModCustCancel.UseVisualStyleBackColor = true;
            // 
            // ModCustForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 327);
            Controls.Add(ModCustCancel);
            Controls.Add(ModCustSave);
            Controls.Add(ModCustCountry);
            Controls.Add(ModCustZip);
            Controls.Add(ModCustCity);
            Controls.Add(ModCustStreet);
            Controls.Add(ModCustActiveNo);
            Controls.Add(ModCustActiveYes);
            Controls.Add(ModCustPhone);
            Controls.Add(ModCustName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ModCustIDSearch);
            Controls.Add(ModCustID);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "ModCustForm";
            Text = "Modify A Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private TextBox ModCustID;
        private Button ModCustIDSearch;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ModCustName;
        private TextBox ModCustPhone;
        private RadioButton ModCustActiveYes;
        private RadioButton ModCustActiveNo;
        private TextBox ModCustStreet;
        private TextBox ModCustCity;
        private TextBox ModCustZip;
        private TextBox ModCustCountry;
        private Button ModCustSave;
        private Button ModCustCancel;
    }
}