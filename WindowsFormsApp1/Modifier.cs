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
    public partial class Modifier : UserControl
    {
        public Modifier()
        {
            InitializeComponent();
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            var label4 = new Label();
            label4.Show();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var Var4 = textBox1.Text;
            var Var5 = textBox2.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
           
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");
            
            sql = "Update pc SET etat='"+ Var5 + "' where nom='" + Var4 + "' ";
            
            cnn.Open();
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("done");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Select();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
