using System;
using System.Windows.Forms;
using Presenter;
using Presenter.Views;
using Model.entity;

namespace View
{
    public partial class NewInsuranceCasesForm : Form , INewInsuranceCasesView
    {
        private readonly ApplicationContext _context;

        public event Delegates.RegistrInsuranceCases RegistrInsuranceCases;

        public NewInsuranceCasesForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void b_Registration_Click(object sender, EventArgs e)
        {
            InsuranceCases insuranceCases = new InsuranceCases(tB_insCases.Text, tB_PercentPayout.Text);
            RegistrInsuranceCases?.Invoke(insuranceCases);
        }

        public void ShowError(string massage)
        {

            l_Err.Text = massage;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
