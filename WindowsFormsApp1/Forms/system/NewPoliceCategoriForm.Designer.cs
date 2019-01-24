namespace View
{
    partial class NewPoliceCategoriForm
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
            this.tB_policyCost = new System.Windows.Forms.TextBox();
            this.tB_policyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Info = new System.Windows.Forms.Label();
            this.b_Registration = new System.Windows.Forms.Button();
            this.l_Err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_policyCost
            // 
            this.tB_policyCost.Location = new System.Drawing.Point(209, 130);
            this.tB_policyCost.Margin = new System.Windows.Forms.Padding(2);
            this.tB_policyCost.Name = "tB_policyCost";
            this.tB_policyCost.Size = new System.Drawing.Size(264, 20);
            this.tB_policyCost.TabIndex = 13;
            this.tB_policyCost.TextChanged += new System.EventHandler(this.policyCostTextBox_TextChanged);
            // 
            // tB_policyName
            // 
            this.tB_policyName.Location = new System.Drawing.Point(209, 90);
            this.tB_policyName.Margin = new System.Windows.Forms.Padding(2);
            this.tB_policyName.Name = "tB_policyName";
            this.tB_policyName.Size = new System.Drawing.Size(264, 20);
            this.tB_policyName.TabIndex = 12;
            this.tB_policyName.TextChanged += new System.EventHandler(this.policyNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название полиса";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Макс стоимость";
            // 
            // l_Info
            // 
            this.l_Info.AutoSize = true;
            this.l_Info.Location = new System.Drawing.Point(144, 46);
            this.l_Info.Name = "l_Info";
            this.l_Info.Size = new System.Drawing.Size(205, 13);
            this.l_Info.TabIndex = 15;
            this.l_Info.Text = "Регистрация новой категории полисов";
            // 
            // b_Registration
            // 
            this.b_Registration.Location = new System.Drawing.Point(431, 187);
            this.b_Registration.Name = "b_Registration";
            this.b_Registration.Size = new System.Drawing.Size(75, 23);
            this.b_Registration.TabIndex = 16;
            this.b_Registration.Text = "Registration";
            this.b_Registration.UseVisualStyleBackColor = true;
            this.b_Registration.Click += new System.EventHandler(this.b_Registration_Click);
            // 
            // l_Err
            // 
            this.l_Err.AutoSize = true;
            this.l_Err.ForeColor = System.Drawing.Color.Red;
            this.l_Err.Location = new System.Drawing.Point(248, 164);
            this.l_Err.Name = "l_Err";
            this.l_Err.Size = new System.Drawing.Size(101, 13);
            this.l_Err.TabIndex = 17;
            this.l_Err.Text = "Место для ошибки";
            this.l_Err.Visible = false;
            // 
            // NewPoliceCategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 236);
            this.Controls.Add(this.l_Err);
            this.Controls.Add(this.b_Registration);
            this.Controls.Add(this.l_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_policyCost);
            this.Controls.Add(this.tB_policyName);
            this.Controls.Add(this.label1);
            this.Name = "NewPoliceCategoriForm";
            this.Text = "NewCategoriPoliceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_policyCost;
        private System.Windows.Forms.TextBox tB_policyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_Info;
        private System.Windows.Forms.Button b_Registration;
        private System.Windows.Forms.Label l_Err;
    }
}