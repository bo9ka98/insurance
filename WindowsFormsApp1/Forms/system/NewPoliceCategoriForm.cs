using System;
using System.Windows.Forms;
using Model;
using Presenter;
using Model.entity;

namespace View
{
    public partial class NewPoliceCategoriForm : Form , INewPoliceCategoriView
    {
        private readonly ApplicationContext _context;

        public event Delegates.RegistrPoliceCategori RegistrPoliceCategori;

        public NewPoliceCategoriForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }
        
        private void b_Registration_Click(object sender, EventArgs e)
        {
            PoliceCategori policeCategori = new PoliceCategori(tB_policyName.Text, tB_policyCost.Text);
            RegistrPoliceCategori?.Invoke(policeCategori);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void policyCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void policyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
