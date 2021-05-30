using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AzTU
{
    public partial class Form87 : Form
    {
        public Form87()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\aztuLib.mdb");


        private void Form87_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd1 = new OleDbCommand("select Bilet_N from tqkdb where Istifadeci_ad =@parm1 ",conn);
            cmd1.Parameters.AddWithValue("@parm1", textBox1.Text);
            OleDbDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if ( reader1.Read())
            {
                label2.Text = reader1["Bilet_N"].ToString();

            }
            else
            {
                MessageBox.Show("Məlumat tapılmadı");
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XG xg = new XG();
            xg.Show();
            this.Hide();
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tlogin loginn = new Tlogin();
            loginn.Show();
            this.Hide();
        }
    }
}
