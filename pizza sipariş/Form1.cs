using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_sipariş
{
    public partial class S : Form
    {
        public S()
        {
            InitializeComponent();
        }

        private void siparisbtn_Click(object sender, EventArgs e)
        {
            //Bir yer boş kaldıysa
            if (adtxt.Text == string.Empty)
            {
                MessageBox.Show("Adınız ve Soyadınızı giriniz");
            }
            //takılılan yer
            else if (teltxt.Text == "")
            {
                MessageBox.Show("Telefon Numaranızı giriniz");
            }
            else if (adrestxt.Text == string.Empty)
            {
                MessageBox.Show("Adresinizi giriniz");
            }
            else if (pizzaboycmb.Text == string.Empty)
            {
                MessageBox.Show("Pizzanızın boyutunu seçiniz");
            }

            else if (pizzanmr.Value == 0)
            {
                MessageBox.Show("Pizza adetini giriniz");
            }
            else if (icecekcmb.Text != string.Empty)
            {
                if (iceceknmr.Value == 0)
                {
                    MessageBox.Show("İçecek adetini giriniz");
                }
                else
                {
                    //ücretler
                    double ucret = 0;
                    string ekstra = "";
                    if (sucukchk.Checked == true)
                    {
                        ekstra += "sucuk";
                        ucret = 5;
                    }
                    else if (sosischk.Checked == true)
                    {
                        ekstra += "" + "sosis";
                        ucret = 5;
                    }
                    else if (zeytinchk.Checked == true)
                    {
                        ekstra += "" + "zeytin";
                        ucret = 5;
                    }
                    else if (mantarchk.Checked == true)
                    {
                        ekstra += "" + "mantar";
                        ucret = 5;
                    }
                    else if (peynirchk.Checked == true)
                    {
                        ekstra += "" + "peynir";
                        ucret = 5;
                    }
                    else if (etchk.Checked == true)
                    {
                        ekstra += "" + "et";
                        ucret = 10;
                    }
                    //pizza boy
                    if (pizzaboycmb.Text == "küçük")
                    {
                        //hata yaşandı
                        ucret += (double)pizzanmr.Value * 70;
                    }
                    else if (pizzaboycmb.Text == "orta")
                    {
                        ucret += (double)pizzanmr.Value * 125;
                    }
                    else if (pizzaboycmb.Text == "büyük")
                    {
                        ucret += (double)pizzanmr.Value * 175;
                    }
                    //içecekler
                    if (icecekcmb.Text == "2,5 lt Kola")
                    {
                        ucret += (double)iceceknmr.Value * 40;
                    }
                    else if (icecekcmb.Text == "1 lt İce Tea")
                    {
                        ucret += (double)iceceknmr.Value * 35;
                    }
                    else if (icecekcmb.Text == "1 lt Sprite")
                    {
                        ucret += (double)iceceknmr.Value * 35;
                    }

                    //ad soyad list
                    adsoyadlist.Items.Add(adtxt.Text);
                    telefonlist.Items.Add(teltxt.Text);
                    adreslist.Items.Add(adrestxt.Text);
                    pizzaboylist.Items.Add("Adet " + pizzanmr.Value + "Boyut " + pizzaboycmb.Text);
                    Ekstralist.Items.Add(ekstra);
                    iceceklist.Items.Add("İçecek " + icecekcmb.Text + "Adet " + iceceknmr.Value);
                    ucretlist.Items.Add(ucret + "TL");
                }
            }
            else
            {
                //ücretler
                double ucret = 0;
                string ekstra = "";
                if (sucukchk.Checked == true)
                {
                    ekstra += "sucuk";
                    ucret = 5;
                }
                else if (sosischk.Checked == true)
                {
                    ekstra += "" + "sosis";
                    ucret = 5;
                }
                else if (zeytinchk.Checked == true)
                {
                    ekstra += "" + "zeytin";
                    ucret = 5;
                }
                else if (mantarchk.Checked == true)
                {
                    ekstra += "" + "mantar";
                    ucret = 5;
                }
                else if (peynirchk.Checked == true)
                {
                    ekstra += "" + "peynir";
                    ucret = 5;
                }
                else if (etchk.Checked == true)
                {
                    ekstra += "" + "et";
                    ucret = 10;
                }
                //pizza boy
                if (pizzaboycmb.Text == "küçük")
                {
                    //hata yaşandı
                    ucret += (double)pizzanmr.Value * 70;
                }
                else if (pizzaboycmb.Text == "orta")
                {
                    ucret += (double)pizzanmr.Value * 125;
                }
                else if (pizzaboycmb.Text == "büyük")
                {
                    ucret += (double)pizzanmr.Value * 175;
                }
                //içecekler
                if (icecekcmb.Text == "2,5 lt Kola")
                {
                    ucret += (double)iceceknmr.Value * 40;
                }
                else if (icecekcmb.Text == "1 lt İce Tea")
                {
                    ucret += (double)iceceknmr.Value * 35;
                }
                else if (icecekcmb.Text == "1 lt Sprite")
                {
                    ucret += (double)iceceknmr.Value * 35;
                }

                //ad soyad list
                adsoyadlist.Items.Add(adtxt.Text);
                telefonlist.Items.Add(teltxt.Text);
                adreslist.Items.Add(adrestxt.Text);
                pizzaboylist.Items.Add("Adet " + pizzanmr.Value + "Boyut " + pizzaboycmb.Text);
                Ekstralist.Items.Add(ekstra);
                iceceklist.Items.Add("İçecek " + icecekcmb.Text + "Adet " + iceceknmr.Value);
                ucretlist.Items.Add(ucret + "TL");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pizzaboy = { "küçük", "orta", "büyük" };
            foreach (string pizza in pizzaboy)
            {
                pizzaboycmb.Items.Add(pizza);
            }
            string[] icecekler = { "2,5 lt Kola", "1 lt İce Tea", "1 lt Sprite" };
            foreach  (string icecek in icecekler)
            {
                icecekcmb.Items.Add(icecek);
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            adtxt.Text = string.Empty;
            teltxt.Text = string.Empty;
            adrestxt.Text = string.Empty;
            
            pizzaboycmb.Text = string.Empty;
            icecekcmb.Text = string.Empty;
            
            pizzanmr.Value = 0;
            iceceknmr.Value = 0;

            sucukchk.Checked = false;
            sosischk.Checked = false;
            zeytinchk.Checked = false;
            mantarchk.Checked = false;
            peynirchk.Checked = false;
            etchk.Checked = false;

        }

        private void siparistmzlbtn_Click(object sender, EventArgs e)
        {
            adsoyadlist.Items.Clear();
            telefonlist.Items.Clear();
            adsoyadlist.Items.Clear();
            pizzaboylist.Items.Clear();
            Ekstralist.Items.Clear();
            iceceklist.Items.Clear();
            ucretlist.Items.Clear();
            adreslist.Items.Clear();
        }
    }
}
