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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1064, 32);
            label1.TabIndex = 0;
            label1.Text = "Please enter the customer's ID that you wish to delete, look over their information, then hit Delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 154);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 2;
            label2.Text = "Customer ID:";
            // 
            // DelCustID
            // 
            DelCustID.Location = new Point(157, 151);
            DelCustID.Margin = new Padding(5, 6, 5, 6);
            DelCustID.Name = "DelCustID";
            DelCustID.Size = new Size(187, 35);
            DelCustID.TabIndex = 3;
            // 
            // DelCustSearch
            // 
            DelCustSearch.Location = new Point(381, 146);
            DelCustSearch.Margin = new Padding(5, 6, 5, 6);
            DelCustSearch.Name = "DelCustSearch";
            DelCustSearch.Size = new Size(129, 46);
            DelCustSearch.TabIndex = 4;
            DelCustSearch.Text = "Search";
            DelCustSearch.UseVisualStyleBackColor = true;
            // 
            // DelCustDel
            // 
            DelCustDel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DelCustDel.Location = new Point(28, 303);
            DelCustDel.Margin = new Padding(5, 6, 5, 6);
            DelCustDel.Name = "DelCustDel";
            DelCustDel.Size = new Size(145, 56);
            DelCustDel.TabIndex = 12;
            DelCustDel.Text = "Delete";
            DelCustDel.UseVisualStyleBackColor = true;
            // 
            // DelCustCancel
            // 
            DelCustCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DelCustCancel.Location = new Point(199, 303);
            DelCustCancel.Margin = new Padding(5, 6, 5, 6);
            DelCustCancel.Name = "DelCustCancel";
            DelCustCancel.Size = new Size(145, 56);
            DelCustCancel.TabIndex = 13;
            DelCustCancel.Text = "Cancel";
            DelCustCancel.UseVisualStyleBackColor = true;
            // 
            // DelCustName
            // 
            DelCustName.AutoSize = true;
            DelCustName.Location = new Point(679, 92);
            DelCustName.Margin = new Padding(5, 0, 5, 0);
            DelCustName.Name = "DelCustName";
            DelCustName.Size = new Size(74, 30);
            DelCustName.TabIndex = 14;
            DelCustName.Text = "Name:";
            // 
            // DelCustPhone
            // 
            DelCustPhone.AutoSize = true;
            DelCustPhone.Location = new Point(594, 146);
            DelCustPhone.Margin = new Padding(5, 0, 5, 0);
            DelCustPhone.Name = "DelCustPhone";
            DelCustPhone.Size = new Size(159, 30);
            DelCustPhone.TabIndex = 15;
            DelCustPhone.Text = "Phone Number:";
            // 
            // DelCustStreet
            // 
            DelCustStreet.AutoSize = true;
            DelCustStreet.Location = new Point(602, 201);
            DelCustStreet.Margin = new Padding(5, 0, 5, 0);
            DelCustStreet.Name = "DelCustStreet";
            DelCustStreet.Size = new Size(151, 30);
            DelCustStreet.TabIndex = 16;
            DelCustStreet.Text = "Street Address:";
            // 
            // DelCustCity
            // 
            DelCustCity.AutoSize = true;
            DelCustCity.Location = new Point(700, 261);
            DelCustCity.Margin = new Padding(5, 0, 5, 0);
            DelCustCity.Name = "DelCustCity";
            DelCustCity.Size = new Size(53, 30);
            DelCustCity.TabIndex = 17;
            DelCustCity.Text = "City:";
            // 
            // DelCustZip
            // 
            DelCustZip.AutoSize = true;
            DelCustZip.Location = new Point(652, 317);
            DelCustZip.Margin = new Padding(5, 0, 5, 0);
            DelCustZip.Name = "DelCustZip";
            DelCustZip.Size = new Size(101, 30);
            DelCustZip.TabIndex = 18;
            DelCustZip.Text = "Zip Code:";
            // 
            // DelCustForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 374);
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
            Margin = new Padding(5, 6, 5, 6);
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
    }
}