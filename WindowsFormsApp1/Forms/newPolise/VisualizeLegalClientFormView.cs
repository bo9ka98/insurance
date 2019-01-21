using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class VisualizeLegalClientFormView : Form , IVisualizeLegalClientView
    {
        private readonly ApplicationContext _context;

        public VisualizeLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action EnterReturnWorkMenu;

        public void SetLegalClientData(LegalСlient legalClient)
        {
            l_OrganisationNameStr.Text = legalClient.CompanuAlias.CompanuName;
            l_UTNStr.Text = legalClient.CompanuAlias.RegistrationNumber;
            l_SurnameDirectorStr.Text = legalClient.DirectorAlias.Surname;
            l_NameDirectorStr.Text = legalClient.DirectorAlias.Name;
            l_MiddleNameDirectorStr.Text = legalClient.DirectorAlias.MiddleName;
            l_SurnameAccountantStr.Text = legalClient.AccountantAlias.Surname;
            l_NameAccountantStr.Text = legalClient.AccountantAlias.Name;
            l_MiddleNameAccountantStr.Text = legalClient.AccountantAlias.MiddleName;
            l_OrganisationAddressStr.Text = legalClient.AddressResidence;
            l_OrganisationPhoneStr.Text = legalClient.PhoneNumber;
        }

        private void labelOrganisationNameStr_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

        }

        private void VisualizeLegalClientFormView_Load(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
