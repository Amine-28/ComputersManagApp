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

namespace WindowsFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");
            
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select etat from pc where code="+textBox1.Text+"",cnn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("pc");
                dataAdp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataAdp.Update(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            textBox1.Text = "";
            textBox1.Select();
            textBox1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
                textBox1.Clear();
            }*/
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
