using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıUygulama_MY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int BirinciAtSolaUzaklık, İkinciAtSolaUzaklık, UcuncuAtSolaUzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int BirinciAtGenişlik = pictureBox1.Width;
            int İkinciAtGenişlik = pictureBox2.Width;
            int UcuncuAtGenislik = pictureBox3.Width;

            int BitişNoktası = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left +5)
            {
                label6.Text = "1 Numaralı At Yarışı Önde Götürüyor.";
            }
            if(pictureBox2.Left >pictureBox1.Left +5 && pictureBox2.Left >pictureBox3.Left+5)
            {
                label6.Text= "3 Numaralı At Öne Geçti.";
            }
            if(pictureBox3.Left >pictureBox1.Left +5 && pictureBox3.Left > pictureBox2.Left +5)
            {
                label6.Text = "4 Numaralı At Birinciliği Alıcak Gibi Duruyor.";
            }


            if(BirinciAtGenişlik+pictureBox1.Left>=BitişNoktası)
            {
                timer1.Enabled = false;
                label6.Text = "1 Numaralı At Yarışı Kazandı!!!";
            }
            if(İkinciAtGenişlik+pictureBox2.Left>=BitişNoktası)
            {
                timer1.Enabled = false;
                label6.Text = "3 Numaralı At Yarışı Kazandı!!!";
            }
            if(UcuncuAtGenislik+pictureBox3.Left>=BitişNoktası)
            {
                timer1.Enabled = false;
                label6.Text = "4 Numaralı At Yarışı Kazandı!!!";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            BirinciAtSolaUzaklık = pictureBox1.Left;
            İkinciAtSolaUzaklık = pictureBox2.Left;
            UcuncuAtSolaUzaklık = pictureBox3.Left;
        }
    }
}
