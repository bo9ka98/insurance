using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class CreatLegalClientFormView : Form, ICreatLegalClientView
    {
        private readonly ApplicationContext _context;

        public event Action EnterSearch;
        public event Action EnterReturnWorkMenu;

        public CreatLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CreatLegalClientFormView_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void groupBoxAccountantAlias_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxUTN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
