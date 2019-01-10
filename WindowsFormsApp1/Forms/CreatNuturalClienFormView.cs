using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class CreatNuturalClienFormView : Form, ICreatNuturalClienView
    {
        private readonly ApplicationContext _context;

        public string SurnameNuturalClientStr { get => textBoxSurname.Text; set => textBoxSurname.Text = value; }
        public string NameNuturalClientStr { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string MinnleNameNuturalClientStr { get => textBoxMiddleName.Text; set => textBoxMiddleName.Text = value; }

        public event Action EnterSearch;
        public event Action EnterReturnWorkMenu;

        public CreatNuturalClienFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatNuturalClienFormView_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
