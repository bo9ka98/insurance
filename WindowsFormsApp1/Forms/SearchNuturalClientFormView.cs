using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class SearchNuturalClientFormView : Form, ISearchNuturalClientView
    {

        private readonly ApplicationContext _context;

        public string SurnameNuturalClientStr => textBoxSurname.Text;

        public string NameNuturalClientStr => textBoxName.Text;

        public string MinnleNameNuturalClientStr => textBoxMiddleName.Text;

        public SearchNuturalClientFormView(ApplicationContext context)
        {

            _context = context;
            InitializeComponent();
        }

        public event Action EnterSearch;
        public event Action EnterReturnWorkMenu;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            EnterSearch?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
