using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class SearchNuturalClientFormView : Form, ISearchNuturalClientView
    {

        private readonly ApplicationContext _context;

        public SearchNuturalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataOfSearchAtCreatNuturalClient TransmitDataOfSearchAtCreatNuturalClient;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TransmitDataOfSearchAtCreatNuturalClient?.Invoke(textBoxSurname.Text, textBoxName.Text, textBoxMiddleName.Text);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
