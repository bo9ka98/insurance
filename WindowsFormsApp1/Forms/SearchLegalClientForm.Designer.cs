namespace View
{
    partial class SearchLegalClientForm
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
            this.labelUTN = new System.Windows.Forms.Label();
            this.labelOrganisationName = new System.Windows.Forms.Label();
            this.TextBoxUTN = new System.Windows.Forms.TextBox();
            this.TextBoxOrganisationName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUTN
            // 
            this.labelUTN.AutoSize = true;
            this.labelUTN.Location = new System.Drawing.Point(150, 88);
            this.labelUTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUTN.Name = "labelUTN";
            this.labelUTN.Size = new System.Drawing.Size(31, 13);
            this.labelUTN.TabIndex = 23;
            this.labelUTN.Text = "УНН";
            // 
            // labelOrganisationName
            // 
            this.labelOrganisationName.AutoSize = true;
            this.labelOrganisationName.Location = new System.Drawing.Point(56, 50);
            this.labelOrganisationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganisationName.Name = "labelOrganisationName";
            this.labelOrganisationName.Size = new System.Drawing.Size(125, 13);
            this.labelOrganisationName.TabIndex = 22;
            this.labelOrganisationName.Text = "Название организации";
            // 
            // TextBoxUTN
            // 
            this.TextBoxUTN.Location = new System.Drawing.Point(186, 88);
            this.TextBoxUTN.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUTN.Name = "TextBoxUTN";
            this.TextBoxUTN.Size = new System.Drawing.Size(283, 20);
            this.TextBoxUTN.TabIndex = 21;
            // 
            // TextBoxOrganisationName
            // 
            this.TextBoxOrganisationName.Location = new System.Drawing.Point(186, 47);
            this.TextBoxOrganisationName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxOrganisationName.Name = "TextBoxOrganisationName";
            this.TextBoxOrganisationName.Size = new System.Drawing.Size(283, 20);
            this.TextBoxOrganisationName.TabIndex = 20;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(407, 146);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 34);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // SearchLegalClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 211);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelUTN);
            this.Controls.Add(this.labelOrganisationName);
            this.Controls.Add(this.TextBoxUTN);
            this.Controls.Add(this.TextBoxOrganisationName);
            this.Name = "SearchLegalClientForm";
            this.Text = "SearchLegalClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUTN;
        private System.Windows.Forms.Label labelOrganisationName;
        private System.Windows.Forms.TextBox TextBoxUTN;
        private System.Windows.Forms.TextBox TextBoxOrganisationName;
        private System.Windows.Forms.Button buttonSearch;
    }
}