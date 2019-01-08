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

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
