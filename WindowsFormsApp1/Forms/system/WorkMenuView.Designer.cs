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
            this.l_ChooseClientTipe = new System.Windows.Forms.Label();
            this.b_СonnectionCases_Palicy = new System.Windows.Forms.Button();
            this.b_CreatCoses = new System.Windows.Forms.Button();
            this.b_CreatPolice = new System.Windows.Forms.Button();
            this.labelNotification = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbStatus_Policy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSurname = new System.Windows.Forms.Label();
            this.l_SurnameInsurance = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.l_TypeInsurance = new System.Windows.Forms.Label();
            this.b_employees = new System.Windows.Forms.Button();
            this.l_LoginAgent = new System.Windows.Forms.Label();
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
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // l_ChooseClientTipe
            // 
            this.l_ChooseClientTipe.AutoSize = true;
            this.l_ChooseClientTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ChooseClientTipe.ForeColor = System.Drawing.Color.Red;
            this.l_ChooseClientTipe.Location = new System.Drawing.Point(216, 43);
            this.l_ChooseClientTipe.Name = "l_ChooseClientTipe";
            this.l_ChooseClientTipe.Size = new System.Drawing.Size(150, 20);
            this.l_ChooseClientTipe.TabIndex = 10;
            this.l_ChooseClientTipe.Text = "choose client tipe ->";
            this.l_ChooseClientTipe.Click += new System.EventHandler(this.l_ChooseClientTipe_Click);
            // 
            // b_СonnectionCases_Palicy
            // 
            this.b_СonnectionCases_Palicy.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_СonnectionCases_Palicy.Location = new System.Drawing.Point(430, 366);
            this.b_СonnectionCases_Palicy.Name = "b_СonnectionCases_Palicy";
            this.b_СonnectionCases_Palicy.Size = new System.Drawing.Size(202, 32);
            this.b_СonnectionCases_Palicy.TabIndex = 13;
            this.b_СonnectionCases_Palicy.Text = "Связь случай-полис";
            this.b_СonnectionCases_Palicy.UseVisualStyleBackColor = true;
            this.b_СonnectionCases_Palicy.Visible = false;
            // 
            // b_CreatCoses
            // 
            this.b_CreatCoses.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_CreatCoses.Location = new System.Drawing.Point(557, 282);
            this.b_CreatCoses.Name = "b_CreatCoses";
            this.b_CreatCoses.Size = new System.Drawing.Size(176, 57);
            this.b_CreatCoses.TabIndex = 12;
            this.b_CreatCoses.Text = "Создать случай";
            this.b_CreatCoses.UseVisualStyleBackColor = true;
            this.b_CreatCoses.Visible = false;
            // 
            // b_CreatPolice
            // 
            this.b_CreatPolice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_CreatPolice.Location = new System.Drawing.Point(456, 219);
            this.b_CreatPolice.Name = "b_CreatPolice";
            this.b_CreatPolice.Size = new System.Drawing.Size(176, 57);
            this.b_CreatPolice.TabIndex = 11;
            this.b_CreatPolice.Text = "Создать полис";
            this.b_CreatPolice.UseVisualStyleBackColor = true;
            this.b_CreatPolice.Visible = false;
            this.b_CreatPolice.Click += new System.EventHandler(this.b_CreatPolice_Click);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Location = new System.Drawing.Point(529, 102);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(128, 13);
            this.labelNotification.TabIndex = 14;
            this.labelNotification.Text = "Информация об агенте:";
            this.labelNotification.Click += new System.EventHandler(this.labelNotification_Click);
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
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(574, 131);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Фамилия:";
            // 
            // l_SurnameInsurance
            // 
            this.l_SurnameInsurance.AutoSize = true;
            this.l_SurnameInsurance.Location = new System.Drawing.Point(639, 131);
            this.l_SurnameInsurance.Name = "l_SurnameInsurance";
            this.l_SurnameInsurance.Size = new System.Drawing.Size(44, 13);
            this.l_SurnameInsurance.TabIndex = 18;
            this.l_SurnameInsurance.Text = "Пупкин";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(589, 164);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Статус:";
            // 
            // l_TypeInsurance
            // 
            this.l_TypeInsurance.AutoSize = true;
            this.l_TypeInsurance.Location = new System.Drawing.Point(639, 164);
            this.l_TypeInsurance.Name = "l_TypeInsurance";
            this.l_TypeInsurance.Size = new System.Drawing.Size(40, 13);
            this.l_TypeInsurance.TabIndex = 21;
            this.l_TypeInsurance.Text = "Админ";
            // 
            // b_employees
            // 
            this.b_employees.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_employees.Location = new System.Drawing.Point(532, 26);
            this.b_employees.Name = "b_employees";
            this.b_employees.Size = new System.Drawing.Size(125, 27);
            this.b_employees.TabIndex = 22;
            this.b_employees.Text = "Сотрудники";
            this.b_employees.UseVisualStyleBackColor = true;
            this.b_employees.Visible = false;
            // 
            // l_LoginAgent
            // 
            this.l_LoginAgent.AutoSize = true;
            this.l_LoginAgent.Location = new System.Drawing.Point(663, 102);
            this.l_LoginAgent.Name = "l_LoginAgent";
            this.l_LoginAgent.Size = new System.Drawing.Size(0, 13);
            this.l_LoginAgent.TabIndex = 23;
            // 
            // WorkMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.l_LoginAgent);
            this.Controls.Add(this.b_employees);
            this.Controls.Add(this.l_TypeInsurance);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.l_SurnameInsurance);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.b_СonnectionCases_Palicy);
            this.Controls.Add(this.b_CreatCoses);
            this.Controls.Add(this.b_CreatPolice);
            this.Controls.Add(this.l_ChooseClientTipe);
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
        private System.Windows.Forms.Label l_ChooseClientTipe;
        public System.Windows.Forms.ComboBox comboBoxSelectionClientTipe;
        private System.Windows.Forms.Button b_СonnectionCases_Palicy;
        private System.Windows.Forms.Button b_CreatCoses;
        private System.Windows.Forms.Button b_CreatPolice;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tbStatus_Policy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label l_SurnameInsurance;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label l_TypeInsurance;
        private System.Windows.Forms.Button b_employees;
        private System.Windows.Forms.Label l_LoginAgent;
    }
}