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
    public partial class TQK : Form
    {
        public TQK()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\aztuLib.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void tbgk_Click(object sender, EventArgs e)
        {
            Tlogin login = new Tlogin();
            login.Show();
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

        private void tbqk_Click(object sender, EventArgs e)
        {
            if (tad.Text == "" && tsa.Text == "" && tis.Text == "" && tfa.Text == "" && tix.Text == "" && tiq.Text == "")

            {
                MessageBox.Show("Daxil etmə düzgün deyil. Zəhmət olmasa daxil etməni düzgün yazın", "XƏTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                string register = "INSERT INTO tqkdb ( Ad, Soyad, Istifadeci_ad, Fakulte, Ixtisas, Qrup ) VALUES ('" + tad.Text + "','" + tsa.Text + "','" + tis.Text + "','" + tfa.Text + "','" + tix.Text + "','" + tiq.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                tad.Text = "";
                tsa.Text = "";
                tis.Text = "";
                tfa.Text = "";
                tix.Text = "";
                tiq.Text = "";
                MessageBox.Show("Əməliyyat uğurlu oldu", "Əla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form87 frm = new Form87();
                frm.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
