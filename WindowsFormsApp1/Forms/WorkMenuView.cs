using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class WorkMenuView : Form, IWorkMenuView
    {

        private readonly ApplicationContext _context;

        public WorkMenuView(ApplicationContext context)
        {

            _context = context;
            InitializeComponent();
        }

        public event Action EnterButtonNext;
        public event Action EnterButtonLogOut;

        public string ClientStr => "both types";
        public string FisClientStr => "natural person";
        public string JurClientStr => "legal person";

        public string SelectionClientTipeStr => comboBoxSelectionClientTipe.Text;



        private void WorkMenu_Load(object sender, EventArgs e)
        {
            buttonIssuePolicy.Enabled = false;
            buttonStateIncident.Enabled = false;
            buttonArrangePayment.Enabled = false;
            buttonClients.Enabled = false;
            buttonPolice.Enabled = false;
            

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void comboBoxTipeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flag = 0;
            if (flag == 0)
            {
                buttonClients.Enabled = true;
                buttonPolice.Enabled = true;
            }
            if (comboBoxSelectionClientTipe.Text == ClientStr && flag != 1)
            {
                buttonIssuePolicy.Enabled = false;
                buttonStateIncident.Enabled = false;
                buttonArrangePayment.Enabled = false;
                flag = 1;

            }else if (comboBoxSelectionClientTipe.Text == FisClientStr
                || comboBoxSelectionClientTipe.Text == JurClientStr
                && flag != 2)
            {
                buttonIssuePolicy.Enabled = true;
                buttonStateIncident.Enabled = true;
                buttonArrangePayment.Enabled = true;
                flag = 2;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            EnterButtonLogOut?.Invoke();
        }

        private void buttonStateIncident_Click(object sender, EventArgs e)
        {
            EnterButtonNext?.Invoke();
        }

        private void buttonArrangePayment_Click(object sender, EventArgs e)
        {
            EnterButtonNext?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterButtonNext?.Invoke();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EnterButtonNext?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterButtonNext?.Invoke();
        }


    

      

      
    }
}
