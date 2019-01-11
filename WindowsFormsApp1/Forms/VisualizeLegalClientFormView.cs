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
    public partial class VisualizeLegalClientFormView : Form , IVisualizeLegalClientView
    {
        private readonly ApplicationContext _context;

        public VisualizeLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action EnterReturnWorkMenu;
    }
}
