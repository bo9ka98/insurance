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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbStatus_Policy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIssuePolicy
            // 
            this.buttonIssuePolicy.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIssuePolicy.Location = new System.Drawing.Point(70, 78);
            this.buttonIssuePolicy.Name = "buttonIssuePolicy";
            this.buttonIssuePolicy.Size = new System.Drawing.Size(176, 57);
            this.buttonIssuePolicy.TabIndex = 0;
            this.buttonIssuePolicy.Text = "Выдать полис";
            this.buttonIssuePolicy.UseVisualStyleBackColor = true;
            this.buttonIssuePolicy.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStateIncident
            // 
            this.buttonStateIncident.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStateIncident.Location = new System.Drawing.Point(171, 141);
            this.buttonStateIncident.Name = "buttonStateIncident";
            this.buttonStateIncident.Size = new System.Drawing.Size(176, 57);
            this.buttonStateIncident.TabIndex = 1;
            this.buttonStateIncident.Text = "Новый инцедент";
            this.buttonStateIncident.UseVisualStyleBackColor = true;
            this.buttonStateIncident.Click += new System.EventHandler(this.buttonStateIncident_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(171, 282);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(176, 57);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonArrangePayment
            // 
            this.buttonArrangePayment.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrangePayment.Location = new System.Drawing.Point(70, 225);
            this.buttonArrangePayment.Name = "buttonArrangePayment";
            this.buttonArrangePayment.Size = new System.Drawing.Size(176, 32);
            this.buttonArrangePayment.TabIndex = 3;
            this.buttonArrangePayment.Text = "Компенсация";
            this.buttonArrangePayment.UseVisualStyleBackColor = true;
            this.buttonArrangePayment.Click += new System.EventHandler(this.buttonArrangePayment_Click);
            // 
            // buttonPolice
            // 
            this.buttonPolice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolice.Location = new System.Drawing.Point(96, 345);
            this.buttonPolice.Name = "buttonPolice";
            this.buttonPolice.Size = new System.Drawing.Size(176, 57);
            this.buttonPolice.TabIndex = 4;
            this.buttonPolice.Text = "Полисы";
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
            this.comboBoxSelectionClientTipe.Location = new System.Drawing.Point(372, 43);
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
            this.label1.Location = new System.Drawing.Point(271, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "client tipe ->";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(430, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Связь случай-полис";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(557, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "Создать случай";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(456, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 57);
            this.button3.TabIndex = 11;
            this.button3.Text = "Создать полис";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Информация об агенте:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStatus_Policy,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbStatus_Policy
            // 
            this.tbStatus_Policy.Name = "tbStatus_Policy";
            this.tbStatus_Policy.Size = new System.Drawing.Size(87, 17);
            this.tbStatus_Policy.Text = "tBStaus_Clients";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel2.Text = "tbStatus_Policy";
            // 
            // WorkMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectionClientTipe);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonPolice);
            this.Controls.Add(this.buttonArrangePayment);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonStateIncident);
            this.Controls.Add(this.buttonIssuePolicy);
            this.Controls.Add(this.statusStrip1);
            this.Name = "WorkMenuView";
            this.Text = "WorkMenu";
            this.Load += new System.EventHandler(this.WorkMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tbStatus_Policy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}