using System;
using System.Windows.Forms;
using Presenter;
using Model;

namespace View
{
    public partial class CreatLegalClientFormView : Form, ICreatLegalClientView
    {
        private readonly ApplicationContext _context;

        public event Delegates.TransmitDataLegalCatV TransmitDataLegalCatV;
        public event Action EnterReturnWorkMenu;

        public CreatLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void setAliasCompanu(AliasCompanu aliasCompanu)
        {
            tB_CompanuName.Text = aliasCompanu.CompanuName;
            tB_UTN.Text = aliasCompanu.RegistrationNumber;
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
            LegalСlient legalСlient = new LegalСlient(new AliasCompanu(tB_CompanuName.Text, tB_UTN.Text),
                new AliasMan(tB_SurnameDirector.Text, tB_NameDirector.Text, tB_MiddleNameDirector.Text),
                new AliasMan(tB_SurnameAccountant.Text, tB_NameAccountant.Text, tB_MiddleNameAccountant.Text),
                tB_OrganisationAddress.Text, tB_OrganisationPhone.Text);
            TransmitDataLegalCatV?.Invoke(legalСlient);
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

        private void tB_OrganisationName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
