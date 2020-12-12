using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailLabTest2
{
    public partial class Form1 : Form
    {
        string strCPU;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            amd64MRadioButton.Checked = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
               
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you again!\nHave a nice day!");
            Application.Exit();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            float fltCost = 0;

            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Missing name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();

            }
            else if (qtyTextBox.Text == "")
            {
                MessageBox.Show("Please enter valid quantity!", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qtyTextBox.Focus();
            }

            else
            {
                if (amdDualRadioButton.Checked)
                {
                    strCPU = "AMD 64 Dualcore";
                    fltCost = 2180f;

                }
                else if (amd64MRadioButton.Checked)
                {
                    strCPU = "Athlon M 64";
                    fltCost = 1880f;
                }
                else if (amdXMRadiotButton.Checked)
                {
                    strCPU = "AMD XP-M";
                    fltCost = 1380f;
                }
                else
                {
                    strCPU = "Intel Pendium M";
                    fltCost = 1290f;
                }

                fltCost = fltCost * int.Parse(qtyTextBox.Text);

                if (eceStudCheckBox.Checked)
                {
                    fltCost = fltCost * 0.82f;
                }

                messageLabel.Visible = true;
                messageLabel.Text = nameTextBox.Text + ", please pay " + fltCost.ToString("C") + " for " + qtyTextBox.Text + " " + strCPU  + " notebook(s)" ;
            }
        }
    }
}

