namespace C969_Scheduling_Application
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginLabel = new Label();
            UserLabel = new Label();
            PassLabel = new Label();
            PassBox = new TextBox();
            UserBox = new TextBox();
            LoginButton = new Button();
            LoginCancel = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(126, 12);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(72, 28);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Sign In";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(24, 78);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(75, 20);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Location = new Point(29, 133);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(70, 20);
            PassLabel.TabIndex = 2;
            PassLabel.Text = "Password";
            // 
            // PassBox
            // 
            PassBox.Location = new Point(105, 130);
            PassBox.Margin = new Padding(3, 4, 3, 4);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(170, 27);
            PassBox.TabIndex = 3;
            // 
            // UserBox
            // 
            UserBox.Location = new Point(105, 75);
            UserBox.Margin = new Padding(3, 4, 3, 4);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(170, 27);
            UserBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(24, 223);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(86, 31);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginCancel
            // 
            LoginCancel.Location = new Point(203, 223);
            LoginCancel.Margin = new Padding(3, 4, 3, 4);
            LoginCancel.Name = "LoginCancel";
            LoginCancel.Size = new Size(86, 31);
            LoginCancel.TabIndex = 6;
            LoginCancel.Text = "Cancel";
            LoginCancel.UseVisualStyleBackColor = true;
            this.LoginCancel.Click += new System.EventHandler(this.LoginCancel_Click);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 292);
            Controls.Add(LoginCancel);
            Controls.Add(LoginButton);
            Controls.Add(UserBox);
            Controls.Add(PassBox);
            Controls.Add(PassLabel);
            Controls.Add(UserLabel);
            Controls.Add(LoginLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Appointment Scheduler";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
            this.Load += new System.EventHandler(this.LoginForm_Load);

        }

        #endregion

        private Label LoginLabel;
        private Label UserLabel;
        private Label PassLabel;
        private TextBox PassBox;
        private TextBox UserBox;
        private Button LoginButton;
        private Button LoginCancel;
    }
}