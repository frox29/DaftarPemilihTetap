using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaftarPemilihTetap
{
    /// <summary>
    /// ini class Admin untuk mengelola bisnis proses pada login admin
    /// </summary>
    /// <remarks>
    /// <para>Class ini hanya menerima inputan dan mengecek inputan pada database</para>
    /// </remarks>
    class admin
    {
        /// <summary>
        /// method ini digunakan untuk memvalidasi username dan password pada saat login ke aplikasi, dengan memasukan 2 input string dan 1 form
        /// apabila data yang dimasukan kosong, maka akan keluar pesan "silahkan masukan username dan password, jika yang dimasukan salah maka akan keluar username dan password yang anda masukan salan
        /// </summary>
        /// <param name="user">tipe data string</param>
        /// <param name="pass">tipe data string</param>
        /// <param name="fm">tipe data form</param>
        /// <example>
        /// <code>
        /// admin ad = new admin();
        /// ad.login(user, pass, this);
        /// </code>
        /// </example>
        public void login(string user, string pass, Form fm)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-ASCJSSK; Initial Catalog=dpt_desa;" +
                        "User ID = sa; password=1q2w3e4r");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE username='" + user + "' AND pass='" + pass + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Home hm = new Home();
                fm.Hide();
                hm.Show();
            }
            else if (user.Equals("") && pass.Equals(""))
            {
                MessageBox.Show("Silahkan masukan username dan password!");
            }
            else
                MessageBox.Show("Username / password yang anda masukan salah");
        }
    }
}
