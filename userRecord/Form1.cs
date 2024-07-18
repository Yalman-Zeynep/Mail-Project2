using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace userRecord
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayi;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = rnd.Next(100000 , 999999);
            MailMessage msg = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("zynpylmnzynpylmn@outlook.com", "vcfclypdjfoalinu");
           
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            msg.To.Add(textBox1.Text);
            msg.From = new MailAddress("zynpylmnzynpylmn@outlook.com", "vcfclypdjfoalinu");
            msg.Subject = "security code";
            msg.Body = sayi.ToString();
             
            client.Send(msg);
            MessageBox.Show("The e-mail was sent successfully. Please enter the six-digit code.");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == sayi.ToString())
            {
                label3.Text = "security code verified";
                label3.ForeColor = Color.Green;
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                label3.Text = "security code not verified";
                label3.ForeColor = Color.Red;
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
