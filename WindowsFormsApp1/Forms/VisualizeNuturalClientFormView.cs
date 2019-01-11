using System;
using System.Windows.Forms;
using Presenter;
using Model;

namespace View
{
    public partial class VisualizeNuturalClientFormView : Form , IVisualizeNuturalClientView
    {
        private readonly ApplicationContext _context;

        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataOfCreatAtVisualizeNuturalClient ViewData;

        public VisualizeNuturalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void SetManData(Man man)
        {
            l_SurnameStr.Text = man.ManAlias.Surname;
            l_NameStr.Text = man.ManAlias.Name;
            l_MiddleNameStr.Text = man.ManAlias.MiddleName;
            l_DateOfBirth.Text = man.DateOfBirth.ToString();
            l_DataDriving.Text = man.ExperienceDrivingCar.ToString();
            l_Sex.Text = man.Sex;
            l_AddressStr.Text = man.AddressResidence;
            l_PhoneNumberStr.Text = man.PhoneNumber;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelBoxSurnameStr_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void l_MiddleNameStr_Click(object sender, EventArgs e)
        {

        }

        private void l_DateOfBirth_Click(object sender, EventArgs e)
        {

        }
    }
}
