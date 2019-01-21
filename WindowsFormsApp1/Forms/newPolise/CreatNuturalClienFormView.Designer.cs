namespace View
{
    partial class CreatNuturalClienFormView
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
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tB_MiddleName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dTP_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateIssueRights = new System.Windows.Forms.Label();
            this.dTP_DataCar = new System.Windows.Forms.DateTimePicker();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelExperienceView = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Sex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(84, 29);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(111, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(86, 97);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Отчество";
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(175, 26);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(155, 20);
            this.tB_Surname.TabIndex = 3;
            this.tB_Surname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(175, 60);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(155, 20);
            this.tB_Name.TabIndex = 4;
            this.tB_Name.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // tB_MiddleName
            // 
            this.tB_MiddleName.Location = new System.Drawing.Point(175, 94);
            this.tB_MiddleName.Name = "tB_MiddleName";
            this.tB_MiddleName.Size = new System.Drawing.Size(155, 20);
            this.tB_MiddleName.TabIndex = 5;
            this.tB_MiddleName.TextChanged += new System.EventHandler(this.textBoxMiddleName_TextChanged);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(54, 139);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 6;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // dTP_DateOfBirth
            // 
            this.dTP_DateOfBirth.Location = new System.Drawing.Point(175, 133);
            this.dTP_DateOfBirth.Name = "dTP_DateOfBirth";
            this.dTP_DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dTP_DateOfBirth.TabIndex = 7;
            this.dTP_DateOfBirth.ValueChanged += new System.EventHandler(this.dTP_DateOfBirth_ValueChanged);
            // 
            // labelDateIssueRights
            // 
            this.labelDateIssueRights.AutoSize = true;
            this.labelDateIssueRights.Location = new System.Drawing.Point(40, 210);
            this.labelDateIssueRights.Name = "labelDateIssueRights";
            this.labelDateIssueRights.Size = new System.Drawing.Size(100, 13);
            this.labelDateIssueRights.TabIndex = 8;
            this.labelDateIssueRights.Text = "Дата выдачи прав";
            // 
            // dTP_DataCar
            // 
            this.dTP_DataCar.Location = new System.Drawing.Point(175, 204);
            this.dTP_DataCar.Name = "dTP_DataCar";
            this.dTP_DataCar.Size = new System.Drawing.Size(155, 20);
            this.dTP_DataCar.TabIndex = 9;
            this.dTP_DataCar.ValueChanged += new System.EventHandler(this.dTP_DataCar_ValueChanged);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(47, 263);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(102, 298);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Адрес";
            // 
            // tB_PhoneNumber
            // 
            this.tB_PhoneNumber.Location = new System.Drawing.Point(175, 260);
            this.tB_PhoneNumber.Name = "tB_PhoneNumber";
            this.tB_PhoneNumber.Size = new System.Drawing.Size(155, 20);
            this.tB_PhoneNumber.TabIndex = 12;
            // 
            // tB_Address
            // 
            this.tB_Address.Location = new System.Drawing.Point(175, 295);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(155, 20);
            this.tB_Address.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фото";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 88);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(75, 235);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(64, 13);
            this.labelExperience.TabIndex = 16;
            this.labelExperience.Text = "Стаж(Лет) :";
            // 
            // labelExperienceView
            // 
            this.labelExperienceView.AutoSize = true;
            this.labelExperienceView.Location = new System.Drawing.Point(175, 235);
            this.labelExperienceView.Name = "labelExperienceView";
            this.labelExperienceView.Size = new System.Drawing.Size(13, 13);
            this.labelExperienceView.TabIndex = 17;
            this.labelExperienceView.Text = "0";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(413, 404);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(81, 34);
            this.buttonRegistration.TabIndex = 18;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пол";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cB_Sex
            // 
            this.cB_Sex.FormattingEnabled = true;
            this.cB_Sex.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.cB_Sex.Location = new System.Drawing.Point(175, 168);
            this.cB_Sex.Name = "cB_Sex";
            this.cB_Sex.Size = new System.Drawing.Size(121, 21);
            this.cB_Sex.TabIndex = 20;
            this.cB_Sex.SelectedIndexChanged += new System.EventHandler(this.cB_Sex_SelectedIndexChanged);
            // 
            // CreatNuturalClienFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.cB_Sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelExperienceView);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_Address);
            this.Controls.Add(this.tB_PhoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.dTP_DataCar);
            this.Controls.Add(this.labelDateIssueRights);
            this.Controls.Add(this.dTP_DateOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.tB_MiddleName);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.tB_Surname);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Name = "CreatNuturalClienFormView";
            this.Text = "CreatNuturalClienFormView";
            this.Load += new System.EventHandler(this.CreatNuturalClienFormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_MiddleName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dTP_DateOfBirth;
        private System.Windows.Forms.Label labelDateIssueRights;
        private System.Windows.Forms.DateTimePicker dTP_DataCar;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tB_PhoneNumber;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelExperienceView;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_Sex;
    }
}