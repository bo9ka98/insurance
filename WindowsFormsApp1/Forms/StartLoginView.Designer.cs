namespace View
{
    partial class StartLoginView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_Superuser = new System.Windows.Forms.CheckBox();
            this.tB_Pass = new System.Windows.Forms.TextBox();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_Superuser);
            this.groupBox1.Controls.Add(this.tB_Pass);
            this.groupBox1.Controls.Add(this.tB_Login);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.labelLogin);
            this.groupBox1.Location = new System.Drawing.Point(266, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authorization";
            // 
            // cB_Superuser
            // 
            this.cB_Superuser.AutoSize = true;
            this.cB_Superuser.Location = new System.Drawing.Point(60, 106);
            this.cB_Superuser.Name = "cB_Superuser";
            this.cB_Superuser.Size = new System.Drawing.Size(90, 17);
            this.cB_Superuser.TabIndex = 4;
            this.cB_Superuser.Text = "administration";
            this.cB_Superuser.UseVisualStyleBackColor = true;
            this.cB_Superuser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tB_Pass
            // 
            this.tB_Pass.Location = new System.Drawing.Point(81, 70);
            this.tB_Pass.Name = "tB_Pass";
            this.tB_Pass.Size = new System.Drawing.Size(100, 20);
            this.tB_Pass.TabIndex = 3;
            this.tB_Pass.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // tB_Login
            // 
            this.tB_Login.Location = new System.Drawing.Point(81, 33);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(100, 20);
            this.tB_Login.TabIndex = 2;
            this.tB_Login.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(34, 73);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(30, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Pass";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(31, 36);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(374, 88);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(43, 17);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Hello!";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(430, 294);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // StartLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartLoginView";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.CheckBox cB_Superuser;
        private System.Windows.Forms.TextBox tB_Pass;
        private System.Windows.Forms.TextBox tB_Login;
    }
}