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
    public partial class Invoice : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Invoice()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Feed_Back fb = new Feed_Back();
            Controls.Add(fb);
            fb.BringToFront();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Hide();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Table5";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                namecustomer.Text = (dr["name"].ToString());
                invoicenumber.Text = (dr["securitycode"].ToString());
                Address.Text = (dr["streetaddress"].ToString());
                Phone.Text = (dr["phone"].ToString());
            }
            Dateofissue.Text = DateTime.Now.ToLongDateString();
            con.Close();
            disp_data();
            disp_data1();
            con.Open();
            string qurey1 = "select * from Table1";
            SqlCommand cnd = new SqlCommand(qurey1, con);
            SqlDataReader de = cnd.ExecuteReader();
            if (de.Read())
            {
                
            }

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            tyredatagrid.DataSource = dt;
            con.Close();
        }
        public void disp_data1()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table7";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rimdatagrid.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
