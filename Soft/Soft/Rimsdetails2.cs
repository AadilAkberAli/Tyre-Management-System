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
    public partial class Rimsdetails2 : UserControl
    {
        Detailsnew1 d1 = new Detailsnew1();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");  
        public Rimsdetails2()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Rimselection rs = new Rimselection();
            Controls.Add(rs);
            rs.BringToFront();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (d1.count == 0)
            {
                MessageBox.Show("please enter something in cart!!", "MESSAGE");
            }
            else
            {
                Form1 f1 = new Form1();
                f1.paymentbtn.Normalcolor = Color.DarkGoldenrod;
                Payment p1 = new Payment();
                Controls.Add(p1);
                p1.BringToFront();
            }
        }

        private void addtocart_Click(object sender, EventArgs e)
        {
            d1.count++;
            con.Open();
            string query1 = "INSERT INTO Table7 VALUES('" + cartxt.Text + "','" + Namelabel.Text + "','" + rimtypetxt.Text + "','" + pricetxt.Text + "')";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your shopping has been recorded!", "MESSAGE");
        }

        private void Rimsdetails2_Load(object sender, EventArgs e)
        {

        }
    }
}
