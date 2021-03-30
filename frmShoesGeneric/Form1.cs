using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmShoesGeneric
{
    public partial class Form1 : Form
    {
        Shoes_Item<string> si = new Shoes_Item<string>(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            si.Push(txtPrice.Text, txtID.Text, txtName.Text);
            clear();
        }

        private void clear()
        {
            txtPrice.Clear();
            txtID.Clear();
            txtName.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(si.Display());
        }
    }
}
