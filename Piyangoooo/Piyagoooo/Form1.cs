using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piyagoooo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();

        string[,] tahminler = new string[6, 6];

        int[] piyango = new int[6];

        int[] sayac = new int[6];
        
        int s1, s2, s3, s4, s5, s6;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btncevir_Click(object sender, EventArgs e)
        {
            #region Piyango numaraları gizle
            //l1.Visible = false;
            //l2.Visible = false;
            //l3.Visible = false;
            //l4.Visible = false;
            //l5.Visible = false;
            //l6.Visible = false;
            #endregion
            #region 6 tane rastgele sayıları tanımladık ve değerlere atadık
            int sayi1 = rast.Next(1, 49);
            int sayi2 = rast.Next(1, 49);
            int sayi3 = rast.Next(1, 49);
            int sayi4 = rast.Next(1, 49);
            int sayi5 = rast.Next(1, 49);
            int sayi6 = rast.Next(1, 49);

           
            piyango[0] = sayi1;
            piyango[1] = sayi2;
            piyango[2] = sayi3;
            piyango[3] = sayi4;
            piyango[4] = sayi5;
            piyango[5] = sayi6;

            l1.Text = piyango[0].ToString();
            l2.Text = piyango[1].ToString();
            l3.Text = piyango[2].ToString();
            l4.Text = piyango[3].ToString();
            l5.Text = piyango[4].ToString();
            l6.Text = piyango[5].ToString();
            #endregion
            btncevir.Enabled = false;
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Her textboxs değerini diziye atadım

            tahminler[0, 0] = a1.Text;
            tahminler[0, 1] = a2.Text;
            tahminler[0, 2] = a3.Text;
            tahminler[0, 3] = a4.Text;
            tahminler[0, 4] = a5.Text;
            tahminler[0, 5] = a6.Text;

            tahminler[1, 0] = b1.Text;
            tahminler[1, 1] = b2.Text;
            tahminler[1, 2] = b3.Text;
            tahminler[1, 3] = b4.Text;
            tahminler[1, 4] = b5.Text;
            tahminler[1, 5] = b6.Text;

            tahminler[2, 0] = c1.Text;
            tahminler[2, 1] = c2.Text;
            tahminler[2, 2] = c3.Text;
            tahminler[2, 3] = c4.Text;
            tahminler[2, 4] = c5.Text;
            tahminler[2, 5] = c6.Text;

            tahminler[3, 0] = d1.Text;
            tahminler[3, 1] = d2.Text;
            tahminler[3, 2] = d3.Text;
            tahminler[3, 3] = d4.Text;
            tahminler[3, 4] = d5.Text;
            tahminler[3, 5] = d6.Text;

            tahminler[4, 0] = e1.Text;
            tahminler[4, 1] = e2.Text;
            tahminler[4, 2] = e3.Text;
            tahminler[4, 3] = e4.Text;
            tahminler[4, 4] = e5.Text;
            tahminler[4, 5] = e6.Text;

            tahminler[5, 0] = f1.Text;
            tahminler[5, 1] = f2.Text;
            tahminler[5, 2] = f3.Text;
            tahminler[5, 3] = f4.Text;
            tahminler[5, 4] = f5.Text;
            tahminler[5, 5] = f6.Text;

            #endregion
            #region Eşitse
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (tahminler[j,i]==piyango[i].ToString())
                    {
                        s1++;
                        sayac1.Text = s1.ToString();
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    if (tahminler[j, i] == piyango[i].ToString())
                    {
                        s2++;
                        sayac2.Text = s2.ToString();
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 2; j < 3; j++)
                {
                    if (tahminler[j, i] == piyango[i].ToString())
                    {
                        s3++;
                        sayac3.Text = s3.ToString();
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 3; j < 4; j++)
                {
                    if (tahminler[j, i] == piyango[i].ToString())
                    {
                        s4++;
                        sayac4.Text = s4.ToString();
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    if (tahminler[j, i] == piyango[i].ToString())
                    {
                        s5++;
                        sayac5.Text = s5.ToString();
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 5; j < 6; j++)
                {
                    if (tahminler[j, i] == piyango[i].ToString())
                    {
                        s6++;
                        sayac6.Text = s6.ToString();
                    }
                }
            }
            
            #endregion
            #region sayac dizisini değerlerine atadım
            sayac[0] = int.Parse(sayac1.Text);
            sayac[1] = int.Parse(sayac2.Text);
            sayac[2] = int.Parse(sayac3.Text);
            sayac[3] = int.Parse(sayac4.Text);
            sayac[4] = int.Parse(sayac5.Text);
            sayac[5] = int.Parse(sayac6.Text);
            #endregion
            #region sayac max değerine göre para ödülleri verdim
            if (sayac.Max() == 1)
            {
                MessageBox.Show("Tebrikler 10.000 TL Kazandınız");
            }
            else if (sayac.Max() == 2)
            {
                MessageBox.Show("Tebrikler 50.000 TL Kazandınız");
            }
            else if (sayac.Max() == 3)
            {
                MessageBox.Show("Tebrikler 100.000 TL Kazandınız");
            }
            else if (sayac.Max() == 4)
            {
                MessageBox.Show("Tebrikler 250.000 TL Kazandınız");
            }
            else if (sayac.Max() == 5)
            {
                MessageBox.Show("Tebrikler 500.000 TL Kazandınız");
            }
            else if (sayac.Max() == 6)
            {
                MessageBox.Show("Tebrikler 1.000.000 TL Kazandınız");
            }
            else
            {
                MessageBox.Show("Tebrikler 1 TL Kazandınız");
            }

            #endregion


           
            
            
        }
    }
}
