namespace C969_Scheduling_Application
{
    partial class DelCustForm
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
            DelCustID = new TextBox();
            DelCustSearch = new Button();
            DelCustDel = new Button();
            DelCustCancel = new Button();
            DelCustName = new Label();
            DelCustPhone = new Label();
            DelCustStreet = new Label();
            DelCustCity = new Label();
            DelCustZip = new Label();
            DelCustCountry = new Label();
            DelCustActive = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(609, 19);
            label1.TabIndex = 0;
            label1.Text = "Please enter the customer's ID that you wish to delete, look over their information, then hit Delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 77);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer ID:";
            // 
            // DelCustID
            // 
            DelCustID.Location = new Point(92, 76);
            DelCustID.Name = "DelCustID";
            DelCustID.Size = new Size(111, 23);
            DelCustID.TabIndex = 3;
            // 
            // DelCustSearch
            // 
            DelCustSearch.Location = new Point(222, 73);
            DelCustSearch.Name = "DelCustSearch";
            DelCustSearch.Size = new Size(75, 23);
            DelCustSearch.TabIndex = 4;
            DelCustSearch.Text = "Search";
            DelCustSearch.UseVisualStyleBackColor = true;
            // 
            // DelCustDel
            // 
            DelCustDel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DelCustDel.Location = new Point(16, 152);
            DelCustDel.Name = "DelCustDel";
            DelCustDel.Size = new Size(85, 28);
            DelCustDel.TabIndex = 12;
            DelCustDel.Text = "Delete";
            DelCustDel.UseVisualStyleBackColor = true;
            // 
            // DelCustCancel
            // 
            DelCustCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DelCustCancel.Location = new Point(116, 152);
            DelCustCancel.Name = "DelCustCancel";
            DelCustCancel.Size = new Size(85, 28);
            DelCustCancel.TabIndex = 13;
            DelCustCancel.Text = "Cancel";
            DelCustCancel.UseVisualStyleBackColor = true;
            // 
            // DelCustName
            // 
            DelCustName.AutoSize = true;
            DelCustName.Location = new Point(328, 47);
            DelCustName.Name = "DelCustName";
            DelCustName.Size = new Size(42, 15);
            DelCustName.TabIndex = 14;
            DelCustName.Text = "Name:";
            // 
            // DelCustPhone
            // 
            DelCustPhone.AutoSize = true;
            DelCustPhone.Location = new Point(328, 77);
            DelCustPhone.Name = "DelCustPhone";
            DelCustPhone.Size = new Size(91, 15);
            DelCustPhone.TabIndex = 15;
            DelCustPhone.Text = "Phone Number:";
            // 
            // DelCustStreet
            // 
            DelCustStreet.AutoSize = true;
            DelCustStreet.Location = new Point(533, 47);
            DelCustStreet.Name = "DelCustStreet";
            DelCustStreet.Size = new Size(85, 15);
            DelCustStreet.TabIndex = 16;
            DelCustStreet.Text = "Street Address:";
            // 
            // DelCustCity
            // 
            DelCustCity.AutoSize = true;
            DelCustCity.Location = new Point(533, 77);
            DelCustCity.Name = "DelCustCity";
            DelCustCity.Size = new Size(31, 15);
            DelCustCity.TabIndex = 17;
            DelCustCity.Text = "City:";
            // 
            // DelCustZip
            // 
            DelCustZip.AutoSize = true;
            DelCustZip.Location = new Point(533, 107);
            DelCustZip.Name = "DelCustZip";
            DelCustZip.Size = new Size(58, 15);
            DelCustZip.TabIndex = 18;
            DelCustZip.Text = "Zip Code:";
            // 
            // DelCustCountry
            // 
            DelCustCountry.AutoSize = true;
            DelCustCountry.Location = new Point(533, 134);
            DelCustCountry.Name = "DelCustCountry";
            DelCustCountry.Size = new Size(53, 15);
            DelCustCountry.TabIndex = 19;
            DelCustCountry.Text = "Country:";
            // 
            // DelCustActive
            // 
            DelCustActive.AutoSize = true;
            DelCustActive.Location = new Point(328, 107);
            DelCustActive.Name = "DelCustActive";
            DelCustActive.Size = new Size(98, 15);
            DelCustActive.TabIndex = 20;
            DelCustActive.Text = "Customer Active:";
            // 
            // DelCustForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 187);
            Controls.Add(DelCustActive);
            Controls.Add(DelCustCountry);
            Controls.Add(DelCustZip);
            Controls.Add(DelCustCity);
            Controls.Add(DelCustStreet);
            Controls.Add(DelCustPhone);
            Controls.Add(DelCustName);
            Controls.Add(DelCustCancel);
            Controls.Add(DelCustDel);
            Controls.Add(DelCustSearch);
            Controls.Add(DelCustID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DelCustForm";
            Text = "Delete A Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox DelCustID;
        private Button DelCustSearch;
        private Button DelCustDel;
        private Button DelCustCancel;
        private Label DelCustName;
        private Label DelCustPhone;
        private Label DelCustStreet;
        private Label DelCustCity;
        private Label DelCustZip;
        private Label DelCustCountry;
        private Label DelCustActive;
    }
}