using System;
using System.Windows.Forms;
using Presenter;

namespace WindowsFormsApp1
{
    public partial class WorkMenuView : Form, IWorkMenuView
    {

        private readonly ApplicationContext _context;

        public event Action EnterButton;

        public WorkMenuView(ApplicationContext context)
        {
           
            _context = context;
            InitializeComponent();
        }

        private void WorkMenu_Load(object sender, EventArgs e)
        {
            buttonIssuePolicy.Enabled = false;
            buttonStateIncident.Enabled = false;
            buttonArrangePayment.Enabled = false;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lol");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void comboBoxTipeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flag = 0;
            //MessageBox.Show(comboBoxClientTipe.Text);
            if (comboBoxClientTipe.Text == "both types" && flag != 1)
            {
                buttonIssuePolicy.Enabled = false;
                buttonStateIncident.Enabled = false;
                buttonArrangePayment.Enabled = false;
                flag = 1;

            }else if (comboBoxClientTipe.Text == "natural person" || comboBoxClientTipe.Text == "legal person" 
                && flag != 2)
            {
                buttonIssuePolicy.Enabled = true;
                buttonStateIncident.Enabled = true;
                buttonArrangePayment.Enabled = true;
                flag = 2;
            }
        }

        private void buttonArrangePayment_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("lol");
        }
    }
}
