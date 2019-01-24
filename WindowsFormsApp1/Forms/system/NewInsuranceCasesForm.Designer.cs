namespace View
{
    partial class NewInsuranceCasesForm
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
            this.tB_PercentPayout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_insCases = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Registration = new System.Windows.Forms.Button();
            this.l_razmern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_PercentPayout
            // 
            this.tB_PercentPayout.Location = new System.Drawing.Point(205, 133);
            this.tB_PercentPayout.Margin = new System.Windows.Forms.Padding(2);
            this.tB_PercentPayout.Name = "tB_PercentPayout";
            this.tB_PercentPayout.Size = new System.Drawing.Size(236, 20);
            this.tB_PercentPayout.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Процент выплаты";
            // 
            // tB_insCases
            // 
            this.tB_insCases.Location = new System.Drawing.Point(205, 92);
            this.tB_insCases.Margin = new System.Windows.Forms.Padding(2);
            this.tB_insCases.Name = "tB_insCases";
            this.tB_insCases.Size = new System.Drawing.Size(264, 20);
            this.tB_insCases.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Регистрация нового страхового случая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название случая";
            // 
            // b_Registration
            // 
            this.b_Registration.Location = new System.Drawing.Point(441, 195);
            this.b_Registration.Name = "b_Registration";
            this.b_Registration.Size = new System.Drawing.Size(75, 23);
            this.b_Registration.TabIndex = 17;
            this.b_Registration.Text = "Registration";
            this.b_Registration.UseVisualStyleBackColor = true;
            this.b_Registration.Click += new System.EventHandler(this.b_Registration_Click);
            // 
            // l_razmern
            // 
            this.l_razmern.AutoSize = true;
            this.l_razmern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_razmern.Location = new System.Drawing.Point(446, 128);
            this.l_razmern.Name = "l_razmern";
            this.l_razmern.Size = new System.Drawing.Size(25, 24);
            this.l_razmern.TabIndex = 18;
            this.l_razmern.Text = "%";
            // 
            // NewInsuranceCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 236);
            this.Controls.Add(this.l_razmern);
            this.Controls.Add(this.b_Registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_PercentPayout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_insCases);
            this.Name = "NewInsuranceCasesForm";
            this.Text = "NewInsuranceCasesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_PercentPayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_insCases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Registration;
        private System.Windows.Forms.Label l_razmern;
    }
}