using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string Var1 = Saisie1.Text;
            string Var2 = Saisie2.Text;
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mohamed chagour\Documents\Leoni.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from admin where username='" + Var1 + "'and password='" + Var2 + "'", cnn);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                new Admin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can not open connection ! ");
            }



        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Saisie2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Saisie1_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Saisie1_Enter(object sender, EventArgs e)
        {
            if (Saisie1.Text == "Username")
            {
                Saisie1.Text = "";
                Saisie1.ForeColor = Color.Black;


            }
        }

        private void Saisie1_Leave(object sender, EventArgs e)
        {
            if (Saisie1.Text == "")
            {
                Saisie1.Text = "Username";
                Saisie1.ForeColor = Color.LightGray;

            }
        }

        private void Saisie2_Enter(object sender, EventArgs e)
        {
            if (Saisie2.Text == "Password")
            {
                Saisie2.Text = "";
                Saisie2.ForeColor = Color.Black;
                Saisie2.isPassword = true;

            }
        }

        private void Saisie2_Leave(object sender, EventArgs e)
        {

            if (Saisie2.Text == "")
            {
                Saisie2.Text = "Password";
                Saisie2.ForeColor = Color.LightGray;
                Saisie2.isPassword = false;
            }
        }

        private void Saisie1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Saisie2.Focus();
            }
        }

        private void Saisie2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click((object)sender, (EventArgs)e);
            }
        }

        private void Saisie2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        Point lastPoint;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
