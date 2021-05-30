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
    public partial class Mlogin : Form
    {
        public Mlogin()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\aztuLib.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbq_Click(object sender, EventArgs e)
        {
            MQK panel = new MQK();
            panel.Show();
            this.Hide();
        }

        private void mbg_Click(object sender, EventArgs e)
        {
            XG panel = new XG();
            panel.Show();
            this.Hide();
        }

        private void mbd_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM mqkdb WHERE Istifadeci_ad=@Istifadeci_ad and Bilet_N = @Bilet_N", con);
            cmd.Parameters.AddWithValue("@Istifadeci_ad", misl.Text);
            cmd.Parameters.AddWithValue("@Bilet_N", bidml.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new cannnn().Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("XƏTA. Məlumatlarınızı düzgün qeyd edin.", "XƏTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                misl.Text = "";
                bidml.Text = "";
                misl.Focus();

            }
        }

        private void Mlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
