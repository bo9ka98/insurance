namespace View
{
    partial class SearchNuturalClientForm
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
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(191, 154);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 15;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(70, 160);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(191, 115);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(155, 20);
            this.textBoxMiddleName.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(191, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(191, 47);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(155, 20);
            this.textBoxSurname.TabIndex = 11;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(102, 118);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 10;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(127, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(100, 50);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Фамилия";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(401, 201);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 34);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // SearchNuturalClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 260);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Name = "SearchNuturalClientForm";
            this.Text = "SearchNuturalClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonSearch;
    }
}