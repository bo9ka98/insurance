using System;
using System.Windows.Forms;
using Presenter;
using Model;

namespace View
{
    public partial class StartLoginView : Form, IStartLoginView
    {
        private readonly ApplicationContext _context;

        public StartLoginView(ApplicationContext context)
        {
            _context = context; 
            InitializeComponent();
        }

        public event Delegates.VerificationUser VerificationUser;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cB_Superuser.Checked)
                MessageBox.Show("Attention!! You are trying to log in as a developer");
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ControlUser controlUser = new ControlUser(tB_Login.Text, tB_Pass.Text, cB_Superuser.Checked);
            VerificationUser?.Invoke(controlUser);
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
