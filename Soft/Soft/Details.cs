using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Soft
{
    public partial class Detailsnew1 : UserControl
    {
        public int count = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Detailsnew1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Hide();
        }

        private void Tyresdescription_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void cartxt_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void available_Click(object sender, EventArgs e)
        {

        }

        private void Availabilitytxt_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void seasontxt_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void conditiontxt_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rating_onValueChanged(object sender, EventArgs e)
        {

        }

        private void pricetxt_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void addtocart_Click(object sender, EventArgs e)
        {
            count++;
            con.Open();
            string query1 = "INSERT INTO Table1 VALUES('" + cartxt.Text + "','" + Namelabel.Text + "','" + seasontxt.Text + "','" + conditiontxt.Text + "','" + pricetxt.Text + "')";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your shopping has been recorded!", "MESSAGE");
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Please enter something in cart!!", "MESSAGE");
            }
            else
            {
                Payment p1 = new Payment();
                Controls.Add(p1);
                p1.BringToFront();
            }
        }
        
    }
}
