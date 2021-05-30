using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzTU
{
    public partial class XG : Form
    {
        public XG()
        {
            InitializeComponent();
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tlogin panel = new Tlogin();
            panel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mlogin panel = new Mlogin();
            panel.Show();
            this.Hide();
        }

        private void XG_Load(object sender, EventArgs e)
        {

        }
    }
}
