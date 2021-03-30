using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjGenericClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Stack_Items<String> si = new Stack_Items<string>(5);
            si.Push("Anthem");
            si.Push("Rainbow six siege");
            si.Push("Counter-Strike Global Offensive");
            si.Push("Starbound");
            si.Push("Fort nut");

            String strDisplay = si.Display();
            MessageBox.Show("The following games have been captured:\n\n"
                + strDisplay);
        }
    }
}
