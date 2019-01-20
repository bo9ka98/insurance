namespace View
{
    partial class CreatLegalClientFormView
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
            this.labelOrganisationPhone = new System.Windows.Forms.Label();
            this.labelAddressCompany = new System.Windows.Forms.Label();
            this.l_UTN = new System.Windows.Forms.Label();
            this.l_OrganisationName = new System.Windows.Forms.Label();
            this.tB_OrganisationPhone = new System.Windows.Forms.TextBox();
            this.tB_OrganisationAddress = new System.Windows.Forms.TextBox();
            this.tB_UTN = new System.Windows.Forms.TextBox();
            this.tB_CompanuName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.tB_SurnameDirector = new System.Windows.Forms.TextBox();
            this.tB_NameDirector = new System.Windows.Forms.TextBox();
            this.tB_MiddleNameDirector = new System.Windows.Forms.TextBox();
            this.groupBoxDirectorAlias = new System.Windows.Forms.GroupBox();
            this.groupBoxAccountantAlias = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_SurnameAccountant = new System.Windows.Forms.TextBox();
            this.tB_MiddleNameAccountant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_NameAccountant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.groupBoxDirectorAlias.SuspendLayout();
            this.groupBoxAccountantAlias.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrganisationPhone
            // 
            this.labelOrganisationPhone.AutoSize = true;
            this.labelOrganisationPhone.Location = new System.Drawing.Point(75, 345);
            this.labelOrganisationPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganisationPhone.Name = "labelOrganisationPhone";
            this.labelOrganisationPhone.Size = new System.Drawing.Size(93, 13);
            this.labelOrganisationPhone.TabIndex = 23;
            this.labelOrganisationPhone.Text = "Номер телефона";
            // 
            // labelAddressCompany
            // 
            this.labelAddressCompany.AutoSize = true;
            this.labelAddressCompany.Location = new System.Drawing.Point(62, 302);
            this.labelAddressCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddressCompany.Name = "labelAddressCompany";
            this.labelAddressCompany.Size = new System.Drawing.Size(106, 13);
            this.labelAddressCompany.TabIndex = 22;
            this.labelAddressCompany.Text = "Адрес организации";
            this.labelAddressCompany.Click += new System.EventHandler(this.label5_Click);
            // 
            // l_UTN
            // 
            this.l_UTN.AutoSize = true;
            this.l_UTN.Location = new System.Drawing.Point(137, 84);
            this.l_UTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_UTN.Name = "l_UTN";
            this.l_UTN.Size = new System.Drawing.Size(31, 13);
            this.l_UTN.TabIndex = 19;
            this.l_UTN.Text = "УНН";
            // 
            // l_OrganisationName
            // 
            this.l_OrganisationName.AutoSize = true;
            this.l_OrganisationName.Location = new System.Drawing.Point(43, 46);
            this.l_OrganisationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_OrganisationName.Name = "l_OrganisationName";
            this.l_OrganisationName.Size = new System.Drawing.Size(125, 13);
            this.l_OrganisationName.TabIndex = 18;
            this.l_OrganisationName.Text = "Название организации";
            // 
            // tB_OrganisationPhone
            // 
            this.tB_OrganisationPhone.Location = new System.Drawing.Point(172, 342);
            this.tB_OrganisationPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tB_OrganisationPhone.Name = "tB_OrganisationPhone";
            this.tB_OrganisationPhone.Size = new System.Drawing.Size(283, 20);
            this.tB_OrganisationPhone.TabIndex = 17;
            // 
            // tB_OrganisationAddress
            // 
            this.tB_OrganisationAddress.Location = new System.Drawing.Point(173, 302);
            this.tB_OrganisationAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tB_OrganisationAddress.Name = "tB_OrganisationAddress";
            this.tB_OrganisationAddress.Size = new System.Drawing.Size(283, 20);
            this.tB_OrganisationAddress.TabIndex = 16;
            // 
            // tB_UTN
            // 
            this.tB_UTN.Location = new System.Drawing.Point(173, 84);
            this.tB_UTN.Margin = new System.Windows.Forms.Padding(2);
            this.tB_UTN.Name = "tB_UTN";
            this.tB_UTN.Size = new System.Drawing.Size(283, 20);
            this.tB_UTN.TabIndex = 13;
            this.tB_UTN.TextChanged += new System.EventHandler(this.TextBoxUTN_TextChanged);
            // 
            // tB_CompanuName
            // 
            this.tB_CompanuName.Location = new System.Drawing.Point(173, 43);
            this.tB_CompanuName.Margin = new System.Windows.Forms.Padding(2);
            this.tB_CompanuName.Name = "tB_CompanuName";
            this.tB_CompanuName.Size = new System.Drawing.Size(283, 20);
            this.tB_CompanuName.TabIndex = 12;
            this.tB_CompanuName.TextChanged += new System.EventHandler(this.tB_OrganisationName_TextChanged);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(18, 109);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 28;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(17, 38);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 26;
            this.labelSurname.Text = "Фамилия";
            // 
            // tB_SurnameDirector
            // 
            this.tB_SurnameDirector.Location = new System.Drawing.Point(79, 35);
            this.tB_SurnameDirector.Name = "tB_SurnameDirector";
            this.tB_SurnameDirector.Size = new System.Drawing.Size(155, 20);
            this.tB_SurnameDirector.TabIndex = 29;
            // 
            // tB_NameDirector
            // 
            this.tB_NameDirector.Location = new System.Drawing.Point(78, 72);
            this.tB_NameDirector.Name = "tB_NameDirector";
            this.tB_NameDirector.Size = new System.Drawing.Size(155, 20);
            this.tB_NameDirector.TabIndex = 30;
            // 
            // tB_MiddleNameDirector
            // 
            this.tB_MiddleNameDirector.Location = new System.Drawing.Point(78, 106);
            this.tB_MiddleNameDirector.Name = "tB_MiddleNameDirector";
            this.tB_MiddleNameDirector.Size = new System.Drawing.Size(155, 20);
            this.tB_MiddleNameDirector.TabIndex = 31;
            // 
            // groupBoxDirectorAlias
            // 
            this.groupBoxDirectorAlias.Controls.Add(this.labelSurname);
            this.groupBoxDirectorAlias.Controls.Add(this.tB_MiddleNameDirector);
            this.groupBoxDirectorAlias.Controls.Add(this.tB_NameDirector);
            this.groupBoxDirectorAlias.Controls.Add(this.tB_SurnameDirector);
            this.groupBoxDirectorAlias.Controls.Add(this.labelMiddleName);
            this.groupBoxDirectorAlias.Controls.Add(this.labelName);
            this.groupBoxDirectorAlias.Location = new System.Drawing.Point(46, 124);
            this.groupBoxDirectorAlias.Name = "groupBoxDirectorAlias";
            this.groupBoxDirectorAlias.Size = new System.Drawing.Size(274, 158);
            this.groupBoxDirectorAlias.TabIndex = 32;
            this.groupBoxDirectorAlias.TabStop = false;
            this.groupBoxDirectorAlias.Text = "ФИО директора";
            // 
            // groupBoxAccountantAlias
            // 
            this.groupBoxAccountantAlias.Controls.Add(this.label1);
            this.groupBoxAccountantAlias.Controls.Add(this.tB_SurnameAccountant);
            this.groupBoxAccountantAlias.Controls.Add(this.tB_MiddleNameAccountant);
            this.groupBoxAccountantAlias.Controls.Add(this.label3);
            this.groupBoxAccountantAlias.Controls.Add(this.tB_NameAccountant);
            this.groupBoxAccountantAlias.Controls.Add(this.label2);
            this.groupBoxAccountantAlias.Location = new System.Drawing.Point(350, 124);
            this.groupBoxAccountantAlias.Name = "groupBoxAccountantAlias";
            this.groupBoxAccountantAlias.Size = new System.Drawing.Size(274, 158);
            this.groupBoxAccountantAlias.TabIndex = 33;
            this.groupBoxAccountantAlias.TabStop = false;
            this.groupBoxAccountantAlias.Text = "ФИО главного бухгалтера";
            this.groupBoxAccountantAlias.Enter += new System.EventHandler(this.groupBoxAccountantAlias_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Фамилия";
            // 
            // tB_SurnameAccountant
            // 
            this.tB_SurnameAccountant.Location = new System.Drawing.Point(88, 38);
            this.tB_SurnameAccountant.Name = "tB_SurnameAccountant";
            this.tB_SurnameAccountant.Size = new System.Drawing.Size(155, 20);
            this.tB_SurnameAccountant.TabIndex = 35;
            // 
            // tB_MiddleNameAccountant
            // 
            this.tB_MiddleNameAccountant.Location = new System.Drawing.Point(87, 109);
            this.tB_MiddleNameAccountant.Name = "tB_MiddleNameAccountant";
            this.tB_MiddleNameAccountant.Size = new System.Drawing.Size(155, 20);
            this.tB_MiddleNameAccountant.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Имя";
            // 
            // tB_NameAccountant
            // 
            this.tB_NameAccountant.Location = new System.Drawing.Point(87, 75);
            this.tB_NameAccountant.Name = "tB_NameAccountant";
            this.tB_NameAccountant.Size = new System.Drawing.Size(155, 20);
            this.tB_NameAccountant.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Отчество";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(494, 383);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(81, 34);
            this.buttonRegistration.TabIndex = 29;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // CreatLegalClientFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.groupBoxAccountantAlias);
            this.Controls.Add(this.groupBoxDirectorAlias);
            this.Controls.Add(this.labelOrganisationPhone);
            this.Controls.Add(this.labelAddressCompany);
            this.Controls.Add(this.l_UTN);
            this.Controls.Add(this.l_OrganisationName);
            this.Controls.Add(this.tB_OrganisationPhone);
            this.Controls.Add(this.tB_OrganisationAddress);
            this.Controls.Add(this.tB_UTN);
            this.Controls.Add(this.tB_CompanuName);
            this.Name = "CreatLegalClientFormView";
            this.Text = "CreatLegalClientFormView";
            this.Load += new System.EventHandler(this.CreatLegalClientFormView_Load);
            this.groupBoxDirectorAlias.ResumeLayout(false);
            this.groupBoxDirectorAlias.PerformLayout();
            this.groupBoxAccountantAlias.ResumeLayout(false);
            this.groupBoxAccountantAlias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrganisationPhone;
        private System.Windows.Forms.Label labelAddressCompany;
        private System.Windows.Forms.Label l_UTN;
        private System.Windows.Forms.Label l_OrganisationName;
        private System.Windows.Forms.TextBox tB_OrganisationPhone;
        private System.Windows.Forms.TextBox tB_OrganisationAddress;
        private System.Windows.Forms.TextBox tB_UTN;
        private System.Windows.Forms.TextBox tB_CompanuName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox tB_SurnameDirector;
        private System.Windows.Forms.TextBox tB_NameDirector;
        private System.Windows.Forms.TextBox tB_MiddleNameDirector;
        private System.Windows.Forms.GroupBox groupBoxDirectorAlias;
        private System.Windows.Forms.GroupBox groupBoxAccountantAlias;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_SurnameAccountant;
        private System.Windows.Forms.TextBox tB_MiddleNameAccountant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_NameAccountant;
        private System.Windows.Forms.Label label2;
    }
}