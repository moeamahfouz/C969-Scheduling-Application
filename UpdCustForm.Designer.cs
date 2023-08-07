namespace C969_Scheduling_Application
{
    partial class UpdCustForm
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
            UpdCustID = new TextBox();
            UpdCustSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            UpdCustName = new TextBox();
            UpdCustPhone = new TextBox();
            UpdCustActiveYes = new RadioButton();
            UpdCustActiveNo = new RadioButton();
            UpdCustStreet = new TextBox();
            UpdCustCity = new TextBox();
            UpdCustZip = new TextBox();
            UpdCustCountry = new TextBox();
            UpdCustSave = new Button();
            UpdCustCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(698, 19);
            label1.TabIndex = 0;
            label1.Text = "Please enter the ID of the customer you want to update. Once finished updating, hit Save to apply your changes.";
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
            // UpdCustID
            // 
            UpdCustID.Location = new Point(287, 42);
            UpdCustID.Name = "UpdCustID";
            UpdCustID.Size = new Size(100, 23);
            UpdCustID.TabIndex = 38;
            // 
            // UpdCustSearch
            // 
            UpdCustSearch.Location = new Point(406, 42);
            UpdCustSearch.Name = "UpdCustSearch";
            UpdCustSearch.Size = new Size(73, 24);
            UpdCustSearch.TabIndex = 39;
            UpdCustSearch.Text = "Search";
            UpdCustSearch.UseVisualStyleBackColor = true;
            this.UpdCustSearch.Click += new System.EventHandler(this.UpdCustSearch_Click);

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
            // UpdCustName
            // 
            UpdCustName.Location = new Point(154, 89);
            UpdCustName.Name = "UpdCustName";
            UpdCustName.Size = new Size(174, 23);
            UpdCustName.TabIndex = 47;
            // 
            // UpdCustPhone
            // 
            UpdCustPhone.Location = new Point(154, 133);
            UpdCustPhone.Name = "UpdCustPhone";
            UpdCustPhone.Size = new Size(174, 23);
            UpdCustPhone.TabIndex = 48;
            // 
            // UpdCustActiveYes
            // 
            UpdCustActiveYes.AutoSize = true;
            UpdCustActiveYes.Location = new Point(176, 178);
            UpdCustActiveYes.Name = "UpdCustActiveYes";
            UpdCustActiveYes.Size = new Size(42, 19);
            UpdCustActiveYes.TabIndex = 49;
            UpdCustActiveYes.TabStop = true;
            UpdCustActiveYes.Text = "Yes";
            UpdCustActiveYes.UseVisualStyleBackColor = true;
            // 
            // UpdCustActiveNo
            // 
            UpdCustActiveNo.AutoSize = true;
            UpdCustActiveNo.Location = new Point(254, 178);
            UpdCustActiveNo.Name = "UpdCustActiveNo";
            UpdCustActiveNo.Size = new Size(41, 19);
            UpdCustActiveNo.TabIndex = 50;
            UpdCustActiveNo.TabStop = true;
            UpdCustActiveNo.Text = "No";
            UpdCustActiveNo.UseVisualStyleBackColor = true;
            // 
            // UpdCustStreet
            // 
            UpdCustStreet.Location = new Point(508, 89);
            UpdCustStreet.Name = "UpdCustStreet";
            UpdCustStreet.Size = new Size(174, 23);
            UpdCustStreet.TabIndex = 51;
            // 
            // UpdCustCity
            // 
            UpdCustCity.Location = new Point(508, 133);
            UpdCustCity.Name = "UpdCustCity";
            UpdCustCity.Size = new Size(174, 23);
            UpdCustCity.TabIndex = 52;
            // 
            // UpdCustZip
            // 
            UpdCustZip.Location = new Point(508, 177);
            UpdCustZip.Name = "UpdCustZip";
            UpdCustZip.Size = new Size(174, 23);
            UpdCustZip.TabIndex = 53;
            // 
            // UpdCustCountry
            // 
            UpdCustCountry.Location = new Point(508, 224);
            UpdCustCountry.Name = "UpdCustCountry";
            UpdCustCountry.Size = new Size(174, 23);
            UpdCustCountry.TabIndex = 54;
            // 
            // UpdCustSave
            // 
            UpdCustSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdCustSave.Location = new Point(29, 274);
            UpdCustSave.Name = "UpdCustSave";
            UpdCustSave.Size = new Size(91, 41);
            UpdCustSave.TabIndex = 55;
            UpdCustSave.Text = "Save";
            UpdCustSave.UseVisualStyleBackColor = true;
            this.UpdCustSave.Click += new System.EventHandler(this.UpdCustSave_Click);

            // 
            // UpdCustCancel
            // 
            UpdCustCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdCustCancel.Location = new Point(154, 274);
            UpdCustCancel.Name = "UpdCustCancel";
            UpdCustCancel.Size = new Size(91, 41);
            UpdCustCancel.TabIndex = 56;
            UpdCustCancel.Text = "Cancel";
            UpdCustCancel.UseVisualStyleBackColor = true;
            this.UpdCustCancel.Click += new System.EventHandler(this.UpdCustCancel_Click);

            // 
            // UpdCustForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 327);
            Controls.Add(UpdCustCancel);
            Controls.Add(UpdCustSave);
            Controls.Add(UpdCustCountry);
            Controls.Add(UpdCustZip);
            Controls.Add(UpdCustCity);
            Controls.Add(UpdCustStreet);
            Controls.Add(UpdCustActiveNo);
            Controls.Add(UpdCustActiveYes);
            Controls.Add(UpdCustPhone);
            Controls.Add(UpdCustName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UpdCustSearch);
            Controls.Add(UpdCustID);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "UpdCustForm";
            Text = "Update A Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private TextBox UpdCustID;
        private Button UpdCustSearch;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox UpdCustName;
        private TextBox UpdCustPhone;
        private RadioButton UpdCustActiveYes;
        private RadioButton UpdCustActiveNo;
        private TextBox UpdCustStreet;
        private TextBox UpdCustCity;
        private TextBox UpdCustZip;
        private TextBox UpdCustCountry;
        private Button UpdCustSave;
        private Button UpdCustCancel;
    }
}