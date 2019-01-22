using System;
using System.Windows.Forms;
using Presenter;
using Model.entity;

namespace View
{
    public partial class VisualizeNuturalClientFormView : Form , IVisualizeNuturalClientView
    {
        private readonly ApplicationContext _context;

        public event Action EnterReturnWorkMenu;
        public event Action saveData;

        public VisualizeNuturalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void SetIndividClientData(IndividClient nuturalClient)
        {
            l_SurnameStr.Text = nuturalClient.ManAlias.Surname;
            l_NameStr.Text = nuturalClient.ManAlias.Name;
            l_MiddleNameStr.Text = nuturalClient.ManAlias.MiddleName;
            l_DateOfBirth.Text = nuturalClient.DateOfBirth.ToString();
            l_DataDriving.Text = nuturalClient.ExperienceDrivingCar.ToString();
            l_Sex.Text = nuturalClient.Sex;
            l_AddressStr.Text = nuturalClient.AddressResidence;
            l_PhoneNumberStr.Text = nuturalClient.PhoneNumber;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelBoxSurnameStr_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            saveData?.Invoke();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EnterReturnWorkMenu?.Invoke();
        }

    }
}
