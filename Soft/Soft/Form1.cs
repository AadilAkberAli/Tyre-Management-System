using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            introduction1.BringToFront();
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tyresbtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            introduction1.BringToFront();
            Dashboardbtn.Normalcolor = Color.DarkGoldenrod;
            Tyresbtn.Normalcolor = Color.Transparent;
            Tyresbtn.Textcolor = Color.White;
            rimsbtn.Normalcolor = Color.Transparent;
            rimsbtn.Textcolor = Color.White;
            checkrecord.Normalcolor = Color.Transparent;
        }

        private void rimsbtn_Click(object sender, EventArgs e)
        {
            Rimselection rs = new Rimselection();
            Controls.Add(rs);
            rs.BringToFront();
            rimsbtn.Normalcolor = Color.DarkGoldenrod;
            Dashboardbtn.Normalcolor = Color.Transparent;
            Dashboardbtn.Textcolor = Color.White;
            Tyresbtn.Normalcolor = Color.Transparent;
            Tyresbtn.Textcolor = Color.White;
            checkrecord.Normalcolor = Color.Transparent;
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        
        }

        private void picboximage_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            tyreselection1.BringToFront();
            Tyresbtn.Normalcolor = Color.DarkGoldenrod;
            Dashboardbtn.Normalcolor = Color.Transparent;
            Dashboardbtn.Textcolor = Color.White;
            rimsbtn.Normalcolor = Color.Transparent;
            rimsbtn.Textcolor = Color.White;
            checkrecord.Normalcolor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tyreselection1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void introduction1_Load(object sender, EventArgs e)
        {
           
        }

        private void tyreselection1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter 3 digits only", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lablecart_Click(object sender, EventArgs e)
        {
          
        }

        private void checkrecord_Click(object sender, EventArgs e)
        {
            checkrecord.Normalcolor = Color.DarkGoldenrod;
            Dashboardbtn.Normalcolor = Color.Transparent;
            Tyresbtn.Normalcolor = Color.Transparent;
            rimsbtn.Normalcolor = Color.Transparent;
            RecordSales rs = new RecordSales();
            Controls.Add(rs);
            rs.BringToFront();
        }

        private void receiptbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data is successfully entered", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use usercontrol of go to feedback ", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void recordSales2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
