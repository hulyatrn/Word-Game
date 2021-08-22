using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Hayvan1 : Form
    {
        public Hayvan1()
        {
            InitializeComponent();
        }

        private void Hayvan1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = "DENİZ";

            Button btn = (sender as Button);//hangi buttuna tıklandığını öğreniyoruz.
            btn.BackColor = Color.White;//Tıklanan şıkkın rengini sarı yapıyoruz
            Application.DoEvents();//Thread'den dolayı donmayı önlemek için
            Thread.Sleep(400);//Sarı renk 400 milisaniye gözükcak
            if (degerlendir2())//Eğer Doğru şıksa
            {
                btn.BackColor = Color.Green;//Rengi yeşil oluyor
            }
            else
            {
                btn.BackColor = Color.Red;//Yanlışsa Kırmızı oluyor
            }

        }
        public bool degerlendir2()
        {
            //buraya nasıl değerlendirceği yazılcak eğer doğruysa true döndercek yanlışsa false
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "YUNUS";
        

            Button btn = (sender as Button);//hangi buttuna tıklandığını öğreniyoruz.
            btn.BackColor = Color.White;//Tıklanan şıkkın rengini sarı yapıyoruz
            Application.DoEvents();//Thread'den dolayı donmayı önlemek için
            Thread.Sleep(400);//Sarı renk 400 milisaniye gözükcak
            if (degerlendir())//Eğer Doğru şıksa
            {
                btn.BackColor = Color.Green;//Rengi yeşil oluyor
            }
            else
            {
                btn.BackColor = Color.Red;//Yanlışsa Kırmızı oluyor
            }

        }
        public bool degerlendir()
        {
            //buraya nasıl değerlendirceği yazılcak eğer doğruysa true döndercek yanlışsa false
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "BALIĞI";

            Button btn = (sender as Button);//hangi buttuna tıklandığını öğreniyoruz.
            btn.BackColor = Color.White;//Tıklanan şıkkın rengini sarı yapıyoruz
            Application.DoEvents();//Thread'den dolayı donmayı önlemek için
            Thread.Sleep(400);//Sarı renk 400 milisaniye gözükcak
            if (degerlendir1())//Eğer Doğru şıksa
            {
                btn.BackColor = Color.Green;//Rengi yeşil oluyor
            }
            else
            {
                btn.BackColor = Color.Red;//Yanlışsa Kırmızı oluyor
            }

        }
        public bool degerlendir1()
        {
            //buraya nasıl değerlendirceği yazılcak eğer doğruysa true döndercek yanlışsa false
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "HAYVANI";

            Button btn = (sender as Button);//hangi buttuna tıklandığını öğreniyoruz.
            btn.BackColor = Color.White;//Tıklanan şıkkın rengini sarı yapıyoruz
            Application.DoEvents();//Thread'den dolayı donmayı önlemek için
            Thread.Sleep(400);//Sarı renk 400 milisaniye gözükcak
            if (degerlendir3())//Eğer Doğru şıksa
            {
                btn.BackColor = Color.Green;//Rengi yeşil oluyor
            }
            else
            {
                btn.BackColor = Color.Red;//Yanlışsa Kırmızı oluyor
            }

        }
        public bool degerlendir3()
        {
            //buraya nasıl değerlendirceği yazılcak eğer doğruysa true döndercek yanlışsa false
            return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hayvan2 hayvan2 = new hayvan2();
            hayvan2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SECİM sECİM = new SECİM();
            sECİM.Show();
            this.Hide();
        }
    }
}
