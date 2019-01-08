﻿using System;
using System.Windows.Forms;
using Presenter;

namespace WindowsFormsApp1
{
    public partial class StartLoginView : Form, IStartLoginView
    {
        private readonly ApplicationContext _context;

        public event Action EnterLogin;

        public string LoginString => textBaxLogin.Text;

        public string PassString => textBoxPass.Text;

        public bool SuperuserFlag => checkBoxSuperuser.Checked;

        public StartLoginView(ApplicationContext context)
        {
            _context = context; 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSuperuser.Checked)
                MessageBox.Show("Attention!! You are trying to log in as a developer");
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            EnterLogin?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowError(string massage)
        {
            throw new NotImplementedException();
        }
    }
}
