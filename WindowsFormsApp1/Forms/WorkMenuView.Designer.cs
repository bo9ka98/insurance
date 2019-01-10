namespace View
{
    partial class WorkMenuView
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
            this.buttonIssuePolicy = new System.Windows.Forms.Button();
            this.buttonStateIncident = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonArrangePayment = new System.Windows.Forms.Button();
            this.buttonPolice = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.comboBoxSelectionClientTipe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIssuePolicy
            // 
            this.buttonIssuePolicy.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIssuePolicy.Location = new System.Drawing.Point(68, 114);
            this.buttonIssuePolicy.Name = "buttonIssuePolicy";
            this.buttonIssuePolicy.Size = new System.Drawing.Size(176, 57);
            this.buttonIssuePolicy.TabIndex = 0;
            this.buttonIssuePolicy.Text = "to issue policy";
            this.buttonIssuePolicy.UseVisualStyleBackColor = true;
            this.buttonIssuePolicy.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStateIncident
            // 
            this.buttonStateIncident.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStateIncident.Location = new System.Drawing.Point(169, 177);
            this.buttonStateIncident.Name = "buttonStateIncident";
            this.buttonStateIncident.Size = new System.Drawing.Size(176, 57);
            this.buttonStateIncident.TabIndex = 1;
            this.buttonStateIncident.Text = " state incident";
            this.buttonStateIncident.UseVisualStyleBackColor = true;
            this.buttonStateIncident.Click += new System.EventHandler(this.buttonStateIncident_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(169, 318);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(176, 57);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonArrangePayment
            // 
            this.buttonArrangePayment.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrangePayment.Location = new System.Drawing.Point(68, 261);
            this.buttonArrangePayment.Name = "buttonArrangePayment";
            this.buttonArrangePayment.Size = new System.Drawing.Size(176, 32);
            this.buttonArrangePayment.TabIndex = 3;
            this.buttonArrangePayment.Text = "arrange payment";
            this.buttonArrangePayment.UseVisualStyleBackColor = true;
            this.buttonArrangePayment.Click += new System.EventHandler(this.buttonArrangePayment_Click);
            // 
            // buttonPolice
            // 
            this.buttonPolice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolice.Location = new System.Drawing.Point(94, 381);
            this.buttonPolice.Name = "buttonPolice";
            this.buttonPolice.Size = new System.Drawing.Size(176, 57);
            this.buttonPolice.TabIndex = 4;
            this.buttonPolice.Text = "Policy";
            this.buttonPolice.UseVisualStyleBackColor = true;
            this.buttonPolice.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.Location = new System.Drawing.Point(679, 26);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(96, 27);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // comboBoxSelectionClientTipe
            // 
            this.comboBoxSelectionClientTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectionClientTipe.FormattingEnabled = true;
            this.comboBoxSelectionClientTipe.Items.AddRange(new object[] {
            "both types",
            "natural person",
            "legal person"});
            this.comboBoxSelectionClientTipe.Location = new System.Drawing.Point(191, 56);
            this.comboBoxSelectionClientTipe.Name = "comboBoxSelectionClientTipe";
            this.comboBoxSelectionClientTipe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSelectionClientTipe.Size = new System.Drawing.Size(138, 21);
            this.comboBoxSelectionClientTipe.TabIndex = 9;
            this.comboBoxSelectionClientTipe.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipeClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "client tipe ->";
            // 
            // WorkMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectionClientTipe);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonPolice);
            this.Controls.Add(this.buttonArrangePayment);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonStateIncident);
            this.Controls.Add(this.buttonIssuePolicy);
            this.Name = "WorkMenuView";
            this.Text = "WorkMenu";
            this.Load += new System.EventHandler(this.WorkMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIssuePolicy;
        private System.Windows.Forms.Button buttonStateIncident;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonArrangePayment;
        private System.Windows.Forms.Button buttonPolice;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxSelectionClientTipe;
    }
}