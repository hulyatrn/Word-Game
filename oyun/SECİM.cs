using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class SECİM : Form
    {
        public SECİM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hayvan1 hayvan1 = new Hayvan1();
            hayvan1.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bitki1 bitki1 = new bitki1();
            bitki1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            esya1 esya1 = new esya1();
            esya1.Show();
            this.Hide();
        }
    }
}
