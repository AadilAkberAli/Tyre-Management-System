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
    public partial class Recordpurchases : UserControl
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Recordpurchases()
        {
            InitializeComponent();
        }

        private void Recordpurchases_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                con1.Open();
                string query1 = "INSERT INTO Table2 VALUES('" + seasontxt.Text + "','" + radiustxt.Text + "')";
                SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con1);
                SDA1.SelectCommand.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Record successfully");
            
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            disp_data();
            disp_data1();
        }
        public void disp_data()
        {
            con1.Open();
            SqlCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            purchasetyregrid.DataSource = dt;
            con1.Close();
        }
        public void disp_data1()
        {
            con1.Open();
            SqlCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table4";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con1.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Hide();
        }

        private void purchasetyregrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void seasontxt_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
