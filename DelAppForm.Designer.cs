namespace C969_Scheduling_Application
{
    partial class DelAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelAppForm));
            label1 = new Label();
            label6 = new Label();
            DelAppID = new TextBox();
            DelAppSearch = new Button();
            DelAppCustID = new Label();
            DelAppType = new Label();
            DelAppDel = new Button();
            DelAppCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // DelAppID
            // 
            resources.ApplyResources(DelAppID, "DelAppID");
            DelAppID.Name = "DelAppID";
            // 
            // DelAppSearch
            // 
            resources.ApplyResources(DelAppSearch, "DelAppSearch");
            DelAppSearch.Name = "DelAppSearch";
            DelAppSearch.UseVisualStyleBackColor = true;
            this.DelAppSearch.Click += new System.EventHandler(this.DelAppSearch_Click);

            // 
            // DelAppCustID
            // 
            resources.ApplyResources(DelAppCustID, "DelAppCustID");
            DelAppCustID.Name = "DelAppCustID";
            // 
            // DelAppType
            // 
            resources.ApplyResources(DelAppType, "DelAppType");
            DelAppType.Name = "DelAppType";
            // 
            // DelAppDel
            // 
            resources.ApplyResources(DelAppDel, "DelAppDel");
            DelAppDel.Name = "DelAppDel";
            DelAppDel.UseVisualStyleBackColor = true;
            this.DelAppDel.Click += new System.EventHandler(this.DelAppDel_Click);

            // 
            // DelAppCancel
            // 
            resources.ApplyResources(DelAppCancel, "DelAppCancel");
            DelAppCancel.Name = "DelAppCancel";
            DelAppCancel.UseVisualStyleBackColor = true;
            this.DelAppCancel.Click += new System.EventHandler(this.DelAppCancel_Click);

            // 
            // DelAppForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DelAppCancel);
            Controls.Add(DelAppDel);
            Controls.Add(DelAppType);
            Controls.Add(DelAppCustID);
            Controls.Add(DelAppSearch);
            Controls.Add(DelAppID);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "DelAppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox DelAppID;
        private Button DelAppSearch;
        private Label DelAppCustID;
        private Label DelAppType;
        private Button DelAppDel;
        private Button DelAppCancel;
    }
}