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
using iTextSharp.text;
using System.IO;
using Winnovative.PdfPrint;
using System.Drawing.Printing;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            TextBox1.Select();
            TextBox1.Focus();
        }

        private void deposeUnPc1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            TextBox1.Select();
            TextBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Votre PC a été déposé");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            var Var4 = TextBox1.Text;
            var Var5 = comboBox1.SelectedItem;
            var Var6 = comboBox2.SelectedItem;
            var Var7 = dateTimePicker1.Value.ToString();
            var Var9 = textBox2.Text;

            if (Var4 == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("all fields required");
            }
            else
            {
                Random Var8 = new Random();
                int aa = Var8.Next(1, 1000);

                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");
                //Tester sur code
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from pc where code='" + aa + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                while (dt.Rows[0][0].Equals(1))
                {
                    aa = Var8.Next(1, 1000);
                }

                sql = "insert into pc (nom, ps,action,date,code,num) values('" + Var4 + "','" + Var5 + "','" + Var6 + "','" + Var7 + "','" + aa + "','"+Var9+"')";

                
                SqlDataAdapter sda1 = new SqlDataAdapter("select count(nom) from pc where nom = '"+ Var4 +"'", cnn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Pc name already exist");
                }
                else
                {
                    cnn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("You PC Code is " + aa);

                    string[] lines = { "^Q30,3", "^W50", "^H5", "^P1", "^S2", "^AD", "^C1", "^R0", "~Q+0", "^O0", "^D0", "^E12", "~R200", "^XSET,ROTATION,0", "^L", "Dy2-me-dd", "Th:m:s", "AD,10,54,1,1,0,0E,Nom PC:", "AD,10,120,1,1,0,0E,Code:", "AD,150,54,1,1,0,0E," + Var4 + "", "AD,108,122,1,1,0,0E," + aa + "", "E", "" };
                    System.IO.File.WriteAllLines(@"C:\Users\mohamed chagour\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\etiquette.txt", lines);

                    Process.Start(@"C:\Users\mohamed chagour\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\etiquette.bat");
                }

                textBox2.Clear();
                TextBox1.Clear();
                comboBox1.Refresh();
                TextBox1.Select();
            }
        }
    
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox2.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void bunifuFlatButton1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void UserControl1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
