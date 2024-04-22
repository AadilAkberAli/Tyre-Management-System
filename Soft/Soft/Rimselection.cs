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
    public partial class Rimselection : UserControl
    {
        public Rimselection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Rimdetail1 r1 = new Rimdetail1();
            Rimsdetails2 r2 = new Rimsdetails2();
            Rimdetails3 r3 = new Rimdetails3();
            if(vehicalname.selectedValue.ToString()=="HONDA" && rimname.selectedValue.ToString()=="ALLOY RIMS")
            {
                Controls.Add(r1);
                r1.BringToFront();
            }
            else if (vehicalname.selectedValue.ToString() == "TOYOTA" && rimname.selectedValue.ToString() == "ALLOY RIMS")
            {
                Controls.Add(r2);
                r2.BringToFront();
            }
            else if (vehicalname.selectedValue.ToString() == "HYUNDAI" && rimname.selectedValue.ToString() == "ALLOY RIMS")
            {
                Controls.Add(r3);
                r3.BringToFront();
            }
            else if (vehicalname.selectedValue.ToString() == "HONDA" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                r1.pictureboxrim.Image = Image.FromFile(@"C:\Users\User's\Desktop\icons\steel.jpg");
                r1.rimtypetxt.Text = "Steel rims";
                r1.pricetxt.Text = "RS 6,000";
                Controls.Add(r1);
                r1.BringToFront();
            }
            else if (vehicalname.selectedValue.ToString() == "TOYOTA" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                r2.pictureboxrim.Image = Image.FromFile(@"C:\Users\User's\Desktop\icons\steel1.jpg");
                r2.rimtypetxt.Text = "Steel rims";
                r2.pricetxt.Text = "RS 7,000";
                Controls.Add(r2);
                r2.BringToFront();
            }
            else if (vehicalname.selectedValue.ToString() == "HYUNDAI" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                r3.pictureboxrim.Image = Image.FromFile(@"C:\Users\User's\Desktop\icons\steel3.jpg");
                r3.rimtypetxt.Text = "Steel rims";
                r3.pricetxt.Text = "RS 7,500";
                Controls.Add(r3);
                r3.BringToFront();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Introduction i1 = new Introduction();
            Controls.Add(i1);
            i1.BringToFront();
        }

        private void rimname_onItemSelected(object sender, EventArgs e)
        {
            if (vehicalname.selectedValue.ToString() == "HONDA" && rimname.selectedValue.ToString() == "ALLOY RIMS")
            {
                Diametertxt.Text = "R12";
            }
            else if (vehicalname.selectedValue.ToString() == "TOYOTA" && rimname.selectedValue.ToString() == "ALLOY RIMS")
            {
                Diametertxt.Text = "R14";
            }
            else if (vehicalname.selectedValue.ToString() == "HYUNDAI" && rimname.selectedValue.ToString() == "ALLOY RIMS")
            {
                Diametertxt.Text = "R16";
            }
            else if (vehicalname.selectedValue.ToString() == "HONDA" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                Diametertxt.Text = "R12";
            }
            else if (vehicalname.selectedValue.ToString() == "TOYOTA" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                Diametertxt.Text = "R14";
            }
            else if (vehicalname.selectedValue.ToString() == "HYUNDAI" && rimname.selectedValue.ToString() == "STEEL RIMS")
            {
                Diametertxt.Text = "R16";
            }
        }

        private void Rimselection_Load(object sender, EventArgs e)
        {

        }
    }
}
