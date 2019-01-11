namespace View
{
    partial class VisualizeLegalClientFormView
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBoxAccountantAlias = new System.Windows.Forms.GroupBox();
            this.l_MiddleNameAccountantStr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_NameAccountantStr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_SurnameAccountantStr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDirectorAlias = new System.Windows.Forms.GroupBox();
            this.l_MiddleNameDirectorStr = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.l_NameDirectorStr = new System.Windows.Forms.Label();
            this.l_SurnameDirectorStr = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOrganisationPhone = new System.Windows.Forms.Label();
            this.labelAddressCompany = new System.Windows.Forms.Label();
            this.labelUTN = new System.Windows.Forms.Label();
            this.labelOrganisationName = new System.Windows.Forms.Label();
            this.l_OrganisationNameStr = new System.Windows.Forms.Label();
            this.l_UTNStr = new System.Windows.Forms.Label();
            this.l_OrganisationAddressStr = new System.Windows.Forms.Label();
            this.l_OrganisationPhoneStr = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxAccountantAlias.SuspendLayout();
            this.groupBoxDirectorAlias.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(561, 378);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(81, 34);
            this.buttonAccept.TabIndex = 42;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBoxAccountantAlias
            // 
            this.groupBoxAccountantAlias.Controls.Add(this.l_MiddleNameAccountantStr);
            this.groupBoxAccountantAlias.Controls.Add(this.label1);
            this.groupBoxAccountantAlias.Controls.Add(this.l_NameAccountantStr);
            this.groupBoxAccountantAlias.Controls.Add(this.label3);
            this.groupBoxAccountantAlias.Controls.Add(this.l_SurnameAccountantStr);
            this.groupBoxAccountantAlias.Controls.Add(this.label2);
            this.groupBoxAccountantAlias.Location = new System.Drawing.Point(417, 119);
            this.groupBoxAccountantAlias.Name = "groupBoxAccountantAlias";
            this.groupBoxAccountantAlias.Size = new System.Drawing.Size(274, 158);
            this.groupBoxAccountantAlias.TabIndex = 44;
            this.groupBoxAccountantAlias.TabStop = false;
            this.groupBoxAccountantAlias.Text = "ФИО главного бухгалтера";
            // 
            // l_MiddleNameAccountantStr
            // 
            this.l_MiddleNameAccountantStr.AutoSize = true;
            this.l_MiddleNameAccountantStr.Location = new System.Drawing.Point(88, 112);
            this.l_MiddleNameAccountantStr.Name = "l_MiddleNameAccountantStr";
            this.l_MiddleNameAccountantStr.Size = new System.Drawing.Size(121, 13);
            this.l_MiddleNameAccountantStr.TabIndex = 51;
            this.l_MiddleNameAccountantStr.Text = "MiddleNameAccountant";
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
            // l_NameAccountantStr
            // 
            this.l_NameAccountantStr.AutoSize = true;
            this.l_NameAccountantStr.Location = new System.Drawing.Point(88, 78);
            this.l_NameAccountantStr.Name = "l_NameAccountantStr";
            this.l_NameAccountantStr.Size = new System.Drawing.Size(90, 13);
            this.l_NameAccountantStr.TabIndex = 50;
            this.l_NameAccountantStr.Text = "NameAccountant";
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
            // l_SurnameAccountantStr
            // 
            this.l_SurnameAccountantStr.AutoSize = true;
            this.l_SurnameAccountantStr.Location = new System.Drawing.Point(88, 41);
            this.l_SurnameAccountantStr.Name = "l_SurnameAccountantStr";
            this.l_SurnameAccountantStr.Size = new System.Drawing.Size(104, 13);
            this.l_SurnameAccountantStr.TabIndex = 49;
            this.l_SurnameAccountantStr.Text = "SurnameAccountant";
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
            // groupBoxDirectorAlias
            // 
            this.groupBoxDirectorAlias.Controls.Add(this.l_MiddleNameDirectorStr);
            this.groupBoxDirectorAlias.Controls.Add(this.labelSurname);
            this.groupBoxDirectorAlias.Controls.Add(this.l_NameDirectorStr);
            this.groupBoxDirectorAlias.Controls.Add(this.l_SurnameDirectorStr);
            this.groupBoxDirectorAlias.Controls.Add(this.labelMiddleName);
            this.groupBoxDirectorAlias.Controls.Add(this.labelName);
            this.groupBoxDirectorAlias.Location = new System.Drawing.Point(113, 119);
            this.groupBoxDirectorAlias.Name = "groupBoxDirectorAlias";
            this.groupBoxDirectorAlias.Size = new System.Drawing.Size(274, 158);
            this.groupBoxDirectorAlias.TabIndex = 43;
            this.groupBoxDirectorAlias.TabStop = false;
            this.groupBoxDirectorAlias.Text = "ФИО директора";
            // 
            // l_MiddleNameDirectorStr
            // 
            this.l_MiddleNameDirectorStr.AutoSize = true;
            this.l_MiddleNameDirectorStr.Location = new System.Drawing.Point(79, 109);
            this.l_MiddleNameDirectorStr.Name = "l_MiddleNameDirectorStr";
            this.l_MiddleNameDirectorStr.Size = new System.Drawing.Size(103, 13);
            this.l_MiddleNameDirectorStr.TabIndex = 51;
            this.l_MiddleNameDirectorStr.Text = "MiddleNameDirector";
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
            // l_NameDirectorStr
            // 
            this.l_NameDirectorStr.AutoSize = true;
            this.l_NameDirectorStr.Location = new System.Drawing.Point(79, 75);
            this.l_NameDirectorStr.Name = "l_NameDirectorStr";
            this.l_NameDirectorStr.Size = new System.Drawing.Size(72, 13);
            this.l_NameDirectorStr.TabIndex = 50;
            this.l_NameDirectorStr.Text = "NameDirector";
            // 
            // l_SurnameDirectorStr
            // 
            this.l_SurnameDirectorStr.AutoSize = true;
            this.l_SurnameDirectorStr.Location = new System.Drawing.Point(79, 38);
            this.l_SurnameDirectorStr.Name = "l_SurnameDirectorStr";
            this.l_SurnameDirectorStr.Size = new System.Drawing.Size(86, 13);
            this.l_SurnameDirectorStr.TabIndex = 49;
            this.l_SurnameDirectorStr.Text = "SurnameDirector";
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
            // labelOrganisationPhone
            // 
            this.labelOrganisationPhone.AutoSize = true;
            this.labelOrganisationPhone.Location = new System.Drawing.Point(142, 340);
            this.labelOrganisationPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganisationPhone.Name = "labelOrganisationPhone";
            this.labelOrganisationPhone.Size = new System.Drawing.Size(93, 13);
            this.labelOrganisationPhone.TabIndex = 41;
            this.labelOrganisationPhone.Text = "Номер телефона";
            // 
            // labelAddressCompany
            // 
            this.labelAddressCompany.AutoSize = true;
            this.labelAddressCompany.Location = new System.Drawing.Point(129, 300);
            this.labelAddressCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddressCompany.Name = "labelAddressCompany";
            this.labelAddressCompany.Size = new System.Drawing.Size(106, 13);
            this.labelAddressCompany.TabIndex = 40;
            this.labelAddressCompany.Text = "Адрес организации";
            // 
            // labelUTN
            // 
            this.labelUTN.AutoSize = true;
            this.labelUTN.Location = new System.Drawing.Point(204, 79);
            this.labelUTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUTN.Name = "labelUTN";
            this.labelUTN.Size = new System.Drawing.Size(31, 13);
            this.labelUTN.TabIndex = 39;
            this.labelUTN.Text = "УНН";
            // 
            // labelOrganisationName
            // 
            this.labelOrganisationName.AutoSize = true;
            this.labelOrganisationName.Location = new System.Drawing.Point(110, 41);
            this.labelOrganisationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganisationName.Name = "labelOrganisationName";
            this.labelOrganisationName.Size = new System.Drawing.Size(125, 13);
            this.labelOrganisationName.TabIndex = 38;
            this.labelOrganisationName.Text = "Название организации";
            // 
            // l_OrganisationNameStr
            // 
            this.l_OrganisationNameStr.AutoSize = true;
            this.l_OrganisationNameStr.Location = new System.Drawing.Point(241, 41);
            this.l_OrganisationNameStr.Name = "l_OrganisationNameStr";
            this.l_OrganisationNameStr.Size = new System.Drawing.Size(94, 13);
            this.l_OrganisationNameStr.TabIndex = 45;
            this.l_OrganisationNameStr.Text = "OrganisationName";
            this.l_OrganisationNameStr.Click += new System.EventHandler(this.labelOrganisationNameStr_Click);
            // 
            // l_UTNStr
            // 
            this.l_UTNStr.AutoSize = true;
            this.l_UTNStr.Location = new System.Drawing.Point(241, 79);
            this.l_UTNStr.Name = "l_UTNStr";
            this.l_UTNStr.Size = new System.Drawing.Size(30, 13);
            this.l_UTNStr.TabIndex = 46;
            this.l_UTNStr.Text = "UTN";
            // 
            // l_OrganisationAddressStr
            // 
            this.l_OrganisationAddressStr.AutoSize = true;
            this.l_OrganisationAddressStr.Location = new System.Drawing.Point(241, 300);
            this.l_OrganisationAddressStr.Name = "l_OrganisationAddressStr";
            this.l_OrganisationAddressStr.Size = new System.Drawing.Size(104, 13);
            this.l_OrganisationAddressStr.TabIndex = 47;
            this.l_OrganisationAddressStr.Text = "OrganisationAddress";
            // 
            // l_OrganisationPhoneStr
            // 
            this.l_OrganisationPhoneStr.AutoSize = true;
            this.l_OrganisationPhoneStr.Location = new System.Drawing.Point(241, 340);
            this.l_OrganisationPhoneStr.Name = "l_OrganisationPhoneStr";
            this.l_OrganisationPhoneStr.Size = new System.Drawing.Size(97, 13);
            this.l_OrganisationPhoneStr.TabIndex = 48;
            this.l_OrganisationPhoneStr.Text = "OrganisationPhone";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(52, 378);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(81, 34);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // VisualizeLegalClientFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.l_OrganisationPhoneStr);
            this.Controls.Add(this.l_OrganisationAddressStr);
            this.Controls.Add(this.l_UTNStr);
            this.Controls.Add(this.l_OrganisationNameStr);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxAccountantAlias);
            this.Controls.Add(this.groupBoxDirectorAlias);
            this.Controls.Add(this.labelOrganisationPhone);
            this.Controls.Add(this.labelAddressCompany);
            this.Controls.Add(this.labelUTN);
            this.Controls.Add(this.labelOrganisationName);
            this.Name = "VisualizeLegalClientFormView";
            this.Text = "VisualizeLegalClientFormView";
            this.groupBoxAccountantAlias.ResumeLayout(false);
            this.groupBoxAccountantAlias.PerformLayout();
            this.groupBoxDirectorAlias.ResumeLayout(false);
            this.groupBoxDirectorAlias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBoxAccountantAlias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDirectorAlias;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOrganisationPhone;
        private System.Windows.Forms.Label labelAddressCompany;
        private System.Windows.Forms.Label labelUTN;
        private System.Windows.Forms.Label labelOrganisationName;
        private System.Windows.Forms.Label l_MiddleNameAccountantStr;
        private System.Windows.Forms.Label l_NameAccountantStr;
        private System.Windows.Forms.Label l_SurnameAccountantStr;
        private System.Windows.Forms.Label l_MiddleNameDirectorStr;
        private System.Windows.Forms.Label l_NameDirectorStr;
        private System.Windows.Forms.Label l_SurnameDirectorStr;
        private System.Windows.Forms.Label l_OrganisationNameStr;
        private System.Windows.Forms.Label l_UTNStr;
        private System.Windows.Forms.Label l_OrganisationAddressStr;
        private System.Windows.Forms.Label l_OrganisationPhoneStr;
        private System.Windows.Forms.Button buttonEdit;
    }
}