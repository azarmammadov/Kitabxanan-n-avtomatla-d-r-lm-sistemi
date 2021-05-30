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
    public partial class MQK : Form
    {
        public MQK()
        {
            InitializeComponent();
        }
        

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\aztuLib.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void mbgk_Click(object sender, EventArgs e)
        {
            Mlogin panel = new Mlogin();
            panel.Show();
            this.Hide();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbqk_Click(object sender, EventArgs e)
        {

            if (adm.Text == "" && soyadm.Text == "" && istm.Text == "" && kfm.Text == "" && ixm.Text == "" && vfm.Text == "")

            {
                MessageBox.Show("Daxil etmə düzgün deyil. Zəhmət olmasa daxil etməni düzgün yazın", "XƏTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                con.Open();
                string register = "INSERT INTO mqkdb ( Ad, Soyad, Istifadeci_ad, Kafedra, Vezife, Ixtisas ) VALUES ('" + adm.Text + "','" + soyadm.Text + "','" + istm.Text + "','" + kfm.Text + "','" + vfm.Text + "','" + ixm.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                

                adm.Text = "";
                soyadm.Text = "";
                istm.Text = "";
                kfm.Text = "";
                vfm.Text = "";
                ixm.Text = "";

                MessageBox.Show("Əməliyyat uğurlu oldu", "ƏLA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form87 frm = new Form87();
                frm.Show();
                this.Hide();
            }
            
        }
    }
}
