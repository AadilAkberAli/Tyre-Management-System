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
    public partial class Payment : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Payment()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (cardnumbertxt.Text == "" || securitycodetxt.Text == "" || locationtxt.Text == "" || Nametxt.Text == "" || addresstxt.Text == "" || citytxt.Text == "" || provincetxt.Text == "" || postaltxt.Text == "" || phonetxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Please fill all text boxes", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!emailtxt.Text.Contains("@"))
                {
                    MessageBox.Show("Please write @ in email", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query1 = "INSERT INTO Table5 VALUES('" + cardnumbertxt.Text + "','" + securitycodetxt.Text + "','" + locationtxt.Text + "','"+Nametxt.Text+"','" + addresstxt.Text + "','" + citytxt.Text + "','" + provincetxt.Text + "','" + postaltxt.Text + "','" + phonetxt.Text + "','" +emailtxt.Text+ "')";
                    SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
                    SDA1.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    if (MessageBox.Show("Your payment is done successfully!!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Invoice iv = new Invoice();
                        Controls.Add(iv);
                        iv.BringToFront();
                    }
                }
            }
          
        }
    
        private void securitycodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }

        private void postaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
