using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRDUSI_ABGARYAN13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new Form3();
            Form3.Show();
        }
    }
}
