using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string strCPU;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            amd64MRadioButton.Checked = true;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string strUpgrades = "";
            float fltCost = 0;
       
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Missing name", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                nameTextBox.Focus();
               
            }
            else if (studentNumTextBox.Text == "") 
            {
                MessageBox.Show("Please enter your student number.", "Missing Student Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentNumTextBox.Focus();
                
            }
            else
            {
                 if(amdDualRadioButton.Checked)
                {
                    strCPU="AMD 64 Dualcore";
                    fltCost=3180f;

                }
                else if (amd64MRadioButton.Checked)
                {
                    strCPU="Athlon M 64";
                    fltCost=2880f;
                }
                else if (amdXMRadiotButton.Checked)
                {
                    strCPU="AMD XP-M";
                    fltCost=2380f;
                }
                else
                {
                    strCPU="Intel Pendium M";
                    fltCost=2290f;
                }
               if (hd100GCheckBox.Checked)
               {
                   strUpgrades=strUpgrades+"\n +Upgrade to 100G HD";
                   fltCost=fltCost+50f;
               }
              if(lcd17CheckBox.Checked)
              {
                  strUpgrades=strUpgrades+"\n + Upgrade to 17\" wide LCD";
                  fltCost=fltCost+99f;
              }
              if(eceStudCheckBox.Checked)
              {
                  fltCost = fltCost * 0.80f;   
              }
              messageLabel.Visible = true;
              messageLabel.Text = nameTextBox.Text + ",please pay " + fltCost.ToString("C") + " for" + strCPU + " notebook" + strUpgrades;
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye-bye!\nHave a nice day!");
            Application.Exit();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
