using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest
{
    public partial class Form1 : Form
    {
        float fltDELIVERY = 7f ;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chocoButton.Checked = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            float fltCost = 0;
            float fltWeight = 0;
            string strCake = "";
            string strDelivery = "";

            if(nametextBox.Text =="")
            {
                MessageBox.Show("Please enter your name.", "Missing name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pwtextBox.Text=="")
            {
                MessageBox.Show("Please enter your password.","Missing Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (weighttextBox.Text=="")
            {
                MessageBox.Show("Please enter valid weight.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(durianButton.Checked)
                {
                    fltCost = 26f;
                    strCake = "Chocolate";
                }
                if(durianButton.Checked)
                {
                    fltCost = 30f;
                    strCake = "Durian";
                }
                if(cheesebutton.Checked)
                {
                    fltCost = 33f;
                    strCake = "Cheese";
                }

                fltWeight = float.Parse(weighttextBox.Text);
                fltCost = fltCost * fltWeight;

                if(devcheckBox.Checked)
                {
                    fltCost = fltCost + fltDELIVERY;
                    strDelivery = "with delivery";
                }
                confrimlabel.Text = nametextBox.Text + "'s order:";
                messagelabel.Text = fltWeight + "Kg" + " " + strCake + " cake" + "  " + strDelivery + "\n" + "Total cost:" + " " + fltCost.ToString("C");
                
                
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please come again,good bye!");
            Application.Exit();
        }
    }
}
