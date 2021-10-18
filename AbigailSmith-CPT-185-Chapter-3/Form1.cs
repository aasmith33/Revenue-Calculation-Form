//Abigail Smith
//CPT-185-A80S
//Chapter-3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbigailSmith_CPT_185_Chapter_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcRev_Click(object sender, EventArgs e)
        {
            try
            {
                double classA = 0.0, classB = 0.0, classC = 0.0, revA = 0.0, revB = 0.0, revC = 0.0, total = 0.0;
                classA = double.Parse(txtClassA.Text);
                classB = double.Parse(txtClassB.Text);
                classC = double.Parse(txtClassC.Text);
                revA = classA * 15.00;
                revB = classB * 12.00;
                revC = classC * 9.00;
                total = revA + revB + revC;
                txtRevA.Text = revA.ToString("C");
                txtRevB.Text = revB.ToString("C");
                txtRevC.Text = revC.ToString("C");
                txtTotal.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Blank box/boxes or invalid value/values entered");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();
            txtRevA.Clear();
            txtRevB.Clear();
            txtRevC.Clear();
            txtTotal.Clear();
            txtClassA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
