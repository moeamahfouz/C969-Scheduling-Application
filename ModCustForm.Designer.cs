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
            label1.Location = new Point(21, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1218, 32);
            label1.TabIndex = 0;
            label1.Text = "Please enter the ID of the customer you want to update. Once finished updating, hit Save to apply your changes.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(351, 90);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(134, 30);
            label9.TabIndex = 37;
            label9.Text = "Customer ID:";
            // 
            // ModCustID
            // 
            ModCustID.Location = new Point(492, 84);
            ModCustID.Margin = new Padding(5, 6, 5, 6);
            ModCustID.Name = "ModCustID";
            ModCustID.Size = new Size(169, 35);
            ModCustID.TabIndex = 38;
            // 
            // ModCustIDSearch
            // 
            ModCustIDSearch.Location = new Point(696, 84);
            ModCustIDSearch.Margin = new Padding(5, 6, 5, 6);
            ModCustIDSearch.Name = "ModCustIDSearch";
            ModCustIDSearch.Size = new Size(125, 48);
            ModCustIDSearch.TabIndex = 39;
            ModCustIDSearch.Text = "Search";
            ModCustIDSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 184);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 40;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 272);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 30);
            label3.TabIndex = 41;
            label3.Text = "Phone Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(154, 360);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 30);
            label8.TabIndex = 42;
            label8.Text = "Active:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 184);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 43;
            label4.Text = "Street Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(789, 272);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 30);
            label5.TabIndex = 44;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(742, 360);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 45;
            label6.Text = "Zip Code:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(751, 454);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 30);
            label7.TabIndex = 46;
            label7.Text = "Country:";
            // 
            // ModCustName
            // 
            ModCustName.Location = new Point(264, 178);
            ModCustName.Margin = new Padding(5, 6, 5, 6);
            ModCustName.Name = "ModCustName";
            ModCustName.Size = new Size(295, 35);
            ModCustName.TabIndex = 47;
            // 
            // ModCustPhone
            // 
            ModCustPhone.Location = new Point(264, 266);
            ModCustPhone.Margin = new Padding(5, 6, 5, 6);
            ModCustPhone.Name = "ModCustPhone";
            ModCustPhone.Size = new Size(295, 35);
            ModCustPhone.TabIndex = 48;
            // 
            // ModCustActiveYes
            // 
            ModCustActiveYes.AutoSize = true;
            ModCustActiveYes.Location = new Point(302, 356);
            ModCustActiveYes.Margin = new Padding(5, 6, 5, 6);
            ModCustActiveYes.Name = "ModCustActiveYes";
            ModCustActiveYes.Size = new Size(68, 34);
            ModCustActiveYes.TabIndex = 49;
            ModCustActiveYes.TabStop = true;
            ModCustActiveYes.Text = "Yes";
            ModCustActiveYes.UseVisualStyleBackColor = true;
            // 
            // ModCustActiveNo
            // 
            ModCustActiveNo.AutoSize = true;
            ModCustActiveNo.Location = new Point(435, 356);
            ModCustActiveNo.Margin = new Padding(5, 6, 5, 6);
            ModCustActiveNo.Name = "ModCustActiveNo";
            ModCustActiveNo.Size = new Size(66, 34);
            ModCustActiveNo.TabIndex = 50;
            ModCustActiveNo.TabStop = true;
            ModCustActiveNo.Text = "No";
            ModCustActiveNo.UseVisualStyleBackColor = true;
            // 
            // ModCustStreet
            // 
            ModCustStreet.Location = new Point(871, 178);
            ModCustStreet.Margin = new Padding(5, 6, 5, 6);
            ModCustStreet.Name = "ModCustStreet";
            ModCustStreet.Size = new Size(295, 35);
            ModCustStreet.TabIndex = 51;
            // 
            // ModCustCity
            // 
            ModCustCity.Location = new Point(871, 266);
            ModCustCity.Margin = new Padding(5, 6, 5, 6);
            ModCustCity.Name = "ModCustCity";
            ModCustCity.Size = new Size(295, 35);
            ModCustCity.TabIndex = 52;
            // 
            // ModCustZip
            // 
            ModCustZip.Location = new Point(871, 354);
            ModCustZip.Margin = new Padding(5, 6, 5, 6);
            ModCustZip.Name = "ModCustZip";
            ModCustZip.Size = new Size(295, 35);
            ModCustZip.TabIndex = 53;
            // 
            // ModCustCountry
            // 
            ModCustCountry.Location = new Point(871, 448);
            ModCustCountry.Margin = new Padding(5, 6, 5, 6);
            ModCustCountry.Name = "ModCustCountry";
            ModCustCountry.Size = new Size(295, 35);
            ModCustCountry.TabIndex = 54;
            // 
            // ModCustSave
            // 
            ModCustSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModCustSave.Location = new Point(50, 548);
            ModCustSave.Margin = new Padding(5, 6, 5, 6);
            ModCustSave.Name = "ModCustSave";
            ModCustSave.Size = new Size(156, 82);
            ModCustSave.TabIndex = 55;
            ModCustSave.Text = "Save";
            ModCustSave.UseVisualStyleBackColor = true;
            // 
            // ModCustCancel
            // 
            ModCustCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModCustCancel.Location = new Point(264, 548);
            ModCustCancel.Margin = new Padding(5, 6, 5, 6);
            ModCustCancel.Name = "ModCustCancel";
            ModCustCancel.Size = new Size(156, 82);
            ModCustCancel.TabIndex = 56;
            ModCustCancel.Text = "Cancel";
            ModCustCancel.UseVisualStyleBackColor = true;
            // 
            // ModCustForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 654);
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
            Margin = new Padding(5, 6, 5, 6);
            Name = "ModCustForm";
            Text = "Update A Customer";
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