using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;

namespace AzTU
{
    public partial class cannnn : Form
    {
        public static string to;
        string a = "";
         public cannnn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (string s in checkedListBox1.CheckedItems) { 
          
            listBox1.Items.Add(s);
                a = a +" "+ s+" , ";
        }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try { 
            to = (textBox1.Text).ToString();
            SmtpClient eg = new SmtpClient("smtp.gmail.com", 587);
            eg.EnableSsl = true;
            eg.Timeout = 10000000;
            eg.DeliveryMethod = SmtpDeliveryMethod.Network;
            eg.UseDefaultCredentials = false;
            eg.Credentials = new NetworkCredential("dersmay1@gmail.com", "azsxdcfvgbhnjmkl90");
            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.From = new MailAddress("dersmay1@gmail.com");
            msg.Subject = "AZƏRBAYCAN TEXNİKİ UNİVERSİTETİ ƏSAS KİTABXANA";
               
            msg.Body = a + "Kitabxanamızda var. Kitabxanamıza yaxınlaşıb götürə bilərsiniz. \nƏlaqə nömrəsi +994 00 000 00 00" ;
            eg.Send(msg);
            MessageBox.Show("Mesaj uğurla göndərildi");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cannnn_Load(object sender, EventArgs e)
        {

        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
