using System;
using System.Windows.Forms;
using Presenter;
using Model;

namespace View
{
    public partial class SearchNuturalClientFormView : Form, ISearchIndividClientView
    {

        private readonly ApplicationContext _context;

        public SearchNuturalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataIndividSatC ViewDataAliasMan;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ViewDataAliasMan?.Invoke(new AliasMan(textBoxSurname.Text, textBoxName.Text, textBoxMiddleName.Text));
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
