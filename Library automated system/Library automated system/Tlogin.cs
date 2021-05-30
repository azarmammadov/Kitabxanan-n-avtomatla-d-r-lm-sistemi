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
    public partial class Tlogin : Form
    {
        public Tlogin()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\aztuLib.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
            TQK tqk = new TQK();
            tqk.Show();
            this.Hide();
        }

        private void tbg_Click(object sender, EventArgs e)
        {
            XG xg = new XG();
            xg.Show();
            this.Hide();
        }

        private void tbd_Click(object sender, EventArgs e)
        {
            
            con.Open();
          
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tqkdb WHERE Istifadeci_ad=@Istifadeci_ad and Bilet_N = @Bilet_N",con);
            cmd.Parameters.AddWithValue("@Istifadeci_ad", tisl.Text );
            cmd.Parameters.AddWithValue("@Bilet_N", tidl.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new cannnn().Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("XƏTA. Məlumatlarınızı düzgün qeyd edin.", "XƏTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tisl.Text = "";
                tidl.Text = "";
                tisl.Focus();

            }
        }

        private void tidl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
