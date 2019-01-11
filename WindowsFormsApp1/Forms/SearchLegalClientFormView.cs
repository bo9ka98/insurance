using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class SearchLegalClientFormView : Form, ISearchLegalClientView
    {
        private readonly ApplicationContext _context;

        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataOfSearchAtCreatLegalClient TransmitDataOfSearchAtCreatLegalClient;

        public SearchLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TransmitDataOfSearchAtCreatLegalClient?.Invoke(TextBoxOrganisationName.Text, TextBoxUTN.Text);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
