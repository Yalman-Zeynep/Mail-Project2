using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace userRecord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZYNPYLMN\\MSSQLSERVER01;Initial Catalog=System;Integrated Security=True;TrustServerCertificate=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into users(user_name,user_surname,password)values(@user_name,@user_surname,@password)";
            SqlCommand cmd = new SqlCommand(query, baglanti); //sorgudan alinan bilgier users tablosuna kaydedilir
            cmd.Parameters.AddWithValue("@user_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@user_surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("your registration is successful");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            baglanti.Close();
            this.Close();
        }
    }
}
