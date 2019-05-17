using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yarişma
{
    public partial class Form1 : Form
    {
        int level = 1, Doğru = 0, yanlış = 0;
        string[] sorular = { "2.Dünya Savaşı Nerenin İşgali İle Başlamıştır?", "Türkiyenin İlk Başbakanı Kimdir?", "Kiev Hangi Ülkenin Bir Şehridir?", "Aşağıdaki Ülkelerden Hangisi Amerika Kıtasında Değildir?" };
        int k = 0, l = 0, t = 0, j = 0;
        Random salla = new Random();
        string tmp;

        public Form1()
        {
         
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            k = salla.Next(j, 4);
            richTextBox1.Text = sorular[k];
            switch (k)
            {
                case 0: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Fransa";
                    button4.Text = "D=Sovyetler Birliği";

                    break;
                case 1: button1.Text = "A=Rauf Orbay";
                    button2.Text = "B=Mustafa Kemal Atatürk";
                    button3.Text = "C=İsmet İnönü";
                    button4.Text = "D=Ali Fethi Okyar";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 2: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Ukrayna";
                    button4.Text = "D=Rusya";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 3: button1.Text = "A=Peru";
                    button2.Text = "B=Portekiz";
                    button3.Text = "C=Şili";
                    button4.Text = "D=Panama";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                    

            }
                     j++;
        
        
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            k = salla.Next(j, 4);
            richTextBox1.Text = sorular[k];
            switch (k)
            {
                case 0: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Fransa";
                    button4.Text = "D=Sovyetler Birliği";

                    break;
                case 1: button1.Text = "A=Rauf Orbay";
                    button2.Text = "B=Mustafa Kemal Atatürk";
                    button3.Text = "C=İsmet İnönü";
                    button4.Text = "D=Ali Fethi Okyar";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 2: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Ukrayna";
                    button4.Text = "D=Rusya";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 3: button1.Text = "A=Peru";
                    button2.Text = "B=Portekiz";
                    button3.Text = "C=Şili";
                    button4.Text = "D=Panama";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;



            }
            j++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = salla.Next(j, 4);
            richTextBox1.Text = sorular[k];
            switch (k)
            {
                case 0: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Fransa";
                    button4.Text = "D=Sovyetler Birliği";

                    break;
                case 1: button1.Text = "A=Rauf Orbay";
                    button2.Text = "B=Mustafa Kemal Atatürk";
                    button3.Text = "C=İsmet İnönü";
                    button4.Text = "D=Ali Fethi Okyar";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 2: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Ukrayna";
                    button4.Text = "D=Rusya";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 3: button1.Text = "A=Peru";
                    button2.Text = "B=Portekiz";
                    button3.Text = "C=Şili";
                    button4.Text = "D=Panama";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;



            }
            j++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            k = salla.Next(j, 4);
            richTextBox1.Text = sorular[k];
            switch (k)
            {
                case 0: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Fransa";
                    button4.Text = "D=Sovyetler Birliği";

                    break;
                case 1: button1.Text = "A=Rauf Orbay";
                    button2.Text = "B=Mustafa Kemal Atatürk";
                    button3.Text = "C=İsmet İnönü";
                    button4.Text = "D=Ali Fethi Okyar";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 2: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Ukrayna";
                    button4.Text = "D=Rusya";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 3: button1.Text = "A=Peru";
                    button2.Text = "B=Portekiz";
                    button3.Text = "C=Şili";
                    button4.Text = "D=Panama";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;



            }
            j++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k = salla.Next(j, 4);
            richTextBox1.Text = sorular[k];
            switch (k)
            {
                case 0: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Fransa";
                    button4.Text = "D=Sovyetler Birliği";

                    break;
                case 1: button1.Text = "A=Rauf Orbay";
                    button2.Text = "B=Mustafa Kemal Atatürk";
                    button3.Text = "C=İsmet İnönü";
                    button4.Text = "D=Ali Fethi Okyar";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 2: button1.Text = "A=Polonya";
                    button2.Text = "B=Almanya";
                    button3.Text = "C=Ukrayna";
                    button4.Text = "D=Rusya";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;
                case 3: button1.Text = "A=Peru";
                    button2.Text = "B=Portekiz";
                    button3.Text = "C=Şili";
                    button4.Text = "D=Panama";
                    tmp = sorular[k];
                    sorular[k] = sorular[j];
                    sorular[j] = tmp;
                    break;



            }
            j++;
        }
    }
}
