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

namespace DaftarPemilihTetap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txUser.Text.ToString();
            string pass = txPass.Text.ToString();

            admin ad = new admin();

            ad.login(user, pass, this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (char)13)
                    txUser.Focus();
            

        }

        private void txPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (char)13)

            btnLogin.PerformClick();


        }
    }
}
