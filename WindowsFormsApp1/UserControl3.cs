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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");
            var Var55 = TextBox1.Text;
            var Var66 = comboBox1.SelectedItem;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from pc where "+Var66+"='"+Var55+"' ", cnn);
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from pc  ", cnn);
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

            comboBox1.Select();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuImageButton3_Click((object)sender, (EventArgs)e);
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            comboBox1.Select();
        }
    }
}
