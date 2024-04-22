using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft
{   
    public partial class tyreselection : UserControl
    {
        
        public tyreselection()
        {
           InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            if (carbrandcombo.selectedValue.ToString() == "HONDA" && tyreconditioncombo.selectedValue.ToString() == "USED TYRES" && Seasoncombobox.selectedValue.ToString() == "SUMMER")
            {
                Heighttxt.Text = "155";
                Widthtxt.Text = "20";
                Diametertxt.Text = "R12";
            }
            else if (carbrandcombo.selectedValue.ToString() == "TOYOTA" && tyreconditioncombo.selectedValue.ToString() == "USED TYRES" && Seasoncombobox.selectedValue.ToString() == "SUMMER")
            {
                Heighttxt.Text = "175";
                Widthtxt.Text = "30";
                Diametertxt.Text = "R14";
            }
            else if (carbrandcombo.selectedValue.ToString() == "HYUNDAI" && tyreconditioncombo.selectedValue.ToString() == "USED TYRES" && Seasoncombobox.selectedValue.ToString() == "SUMMER")
            {
                Heighttxt.Text = "192";
                Widthtxt.Text = "40";
                Diametertxt.Text = "R16";
            }
            else if (carbrandcombo.selectedValue.ToString() == "HONDA" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                Heighttxt.Text = "255";
                Widthtxt.Text = "60";
                Diametertxt.Text = "R12";
               
            }
            else if (carbrandcombo.selectedValue.ToString() == "TOYOTA" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                Heighttxt.Text = "265";
                Widthtxt.Text = "70";
                Diametertxt.Text = "R14";
            }
            else if (carbrandcombo.selectedValue.ToString() == "HYUNDAI" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                Heighttxt.Text = "275";
                Widthtxt.Text = "80";
                Diametertxt.Text = "R16";
            }
        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tyreselection_Load(object sender, EventArgs e)
        {
         
        }

        private void bunifuDropdown7_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown5_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Detailsnew1 dn1 = new Detailsnew1();
            Details1 d1 = new Details1();
            Details2 d2 = new Details2();
            //Detailsnew1 dn = new Detailsnew1();
            //Controls.Add(dn);
            //dn.BringToFront();
            if(carbrandcombo.selectedValue.ToString()=="HONDA" && tyreconditioncombo.selectedValue.ToString()=="USED TYRES" && Seasoncombobox.selectedValue.ToString()=="SUMMER")
            {
                Controls.Add(dn1);
                dn1.BringToFront();
            }
            else if (carbrandcombo.selectedValue.ToString() == "TOYOTA" && tyreconditioncombo.selectedValue.ToString() == "USED TYRES" && Seasoncombobox.selectedValue.ToString() == "SUMMER")
            {
                Controls.Add(d1);
                d1.BringToFront();
            }
            else if (carbrandcombo.selectedValue.ToString() == "HYUNDAI" && tyreconditioncombo.selectedValue.ToString() == "USED TYRES" && Seasoncombobox.selectedValue.ToString() == "SUMMER")
            {
                Controls.Add(d2);
                d2.BringToFront();
            }
            else if (carbrandcombo.selectedValue.ToString() == "HONDA" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                dn1.Namelabel.Text = "255/60 R12";
                dn1.conditiontxt.Text = "New";
                dn1.seasontxt.Text = "WINTER";
                dn1.pricetxt.Text = "RS 7,000";
                Controls.Add(dn1);
                dn1.BringToFront();
            }
            else if (carbrandcombo.selectedValue.ToString() == "TOYOTA" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                d1.Namelabel.Text = "265/70 R14";
                d1.conditiontxt.Text = "New";
                d1.pricetxt.Text = "RS 10,000";
                d1.seasontxt.Text = "WINTER";
                Controls.Add(d1);
                d1.BringToFront();
            }
            else if (carbrandcombo.selectedValue.ToString() == "HYUNDAI" && tyreconditioncombo.selectedValue.ToString() == "NEW TYRES" && Seasoncombobox.selectedValue.ToString() == "WINTER")
            {
                d2.Namelabel.Text = "275/80 R16";
                d2.conditiontxt.Text = "New";
                d2.pricetxt.Text = "RS 12,000";
                d2.seasontxt.Text = "WINTER";
                Controls.Add(d2);
                d2.BringToFront();
            }
            else
            {
                MessageBox.Show("New tyres OR Old tyres which you want for your car is not available in stock","MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
       }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Introduction i1 = new Introduction();
            Controls.Add(i1);
            i1.BringToFront();
        }
    }
}
