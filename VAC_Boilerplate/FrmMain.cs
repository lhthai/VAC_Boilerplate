using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAC_Boilerplate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
