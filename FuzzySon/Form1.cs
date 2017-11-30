using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzySon
{
    public partial class Form1 : Form
    {
        double payda=0;
        double toplam = 0;
        double sicaklikdegeri, seviyedegeri;
        double cokdusuksicaklikuyelikderecesi, dusuksicaklikuyelikderecesi, ortasicaklikuyelikderecesi, yukseksicaklikuyelikderecesi, cokyukseksicaklikuyelikderecesi;
        double cokdusukseviyeuyelikderecesi, dusukseviyeuyelikderecesi, ortaseviyeuyelikderecesi, yuksekseviyeuyelikderecesi, cokyuksekseviyeuyelikderecesi;



        string k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20;
        double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, x8 = 0, x9 = 0, x10 = 0, x11 = 0, x12 = 0, x13 = 0, x14 = 0, x15 = 0, x16 = 0, x17 = 0, x18 = 0, x19 = 0, x20 = 0, x21 = 0, x22 = 0, x23 = 0, x24 = 0, x25 = 0;
        double dk1 = 0, dk2 = 0, dk3 = 0, dk4 = 0, dk5 = 0, dk6 = 0, dk7 = 0, dk8 = 0, dk9 = 0, dk10 = 0, dk11 = 0, dk12 = 0, dk13 = 0, dk14 = 0, dk15 = 0, dk16 = 0, dk17 = 0, dk18 = 0, dk19 = 0, dk20 = 0, dk21 = 0, dk22 = 0, dk23 = 0, dk24 = 0, dk25 = 0;
       


        double durulastırma1, durulastırma2, durulastırma3, durulastırma4, durulastırma5,
            durulastırma6, durulastırma7, durulastırma8, durulastırma9, durulastırma10, durulastırma11, durulastırma12, durulastırma13,
            durulastırma14, durulastırma15, durulastırma16, durulastırma17, durulastırma18, durulastırma19, durulastırma20, durulastırma21,
            durulastırma22, durulastırma23, durulastırma24, durulastırma25;

        double enBuyukSayicokdusuk, enBuyukSayidusuk, enBuyukSayiorta, enBuyukSayiyuksek, enBuyukSayicokyuksek;
        double enBuyukSayicokdusukpayda, enBuyukSayidusukpayda, enBuyukSayiortapayda, enBuyukSayiyuksekpayda, enBuyukSayicokyuksekpayda;


        public Form1()
        {
            InitializeComponent();
        }

        private void bGirisDegerleri_Click(object sender, EventArgs e)
        {
           
            
            txtUygulananKural.Items.Clear();
            if (sicaklikDeger.Text == "" & seviyeDeger.Text == "")
            {
                bKural.Enabled = false;
            }
            txtUygulananKural.Items.Clear();
            temizle();
            toplam = 0;
            payda = 0;
            durulastırma1 = 0; durulastırma2 = 0; durulastırma3 = 0; durulastırma4 = 0; ; durulastırma5 = 0;
            durulastırma6 = 0; durulastırma7 = 0; durulastırma8 = 0; durulastırma9 = 0; ; durulastırma10 = 0; durulastırma11 = 0; durulastırma12 = 0; durulastırma13 = 0;
            durulastırma14 = 0; durulastırma15 = 0; durulastırma16 = 0; durulastırma17 = 0; durulastırma18 = 0; durulastırma19 = 0; durulastırma20 = 0; durulastırma21 = 0;
            durulastırma22 = 0; durulastırma23 = 0; durulastırma24 = 0; durulastırma25 = 0;
            enBuyukSayicokdusukpayda = 0; enBuyukSayidusukpayda = 0; enBuyukSayiortapayda = 0; enBuyukSayiyuksekpayda = 0; enBuyukSayicokyuksekpayda = 0;
            

           
            txtCikisDegerleri.Text = "";
           
            
      
            if (sicaklikDeger.Text != "" & seviyeDeger.Text != "")
            {
                bKural.Enabled = true;

                sicaklikdegeri = Convert.ToDouble(sicaklikDeger.Text);
                sicaklikgirisi();

                seviyedegeri = Convert.ToDouble(seviyeDeger.Text);
                seviyegirisi();
            }
            else
            {
                MessageBox.Show("Boş Geçilemez");
            }
        }

        public void sicaklikgirisi()
        {
            bKural.Enabled = true;

            if (0 <= sicaklikdegeri & sicaklikdegeri <= 20)
            {


                if (sicaklikdegeri <= 10 & sicaklikdegeri >= 0)
                {
                    cokdusuksicaklikuyelikderecesi = 1;
                }
                if (sicaklikdegeri <= 20 & sicaklikdegeri >= 10)
                {
                    cokdusuksicaklikuyelikderecesi = (20 - sicaklikdegeri) / 10;
                }
                if (sicaklikdegeri > 20)
                {
                    cokdusuksicaklikuyelikderecesi = 0;
                }
                cokDusukSicaklikUyelikDegeri.Text = cokdusuksicaklikuyelikderecesi.ToString();
              

            }




            if (15 <= sicaklikdegeri & sicaklikdegeri <= 40)
            {
                bKural.Enabled = true;
                if (sicaklikdegeri < 15 || sicaklikdegeri > 40)
                {
                    dusuksicaklikuyelikderecesi = 0;
                }
                if (15 < sicaklikdegeri & sicaklikdegeri <= 27.5)
                {
                    dusuksicaklikuyelikderecesi = (sicaklikdegeri - 15) / 12.5;
                }
                if (27.5 < sicaklikdegeri & sicaklikdegeri <= 40)
                {
                    dusuksicaklikuyelikderecesi = (40 - sicaklikdegeri) / 12.5;
                }
                dusukSicaklikUyelikDegeri.Text = dusuksicaklikuyelikderecesi.ToString();
              

            }

            bKural.Enabled = true;
            if (35 <= sicaklikdegeri & sicaklikdegeri <= 60)
            {
                if (sicaklikdegeri < 35 || sicaklikdegeri > 60)
                {
                    ortasicaklikuyelikderecesi = 0;
                }
                if (35 < sicaklikdegeri & sicaklikdegeri <= 47.5)
                {
                    ortasicaklikuyelikderecesi = (sicaklikdegeri - 35) / 12.5;
                }
                if (47.5 < sicaklikdegeri & sicaklikdegeri <= 60)
                {
                    ortasicaklikuyelikderecesi = (60 - sicaklikdegeri) / 12.5;
                }
                ortaSicaklikUyelikDegeri.Text = ortasicaklikuyelikderecesi.ToString();
                

            }
            if (55 <= sicaklikdegeri & sicaklikdegeri <= 80)
            {
                bKural.Enabled = true;
                if (sicaklikdegeri < 55 || sicaklikdegeri > 80)
                {
                    yukseksicaklikuyelikderecesi = 0;
                }
                if (55 < sicaklikdegeri & sicaklikdegeri <= 67.5)
                {
                    yukseksicaklikuyelikderecesi = (sicaklikdegeri - 55) / 12.5;
                }
                if (67.5 < sicaklikdegeri & sicaklikdegeri <= 80)
                {
                    yukseksicaklikuyelikderecesi = (80 - sicaklikdegeri) / 12.5;
                }
                yuksekSicaklikUyelikDegeri.Text = yukseksicaklikuyelikderecesi.ToString();
                
            }

            if (75 <= sicaklikdegeri & sicaklikdegeri <= 100)
            {
                bKural.Enabled = true;

                if (sicaklikdegeri < 75 || sicaklikdegeri > 100)
                {
                    cokyukseksicaklikuyelikderecesi = 0;
                }
                if (75 < sicaklikdegeri & sicaklikdegeri <= 87.5)
                {
                    cokyukseksicaklikuyelikderecesi = (sicaklikdegeri - 75) / 12.5;
                }
                if (87.5 < sicaklikdegeri & sicaklikdegeri <= 100)
                {
                    cokyukseksicaklikuyelikderecesi = (100 - sicaklikdegeri) / 12.5;
                }
                cokYuksekSicaklikUyelikDegeri.Text = yukseksicaklikuyelikderecesi.ToString();
              
            }

        }

        public void seviyegirisi()
        {
            bKural.Enabled = true;

            if (0 <= seviyedegeri & seviyedegeri <= 1)
            {

                if (seviyedegeri <= 0.5 & seviyedegeri >= 0)
                {
                    cokdusukseviyeuyelikderecesi = 1;
                }
                if (seviyedegeri <= 1 & seviyedegeri >= 0.5)
                {
                    cokdusukseviyeuyelikderecesi = (1 - seviyedegeri) / 0.5;
                }
                if (seviyedegeri > 1)
                {
                    cokdusukseviyeuyelikderecesi = 0;
                }
                cokDusukSeviyeUyelikDegeri.Text = cokdusukseviyeuyelikderecesi.ToString();
               

                //   x1 = x1 + 1 - (cokdusukseviyeuyelikderecesi * 0.5);
                // x1 = x1 + 0 + (cokdusukseviyeuyelikderecesi * 0.5);

            }




            if (0.5 <= seviyedegeri & seviyedegeri <= 2)
            {
                bKural.Enabled = true;

                if (seviyedegeri < 0.5 || seviyedegeri > 2)
                {
                    dusukseviyeuyelikderecesi = 0;
                }
                if ((0.5 <= seviyedegeri) & (seviyedegeri <= 1.25))
                {
                    dusukseviyeuyelikderecesi = (seviyedegeri - 0.5) / 0.75;
                }
                if ((1.25 < seviyedegeri) & (seviyedegeri <= 2))
                {
                    dusukseviyeuyelikderecesi = (2 - seviyedegeri) / 0.75;
                }
                dusukSeviyeUyelikDegeri.Text = dusukseviyeuyelikderecesi.ToString();
               
                //   x2 = x2 + 2 - (dusukseviyeuyelikderecesi * 0.75);
                // x2 = x2 + 0.5 - (dusukseviyeuyelikderecesi * 0.75);


            }
            bKural.Enabled = true;

            if (1.5 <= seviyedegeri & seviyedegeri <= 3.5)
            {
                if (seviyedegeri < 1.5 || seviyedegeri > 3.5)
                {
                    ortaseviyeuyelikderecesi = 0;
                }
                if (1.5 < seviyedegeri & seviyedegeri <= 2.5)
                {
                    ortaseviyeuyelikderecesi = (seviyedegeri - 1.5) / 1;
                }
                if (2.5 < seviyedegeri & seviyedegeri <= 3.5)
                {
                    ortaseviyeuyelikderecesi = (3.5 - seviyedegeri) / 1;
                }
                ortaSeviyeUyelikDegeri.Text = ortaseviyeuyelikderecesi.ToString();
                

                //  x3 = x3 + 1.5 - (ortaseviyeuyelikderecesi * 1);
                // x3 = x3 + 3.5 - (ortaseviyeuyelikderecesi * 1);




            }
            if (3 <= seviyedegeri & seviyedegeri <= 4.5)
            {
                bKural.Enabled = true;
                if (seviyedegeri < 3 || seviyedegeri > 4.5)
                {
                    yuksekseviyeuyelikderecesi = 0;
                }
                if (3 < seviyedegeri & seviyedegeri <= 3.75)
                {
                    yuksekseviyeuyelikderecesi = (seviyedegeri - 3) / 0.75;
                }
                if (3.75 < seviyedegeri & seviyedegeri <= 4.5)
                {
                    yuksekseviyeuyelikderecesi = (4.5 - seviyedegeri) / 0.75;
                }
                yuksekSeviyeUyelikDegeri.Text = yuksekseviyeuyelikderecesi.ToString();
               

            }
            bKural.Enabled = true;
            if (4 <= seviyedegeri & seviyedegeri <= 5)
            {
                if (seviyedegeri < 4 || seviyedegeri > 5)
                {
                    cokyuksekseviyeuyelikderecesi = 0;
                }
                if (4 < seviyedegeri & seviyedegeri < 4.5)
                {
                    cokyuksekseviyeuyelikderecesi = (seviyedegeri - 4) / 0.5;
                }
                if (4.5 < seviyedegeri & seviyedegeri <= 5)
                {
                    cokyuksekseviyeuyelikderecesi = (5 - seviyedegeri) / 0.5;
                }
                cokYuksekSeviyeUyelikDegeri.Text = cokyuksekseviyeuyelikderecesi.ToString();
               

                //   x5 = x5 + 4 - (yuksekseviyeuyelikderecesi * 0.5);
                //  x5 = x5 + 5 - (yuksekseviyeuyelikderecesi * 0.5);


            }

        }

       

        private void bKural_Click(object sender, EventArgs e)
        {
            bCikisDegerleri.Enabled = true;
            txtUygulananKural.Items.Clear();

           
            if (cokDusukSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(cokDusukSicaklikUyelikDegeri.Text) < double.Parse(cokDusukSeviyeUyelikDegeri.Text))
                {
                    k1 = cokDusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k1 = cokDusukSeviyeUyelikDegeri.Text;
                }
                txtUygulananKural.Items.Add("EGER SICAKLIK " + "COK DUSUK" + "(" + cokDusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK DUSUK" + "(" + cokDusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ORTA OLUR.(" + k1 + ")");


                dk1 = Double.Parse(k1);
                x1 = x1 + 1 - (dk1 * 0.5);
                x1 = x1 + 0 + (dk1 * 0.5);
                durulastırma1 = x1 * dk1;
              
            }



            if (cokDusukSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {


                if (double.Parse(cokDusukSicaklikUyelikDegeri.Text) < double.Parse(dusukSeviyeUyelikDegeri.Text))
                {
                    k2 = cokDusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k2 = dusukSeviyeUyelikDegeri.Text;
                }
                txtUygulananKural.Items.Add("EGER SICAKLIK " + "COK DUSUK" + "(" + cokDusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "DUSUK" + "(" + dusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k2 + ")");

                dk2 = Double.Parse(k2);
                x2 = x2 + 4.5 - (dk2 * 0.75);
                x2 = x2 + 3 + (dk2 * 0.75);
                durulastırma2 = x2 * dk2;
               
            }




            if (cokDusukSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {
                if (double.Parse(cokDusukSicaklikUyelikDegeri.Text) < double.Parse(ortaSeviyeUyelikDegeri.Text))
                {
                    k3 = cokDusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k3 = ortaSeviyeUyelikDegeri.Text;
                }

                txtUygulananKural.Items.Add("EGER SICAKLIK " + "COK DUSUK" + "(" + cokDusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "ORTA" + "(" + ortaSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ASIRI COK OLUR.(" + k3 + ")");

                dk3 = Double.Parse(k3);

                x3 = x3 + 4 + (dk3 * 0.5);
                durulastırma3 = x3 * dk3;
               
            }



            if (cokDusukSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(cokDusukSicaklikUyelikDegeri.Text) < double.Parse(yuksekSeviyeUyelikDegeri.Text))
                {
                    k4 = cokDusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k4 = yuksekSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "COK DUSUK" + "(" + cokDusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "YUKSEK" + "(" + yuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ AŞIRI COK OLUR.(" + k4 + ")");

                dk4 = Double.Parse(k4);

                x4 = x4 + 4 + (dk4 * 0.5);
                durulastırma4 = x4 * dk4;
                
            }





            if (cokDusukSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(cokDusukSicaklikUyelikDegeri.Text) < double.Parse(cokYuksekSeviyeUyelikDegeri.Text))
                {
                    k5 = cokDusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k5 = cokYuksekSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "COK DUSUK" + "(" + cokDusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK YUKSEK" + "(" + cokYuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ASIRI COK OLUR.(" + k5 + ")");
                dk5 = Double.Parse(k5);
                x5 = x5 + 4 + (x5 * 0.5);
                durulastırma5 = x5 * dk5;
               
            }




            if (dusukSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(dusukSicaklikUyelikDegeri.Text) < double.Parse(cokDusukSeviyeUyelikDegeri.Text))
                {
                    k6 = dusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k6 = cokDusukSeviyeUyelikDegeri.Text;
                }



                txtUygulananKural.Items.Add("EGER SICAKLIK " + "DUSUK" + "(" + dusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK DUSUK" + "(" + cokDusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ AZ OLUR.(" + k6 + ")");
                dk6 = Double.Parse(k6);
                x6 = x6 + 2 - (dk6 * 0.75);
                x6 = x6 + 0.5 + (dk6 * 0.75);
                durulastırma6 = x6 * dk6;
              
            }





            if (dusukSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(dusukSicaklikUyelikDegeri.Text) < double.Parse(dusukSeviyeUyelikDegeri.Text))
                {
                    k7 = dusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k7 = dusukSeviyeUyelikDegeri.Text;
                }

                txtUygulananKural.Items.Add("EGER SICAKLIK " + "DUSUK" + "(" + dusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "DUSUK" + "(" + dusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ORTA OLUR.(" + k7 + ")");
                dk7 = Double.Parse(k7);
                x7 = x7 + 3.5 - (dk7 * 1);
                x7 = x7 + 1.5 + (dk7 * 1);
                durulastırma7 = x7 * dk7;
               
            }




            if (dusukSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {
                if (double.Parse(dusukSicaklikUyelikDegeri.Text) < double.Parse(ortaSeviyeUyelikDegeri.Text))
                {
                    k8 = dusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k8 = ortaSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "DUSUK" + "(" + dusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "ORTA" + "(" + ortaSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k8 + ")");
                dk8 = Double.Parse(k8);
                x8 = x8 + 4.5 - (dk8 * 0.75);
                x8 = x8 + 3 + (dk8 * 0.75);
                durulastırma8 = x8 * dk8;
            
            }



            if (dusukSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(dusukSicaklikUyelikDegeri.Text) < double.Parse(yuksekSeviyeUyelikDegeri.Text))
                {
                    k9 = dusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k9 = yuksekSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "DUSUK" + "(" + dusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "YUKSEK" + "(" + yuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k9 + ")");
                double dk9 = Double.Parse(k9);
                x9 = x9 + 4.5 - (dk9 * 0.75);
                x9 = x9 + 3 + (dk9 * 0.75);
                durulastırma9 = x9 * dk9;
               
            }






            if (dusukSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(dusukSicaklikUyelikDegeri.Text) < double.Parse(cokYuksekSeviyeUyelikDegeri.Text))
                {
                    k10 = dusukSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k10 = cokYuksekSeviyeUyelikDegeri.Text;
                }



                txtUygulananKural.Items.Add("EGER SICAKLIK " + "DUSUK" + "(" + dusukSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK YUKSEK" + "(" + cokYuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k10 + ")");
                dk10 = Double.Parse(k10);
                x10 = x10 + 4.5 - (dk10 * 0.75);
                x10 = x10 + 3 + (dk10 * 0.75);
                durulastırma10 = x10 * dk10;
               
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(ortaSicaklikUyelikDegeri.Text) < double.Parse(cokDusukSeviyeUyelikDegeri.Text))
                {
                    k11 = ortaSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k11 = cokDusukSeviyeUyelikDegeri.Text;
                }



                txtUygulananKural.Items.Add("EGER SICAKLIK " + "ORTA" + "(" + ortaSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK DUSUK" + "(" + cokDusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK AZ OLUR.(" + k11 + ")");
                dk11 = Double.Parse(k11);
                x11 = x11 + 1 - (dk11 * 0.5);
                x11 = x11 + 0 + (dk11 * 0.5);
                durulastırma11 = x11 * dk11;
              
            }





            if (ortaSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(ortaSicaklikUyelikDegeri.Text) < double.Parse(dusukSeviyeUyelikDegeri.Text))
                {
                    k12 = ortaSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k12 = dusukSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "ORTA" + "(" + ortaSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "DUSUK" + "(" + dusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK AZ OLUR.(" + k12 + ")");
                dk12 = Double.Parse(k12);
                x12 = x12 + 1 - (dk12 * 0.5);
                x12 = x12 + 0 + (dk12 * 0.5);
                durulastırma12 = x12 * dk12;
                
            }



            if (ortaSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {
                if (double.Parse(ortaSicaklikUyelikDegeri.Text) < double.Parse(ortaSeviyeUyelikDegeri.Text))
                {
                    k13 = ortaSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k13 = ortaSeviyeUyelikDegeri.Text;
                }



                txtUygulananKural.Items.Add("EGER SICAKLIK " + "ORTA" + "(" + ortaSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "ORTA" + "(" + ortaSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ORTA OLUR.(" + k13 + ")");

                dk13 = Double.Parse(k13);
                x13 = x13 + 3.5 - (dk13 * 1);
                x13 = x13 + 1.5 + (dk13 * 1);
                durulastırma13 = x13 * dk13;
                
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(ortaSicaklikUyelikDegeri.Text) < double.Parse(yuksekSeviyeUyelikDegeri.Text))
                {
                    k14 = ortaSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k14 = yuksekSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "ORTA" + "(" + ortaSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "YUKSEK" + "(" + yuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k14 + ")");

                dk14 = Double.Parse(k14);
                x14 = x14 + 4.5 - (dk14 * 0.75);
                x14 = x14 + 3 + (dk14 * 0.75);
                durulastırma14 = x1 * dk14;
               
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {
                if (double.Parse(ortaSicaklikUyelikDegeri.Text) < double.Parse(cokYuksekSeviyeUyelikDegeri.Text))
                {
                    k15 = ortaSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k15 = cokYuksekSeviyeUyelikDegeri.Text;
                }

                txtUygulananKural.Items.Add("EGER SICAKLIK " + "ORTA" + "(" + ortaSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK YUKSEK" + "(" + cokYuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK OLUR.(" + k15 + ")");
                dk15 = Double.Parse(k15);
                x15 = x15 + 4.5 - (dk15 * 0.75);
                x15 = x15 + 3 + (dk15 * 0.75);
                durulastırma15 = x15 * dk15;
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {
                if (double.Parse(yuksekSicaklikUyelikDegeri.Text) < double.Parse(cokDusukSeviyeUyelikDegeri.Text))
                {
                    k16 = yuksekSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k16 = cokDusukSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "YUKSEK" + "(" + yuksekSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK DUSUK" + "(" + cokDusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ HAREKET YOK.(" +k16+ ")");
                dk16 = Double.Parse(k16);
                x16 = x16 + 4.5 - (dk16 * 0.75);

                durulastırma16 = x16 * dk16;
                durulastırma16 = 0;//çıkısta hareket yok.
               
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(yuksekSicaklikUyelikDegeri.Text) < double.Parse(dusukSeviyeUyelikDegeri.Text))
                {
                    k17 = yuksekSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k17 = dusukSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "YUKSEK" + "(" + yuksekSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "DUSUK" + "(" + dusukSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK AZ OLUR.(" + k17 + ")");
                dk17 = Double.Parse(k17);
                x17 = x17 + 1 - (dk17 * 0.5);
                x17 = x17 + 0 + (dk17 * 0.5);
                durulastırma17 = x17 * dk17;
                
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(yuksekSicaklikUyelikDegeri.Text) < double.Parse(ortaSeviyeUyelikDegeri.Text))
                {
                    k18 = yuksekSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k18 = ortaSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "YUKSEK" + "(" + yuksekSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "ORTA" + "(" + ortaSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ COK AZ OLUR.(" + k18 + ")");
                dk18 = Double.Parse(k18);
                x18 = x18 + 1 - (dk18 * 0.5);
                x18 = x18 + 0 + (dk18 * 0.5);
                durulastırma18 = x18 * dk18;
              
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(yuksekSicaklikUyelikDegeri.Text) < double.Parse(yuksekSeviyeUyelikDegeri.Text))
                {
                    k19 = yuksekSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k19 = yuksekSeviyeUyelikDegeri.Text;
                }


                txtUygulananKural.Items.Add("EGER SICAKLIK " + "YUKSEK" + "(" + yuksekSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "YUKSEK" + "(" + yuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ AZ OLUR.(" + k19 + ")");
                dk19 = Double.Parse(k19);
                x19 = x19 + 2 - (dk19 * 0.75);
                x19 = x19 + 0.5 + (dk19 * 0.75);
                durulastırma19 = x19 * dk19;
               
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {

                if (double.Parse(yuksekSicaklikUyelikDegeri.Text) < double.Parse(cokYuksekSeviyeUyelikDegeri.Text))
                {
                    k20 = yuksekSicaklikUyelikDegeri.Text;
                }
                else
                {
                    k20 = cokYuksekSeviyeUyelikDegeri.Text;
                }

                txtUygulananKural.Items.Add("EGER SICAKLIK " + "YUKSEK" + "(" + yuksekSicaklikUyelikDegeri.Text + ")" + " VE " + " SEVİYE " + "COK YUKSEK" + "(" + cokYuksekSeviyeUyelikDegeri.Text + ")" + " O HALDE ÇIKIŞ ORTA OLUR.(" + k20 + ")");
                dk20 = Double.Parse(k20);
                x20 = x20 + 3.5 - (dk20 * 1);
                x20 = x20 + 1.5 + (dk20 * 1);
                durulastırma20 = x20 * enBuyukSayiorta;
               
            }

            if (sicaklikdegeri>75)
            {
                txtUygulananKural.Items.Add("ÇIKIŞTA HAREKET YOK");
             
            }
        }

        private void bCikisDegerleri_Click(object sender, EventArgs e)
        {
            
            bGrafikler.Enabled = true;
            x1 = 0; x2 = 0; x3 = 0; x4 = 0; x5 = 0; x6 = 0; x7 = 0; x8 = 0; x9 = 0; x10 = 0; x11 = 0; x12 = 0; x13 = 0; x14 = 0; x15 = 0; x16 = 0; x17 = 0; x18 = 0; x19 = 0; x20 = 0; x21 = 0; x22 = 0; x23 = 0; x24 = 0; x25 = 0;



            double[] dizicokdusuk = { dk11, dk12, dk17, dk18 };
            // değişkenleri en küçük değerden tanımlayalım
            enBuyukSayicokdusuk = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < dizicokdusuk.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (dizicokdusuk[i] > enBuyukSayicokdusuk)
                {
                    enBuyukSayicokdusuk = dizicokdusuk[i];
                    enBuyukSayicokdusukpayda = enBuyukSayicokdusuk * 2;
                }
            }



            double[] dizidusuk = { dk6, dk19 };
            // değişkenleri en küçük değerden tanımlayalım
            enBuyukSayidusuk = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < dizidusuk.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (dizidusuk[i] > enBuyukSayidusuk)
                {
                    enBuyukSayidusuk = dizidusuk[i];
                    enBuyukSayidusukpayda = enBuyukSayidusuk * 2;
                }

            }
            double[] diziorta = { dk1, dk7, dk20, dk13 };
            // değişkenleri en küçük değerden tanımlayalım
            enBuyukSayiorta = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < diziorta.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (diziorta[i] > enBuyukSayiorta)
                {
                    enBuyukSayiorta = diziorta[i];
                    enBuyukSayiortapayda = enBuyukSayiorta * 2;
                }

            }
            double[] diziyuksek = { dk2, dk8, dk9, dk10, dk14, dk15 };
            // değişkenleri en küçük değerden tanımlayalım
            enBuyukSayiyuksek = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < diziyuksek.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (diziyuksek[i] > enBuyukSayiyuksek)
                {
                    enBuyukSayiyuksek = diziyuksek[i];
                    enBuyukSayiyuksekpayda = enBuyukSayiyuksek * 2;
                }
            }

            double[] dizicokyuksek = { dk3, dk4, dk5 };
            // değişkenleri en küçük değerden tanımlayalım
            enBuyukSayicokyuksek = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < dizicokyuksek.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (dizicokyuksek[i] > enBuyukSayicokyuksek)
                {
                    enBuyukSayicokyuksek = dizicokyuksek[i];
                    enBuyukSayicokyuksekpayda = enBuyukSayicokyuksek;

                }
            }


            double[] cikisdegerleri = { enBuyukSayicokdusuk, enBuyukSayidusuk, enBuyukSayiorta, enBuyukSayiyuksek, enBuyukSayicokyuksek };
            // değişkenleri en küçük değerden tanımlayalım
            double enBuyuk = 0;
            // dizinin tüm elemanlarını döngü ile gezelim
            for (int i = 0; i < cikisdegerleri.Length; i++)
            {// dizinin bu elemanı bulunan en büyük elemandan daha büyükse
                if (cikisdegerleri[i] > enBuyuk)
                {
                    enBuyuk = cikisdegerleri[i];
                    txtCikisDegerleri.Text = Convert.ToString(enBuyuk);
                }

            }



            payda = enBuyukSayiyuksekpayda + enBuyukSayicokyuksekpayda + enBuyukSayiortapayda + enBuyukSayidusukpayda + enBuyukSayicokdusukpayda;



            if (cokDusukSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {


                x1 = x1 + 1 - (enBuyukSayiorta * 0.5);
                x1 = x1 + 0 + (enBuyukSayiorta * 0.5);
                durulastırma1 = x1 * enBuyukSayiorta;
               
            }



            if (cokDusukSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {


                x2 = x2 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x2 = x2 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma2 = x2 * enBuyukSayiyuksek;
                
            }




            if (cokDusukSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {
                x3 = x3 + 4 + (enBuyukSayicokyuksek * 0.5);
                durulastırma3 = x3 * enBuyukSayicokyuksek;
                
            }



            if (cokDusukSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                x4 = x4 + 4 + (enBuyukSayicokyuksek * 0.5);
                durulastırma4 = x4 * enBuyukSayicokyuksek;
               
            }





            if (cokDusukSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {
                x5 = x5 + 4 + (enBuyukSayicokyuksek * 0.5);
                durulastırma5 = x5 * enBuyukSayicokyuksek;
               
            }




            if (dusukSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                x6 = x6 + 2 - (enBuyukSayidusuk * 0.75);
                x6 = x6 + 0.5 + (enBuyukSayidusuk * 0.75);
                durulastırma6 = x6 * enBuyukSayidusuk;
                
            }





            if (dusukSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                x7 = x7 + 3.5 - (enBuyukSayiorta * 1);
                x7 = x7 + 1.5 + (enBuyukSayiorta * 1);
                durulastırma7 = x7 * enBuyukSayiorta;
              
            }




            if (dusukSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {

                x8 = x8 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x8 = x8 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma8 = x8 * enBuyukSayiyuksek;
               
            }



            if (dusukSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                x9 = x9 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x9 = x9 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma9 = x9 * enBuyukSayiyuksek;
          
            }






            if (dusukSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {


                x10 = x10 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x10 = x10 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma10 = x10 * dk10;
                
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {


                x11 = x11 + 1 - (enBuyukSayicokdusuk * 0.5);
                x11 = x11 + 0 + (enBuyukSayicokdusuk * 0.5);
                durulastırma11 = x11 * enBuyukSayicokdusuk;
         
            }





            if (ortaSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {


                x12 = x12 + 1 - (enBuyukSayicokdusuk * 0.5);
                x12 = x12 + 0 + (enBuyukSayicokdusuk * 0.5);
                durulastırma12 = x12 * enBuyukSayicokdusuk;
             
            }



            if (ortaSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {
                x13 = x13 + 3.5 - (enBuyukSayiorta * 1);
                x13 = x13 + 1.5 + (enBuyukSayiorta * 1);
                durulastırma13 = x13 * enBuyukSayiorta;
               
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                x14 = x14 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x14 = x14 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma14 = x14 * enBuyukSayiyuksek;
               
            }




            if (ortaSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {
                x15 = x15 + 4.5 - (enBuyukSayiyuksek * 0.75);
                x15 = x15 + 3 + (enBuyukSayiyuksek * 0.75);
                durulastırma15 = x15 * enBuyukSayiyuksek;
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                x16 = x16 + 4.5 - (dk16 * 0.75);
                txtCikisDegerleri.Text = "0";
                durulastırma16 = x16 * dk16;
                durulastırma16 = 0;//çıkısta hareket yok.
              
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                x17 = x17 + 1 - (enBuyukSayicokdusuk * 0.5);
                x17 = x17 + 0 + (enBuyukSayicokdusuk * 0.5);
                durulastırma17 = x17 * enBuyukSayicokdusuk;
                
            }




            if (yuksekSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {


                x18 = x18 + 1 - (enBuyukSayicokdusuk * 0.5);
                x18 = x18 + 0 + (enBuyukSayicokdusuk * 0.5);
                durulastırma18 = x18 * enBuyukSayicokdusuk;
               
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                x19 = x19 + 2 - (enBuyukSayidusuk * 0.75);
                x19 = x19 + 0.5 + (enBuyukSayidusuk * 0.75);
                durulastırma19 = x19 * enBuyukSayidusuk;
         
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {


                x20 = x20 + 3.5 - (enBuyukSayiorta * 1);
                x20 = x20 + 1.5 + (enBuyukSayiorta * 1);
                durulastırma20 = x20 * enBuyukSayiorta;
             
            }


            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokDusukSeviyeUyelikDegeri.Text != "0")
            {

                x21 = x21 + 4.5 - (dk21 * 0.75);
                x21 = x21 + 3 + (dk21 * 0.75);
                durulastırma21 = x21 * dk21;//çıkısta hareket yok.;
               
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & dusukSeviyeUyelikDegeri.Text != "0")
            {

                x22 = x22 + 4.5 - (dk22 * 0.75);
                x22 = x22 + 3 + (dk22 * 0.75);
                durulastırma22 = x22 * dk22;//çıkısta hareket yok.;
           
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & ortaSeviyeUyelikDegeri.Text != "0")
            {


                x23 = x23 + 4.5 - (dk23 * 0.75);
                x23 = x23 + 3 + (dk23 * 0.75);
                durulastırma23 = x23 * dk23;//çıkısta hareket yok.;
              
            }






            if (yuksekSicaklikUyelikDegeri.Text != "0" & yuksekSeviyeUyelikDegeri.Text != "0")
            {

                x24 = x24 + 4.5 - (dk24 * 0.75);
                x24 = x1 + 3 + (dk24 * 0.75);
                durulastırma24 = x24 * dk24;//çıkısta hareket yok.;
              
            }



            if (yuksekSicaklikUyelikDegeri.Text != "0" & cokYuksekSeviyeUyelikDegeri.Text != "0")
            {

                x25 = x25 + 4.5 - (dk25 * 0.75);
                x25 = x25 + 3 + (dk25 * 0.75);
                durulastırma25 = x25 * dk25;//çıkısta hareket yok.;
               
            }

            if (sicaklikdegeri > 75)
            {
              
                txtDurulastirilmis.Text = "0";
                txtCikisDegerleri.Text = "0";
            }
           

            /*
  txtDurulastirilmis.Text = Convert.ToString((durulastırma1 + durulastırma2 + durulastırma3 + durulastırma4 + durulastırma5 +
  durulastırma6 + durulastırma7 + durulastırma8 + durulastırma9 + durulastırma10 + durulastırma11 + durulastırma12 + durulastırma13 + durulastırma14 + durulastırma15 +
  durulastırma16 + durulastırma17 + durulastırma18 + durulastırma19 + durulastırma20 + durulastırma21 + durulastırma22 + durulastırma23 + durulastırma24 + durulastırma25) / (payda));
             */
            double[] result = { 0 };
            double[] results2 = { 0 };

            double[] result3 = { 0 };
            double[] result4 = {0  };
            double[] result5 = { 0 };
           
            toplam = 0;
            double[] numberscokdusuk = new double[] { durulastırma11, durulastırma12, durulastırma17, durulastırma18 };
            
           result = (double[])karakter(numberscokdusuk);
            foreach (double num in result)
            {
                toplam += num;

            }
            double[] numbersdusuk = new double[] { durulastırma6, durulastırma19 };
            double[] result2 = (double[])karakter(numbersdusuk);
            foreach (double num2 in result2)
            {
                toplam += num2;

            }
            double[] numbersorta = new double[] { durulastırma1, durulastırma7, durulastırma13, durulastırma20 };
           result3 = (double[])karakter(numbersorta);
            foreach (double num3 in result3)
            {
                toplam += num3;

            }
            double[] numbersyuksek = new double[] { durulastırma2, durulastırma8, durulastırma9, durulastırma10, durulastırma14, durulastırma15 };
           result4 = (double[])karakter(numbersyuksek);
            foreach (double num4 in result4)
            {
                toplam += num4;

            }
            double[] numberscokyuksek = new double[] { durulastırma3, durulastırma4, durulastırma5 };
            result4 = (double[])karakter(numberscokyuksek);
            foreach (double num5 in result4)
            {
                

                toplam += num5;
           
            }
            
            txtDurulastirilmis.Text = Convert.ToString(toplam / payda);
            durulastırma1 = 0; durulastırma2 = 0; durulastırma3 = 0; durulastırma4 = 0; ; durulastırma5 = 0;
            durulastırma6 = 0; durulastırma7 = 0; durulastırma8 = 0; durulastırma9 = 0; ; durulastırma10 = 0; durulastırma11 = 0; durulastırma12 = 0; durulastırma13 = 0;
            durulastırma14 = 0; durulastırma15 = 0; durulastırma16 = 0; durulastırma17 = 0; durulastırma18 = 0; durulastırma19 = 0; durulastırma20 = 0; durulastırma21 = 0;
            durulastırma22 = 0; durulastırma23 = 0; durulastırma24 = 0; durulastırma25 = 0;
            enBuyukSayicokdusukpayda = 0; enBuyukSayidusukpayda = 0; enBuyukSayiortapayda = 0; enBuyukSayiyuksekpayda = 0; enBuyukSayicokyuksekpayda = 0;
            dk1 = 0; dk2 = 0; dk3 = 0; dk4 = 0;
            dk5 = 0; dk6 = 0; dk7 = 0; dk8 = 0; dk9 = 0; dk10 = 0; dk11 = 0; dk12 = 0; dk13 = 0; dk14 = 0; dk15 = 0; dk16 = 0; dk17 = 0; dk18 = 0; dk19 = 0; dk20 = 0; dk21 = 0; dk22 = 0; dk23 = 0; dk24 = 0; dk25 = 0;
       
            if (txtDurulastirilmis.Text == "NaN")
            {

                txtDurulastirilmis.Text = ("0");
            }
           
            toplam = 0;
            payda = 0;


            /*+ "/n" + "Pay değerleri" + (durulastırma1 + "---" + durulastırma2 + "---" + durulastırma3 + "---" + durulastırma4 + "---" + durulastırma5 + "---" +
              durulastırma6 + "---" + durulastırma7 + "---" + durulastırma8 + "---" + durulastırma9 + "---" + durulastırma10 + "---" + durulastırma11 + "---" + durulastırma12 + "---" + durulastırma13 + "---" + durulastırma14 + "---" + durulastırma15 +
              durulastırma16 + "---" + durulastırma17 + "---" + durulastırma18 + "---" + durulastırma19 + "---" + durulastırma20 + "---" + durulastırma21 + "---" + durulastırma22 + "---" + durulastırma23 + "---" + durulastırma24 + "---" + durulastırma25

              + "Payda değerleri+ " + enBuyukSayiyuksekpayda + "  " + enBuyukSayicokyuksekpayda + "  " + enBuyukSayiortapayda + " " + enBuyukSayidusukpayda + " " + enBuyukSayicokdusukpayda);
            ;

             txtDurulastirilmis.Text = Convert.ToString(durulastırma1 + "---" + durulastırma2 + "---" + durulastırma3 + "---" + durulastırma4 + "---" + durulastırma5 + "---" +
              durulastırma6 + "---" + durulastırma7 + "---" + durulastırma8 + "---" + durulastırma9 + "---" + durulastırma10 + "---" + durulastırma11 + "---" + durulastırma12 + "---" + durulastırma13 + "---" + durulastırma14 + "---" + durulastırma15 +
              durulastırma16 + "---" + durulastırma17 + "---" + durulastırma18 + "---" + durulastırma19 + "---" + durulastırma20 + "---" + durulastırma21 + "---" + durulastırma22 + "---" + durulastırma23 + "---" + durulastırma24 + "---" + durulastırma25);
             */

        }

        

        public static Array karakter(Array arr)
        {
            // this procedure works only with vectors
            if (arr.Rank != 1)
                throw new ArgumentException("Multiple-dimension arrays are not supported");

            // we use a hashtable to track duplicates
            // make the hash table large enough to avoid memory re-allocations
            Hashtable ht = new Hashtable(arr.Length * 2);
            // we will store unique elements in this ArrayList
            ArrayList elements = new ArrayList();

            foreach (object Value in arr)
            {
                if (!ht.Contains(Value))
                {
                    // we've found a non duplicate
                    elements.Add(Value);
                    // remember it for later
                    ht.Add(Value, null);
                }
            }
            // return an array of same type as the original array
            return elements.ToArray(arr.GetType().GetElementType());
        }

        private void bGrafikler_Click(object sender, EventArgs e)
        {
            toplam = 0; payda = 0;
            Grafik grafikGiris = new Grafik();
            grafikGiris.lblSicaklikDegeri.Text = sicaklikDeger.Text;
            grafikGiris.lblSeviyeDeger.Text = seviyeDeger.Text;

            grafikGiris.textBox1.Text = txtCikisDegerleri.Text;

            grafikGiris.Show();
        }

        private void sicaklikDeger_TextChanged(object sender, EventArgs e)
        {
            
            try
            {


                double sayi = Double.Parse(sicaklikDeger.Text);
                if (sayi > 100 || sayi < 0)
                {

                    MessageBox.Show("Sayı 0 dan küçük 100 den büyük olamaz");
                    sicaklikDeger.Text = "";
                }
            }
            catch
            {
                sicaklikDeger.Text = "";
                MessageBox.Show("Yalnızca sayı giriniz");

            }

        }
        private void seviyeDeger_TextChanged(object sender, EventArgs e)
        {
            try
            {


                double sayi2 = Double.Parse(seviyeDeger.Text);
                if (sayi2 > 5 || sayi2 < 0)
                {

                    MessageBox.Show("Sayı 0 dan küçük 5 den büyük olamaz");
                    seviyeDeger.Text = "";
                }
            }
            catch
            {
                seviyeDeger.Text = "";


            }

        }

        private void sicaklikDeger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            ////e.Handled = Char.IsWhiteSpace(e.KeyChar);//bosluk tusu engeli

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bKural.Enabled = false;
            bCikisDegerleri.Enabled = false;
            bGrafikler.Enabled = false;
        }

        private void seviyeDeger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            //e.Handled = Char.IsWhiteSpace(e.KeyChar);//bosluk tusu engeli

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void temizle()
        {
            cokDusukSeviyeUyelikDegeri.Text = "0";
            dusukSeviyeUyelikDegeri.Text = "0";
            ortaSeviyeUyelikDegeri.Text = "0";
            yuksekSeviyeUyelikDegeri.Text = "0";
            cokYuksekSeviyeUyelikDegeri.Text = "0";
            
            cokDusukSicaklikUyelikDegeri.Text = "0";
            dusukSicaklikUyelikDegeri.Text = "0";
            ortaSicaklikUyelikDegeri.Text = "0";
            yuksekSicaklikUyelikDegeri.Text = "0";
            cokYuksekSicaklikUyelikDegeri.Text = "0";
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
        }
    }
}