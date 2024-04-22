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
    public partial class Feed_Back : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PJRSJ0;Initial Catalog=Tyresdetail;Integrated Security=True");
        public Feed_Back()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();
            string query1 = "INSERT INTO Table6 VALUES('" +feedbacktxt.Text+ "')";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your feedback has been recorded successfully thank you!","MESSAGE");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Are you sure you want to close!!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Question)==DialogResult.OK)
             {
                 Application.Exit();
             }
        }

        private void Feed_Back_Load(object sender, EventArgs e)
        {

        }
    }
}
