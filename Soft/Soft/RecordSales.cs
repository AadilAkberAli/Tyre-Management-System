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
    public partial class RecordSales : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public RecordSales()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Recordpurchases rp = new Recordpurchases();
            Controls.Add(rp);
            rp.BringToFront();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            disp_data();
            disp_data1();
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
            saletyregrid.DataSource = dt;
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
            rimgrid.DataSource = dt;
            con.Close();
        }
        private void salesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RecordSales_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Customerpurchase cp = new Customerpurchase();
            Controls.Add(cp);
            cp.BringToFront();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            delete();
            delete1();
        }
        public void delete()
        {
            con.Open();
            string query = "delete from Table1 where car='" + Nametxt.Text + "'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your data deleted successfully!", "MESSAGE");
        }
        public void delete1()
        {
            con.Open();
            string query = "delete from Table7 where car='" + Nametxt.Text + "'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your data deleted successfully!", "MESSAGE");
        }
    }
}
