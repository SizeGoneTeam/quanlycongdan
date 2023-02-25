using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week2;

namespace QuanLyCongDan
{
    public partial class FMemu : Form
    {
        public FMemu()
        {
            InitializeComponent();
        }

        private void btnCongDan_Click(object sender, EventArgs e)
        {
            FCongDan fCongDan = new FCongDan();
            fCongDan.Show();
        }
    }
}
