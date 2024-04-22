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
    public partial class Customerpurchase : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Customerpurchase()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table5";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            customerdataGridView1.DataSource = dt;
            da.Fill(dt);    
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Hide();
        }

        private void Customerpurchase_Load(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
          con.Open();
          string query = "delete from Table5 where name='" + nametextBox.Text + "'";
          SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
          SDA1.SelectCommand.ExecuteNonQuery();
          con.Close();
          MessageBox.Show("Your data deleted successfully!", "MESSAGE");
        }
    }
}
