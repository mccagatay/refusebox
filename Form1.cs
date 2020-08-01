
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpproje
{
    public partial class Form1 : Form
    {        
        //atik objeleri olusturuldu
        CamSise camSise1 = new CamSise();
        Bardak bardak1 = new Bardak();
        Gazete gazete1 = new Gazete();
        Dergi dergi1 = new Dergi();
        Domates domates1 = new Domates();
        Salatalik salatalik1 = new Salatalik();
        KolaKutusu kolaKutusu1 = new KolaKutusu();
        SalcaKutusu salcaKutusu1 = new SalcaKutusu();

        //atik kutusu objeleri olusturuldu
        CamKutusu camKutusu1 = new CamKutusu();
        KagitKutusu kagitKutusu1 = new KagitKutusu();
        MetalKutusu metalKutusu1 = new MetalKutusu();
        OrganikAtikKutusu organikAtikKutusu1 = new OrganikAtikKutusu();

        //rastgele bir atik secilip,atigin resmi panel arkaplani olarak ayarlanmasi icin yazildi
        private void AtikUret()
        {
            Random rastgele = new Random();

            int sayi = rastgele.Next(9);

            switch (sayi)
            {
                case 1:
                    this.panel7.BackgroundImage = camSise1.Image;                    
                    break;
                
                case 2:               
                    this.panel7.BackgroundImage = bardak1.Image;
                    break;
                
                case 3:
                    this.panel7.BackgroundImage = gazete1.Image;
                    break;

                case 4:
                    this.panel7.BackgroundImage = dergi1.Image;
                    break;

                case 5:
                    this.panel7.BackgroundImage = domates1.Image;
                    break;

                case 6:
                    this.panel7.BackgroundImage = salatalik1.Image;
                    break;

                case 7:
                    this.panel7.BackgroundImage = kolaKutusu1.Image;
                    break;

                case 8:
                    this.panel7.BackgroundImage = salcaKutusu1.Image;
                    break;

                default:
                    
                    break;
            }
        }

        /*yeni oyun butonuna tiklandiginda butonları aktiflestirmek,sureyi baslatmak
        yeni oyun butonunun disabled olmasi icin ve rastgele atik uretmek icin yazildi   */     
        private void yenioyunBtn_Click_1(object sender, EventArgs e)
        {
            butonlariAktiflestir();

            sureLabel.Text = Convert.ToString(timeLeft);

            timer1.Start();

            AtikUret();

            yenioyunBtn.Enabled = false;
 
        }
        
        //surenin kac saniye oldugunu tutan degisken
        int timeLeft = 60;
        
        //sayacin 60 dan geriye saymasi icin yazildi
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                sureLabel.Text = Convert.ToString(timeLeft);
            }
           
            else
            {              
                timer1.Stop();
                butonlariDondur();
                yenioyunBtn.Enabled = true;
            }
        }

        //sure dolunca butonlari dondurmak icin yazildi
        public void butonlariDondur()
        {
            organikatikBosaltBtn.Enabled = false;
            organikatikBtn.Enabled = false;
            kagıtBosaltBtn.Enabled = false;
            kagıtBtn.Enabled = false;
            camBosaltBtn.Enabled = false;
            camBtn.Enabled = false;
            metalBosaltBtn.Enabled = false;
            metalBtn.Enabled = false;
        }

        //yeni oyun butonuna tiklayinca butonlari aktiflestirmek icin yazildi
        public void butonlariAktiflestir()
        {
            organikatikBosaltBtn.Enabled = true;
            organikatikBtn.Enabled = true;
            kagıtBosaltBtn.Enabled = true;
            kagıtBtn.Enabled = true;
            camBosaltBtn.Enabled = true;
            camBtn.Enabled = true;
            metalBosaltBtn.Enabled = true;
            metalBtn.Enabled = true;
        }

        //cikis butonuna tiklaninca formun kapatilmasi icin yazildi
        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metal atik butonuna tiklandiginda metal kutusuna eklemek icin yazildi
        private void metalBtn_Click(object sender, EventArgs e)
        {
            kutuyaEkle(metalKutusu1, kolaKutusu1, metalbar, metalListBox, salcaKutusu1);           
        }

        //organik atik butonuna tiklandiginda organik atik kutusuna eklemek icin yazildi
        private void organikatikBtn_Click(object sender, EventArgs e)
        {
            kutuyaEkle(organikAtikKutusu1, domates1, organikatikBar, organikAtikListBox, salatalik1);      
        }

        //kagit atik butonuna tiklandiginda kagit atik kutusuna eklemek icin yazildi
        private void kagıtBtn_Click(object sender, EventArgs e)
        {
            kutuyaEkle(kagitKutusu1, gazete1, kagitBar, kagitListBox, dergi1);     
        }

        //cam atik butonuna tiklandiginda cam atik kutusuna eklemek icin yazildi
        private void camBtn_Click(object sender, EventArgs e)
        {
            kutuyaEkle(camKutusu1, bardak1,  cambar, camListBox, camSise1);                
        }

        //organik atik kutusu dolunca,butona tiklandiginda kutunun bosaltilmasi icin yazildi
        private void organikatikBosaltBtn_Click(object sender, EventArgs e)
        {
            kutuBosalt(organikAtikKutusu1, organikAtikListBox, organikatikBar);
        }

        //kagit atik kutusu dolunca,butona tiklandiginda kutunun bosaltilmasi icin yazildi
        private void kagıtBosaltBtn_Click(object sender, EventArgs e)
        {
            kutuBosalt(kagitKutusu1, kagitListBox, kagitBar);
        }

        //cam atik kutusu dolunca,butona tiklandiginda kutunun bosaltilmasi icin yazildi
        private void camBosaltBtn_Click(object sender, EventArgs e)
        {
            kutuBosalt(camKutusu1, camListBox, cambar);
        }

        //metal atik kutusu dolunca,butona tiklandiginda kutunun bosaltilmasi icin yazildi
        private void metalBosaltBtn_Click(object sender, EventArgs e)
        {
            kutuBosalt(metalKutusu1, metalListBox, metalbar);
        }

        //kutu bosaltma butonlarinin kullanacagi fonksiyon yazildi
        //parametre olarak hangi atik kutusu oldugu ve o atik kutusunun listesi ve progressbar ını aldı
        public void kutuBosalt(IAtikKutusu atikKutusu,ListBox listbox,ProgressBar progressBar)
        {
            /*atik kutusunun %75 ustu doluluk orani varsa listenin temizlenmesi,sureye 3 saniye
            eklenmesi atik kutusunun hacminin 0 lanmasi ve puan eklemesi icin yazildi*/
            if (atikKutusu.DolulukOrani > 75)
            {
                listbox.Items.Clear();

                timeLeft += 3;

                atikKutusu.DoluHacim = 0;

                progressBar.Value = 0;

                puanLabel.Text = Convert.ToString(Convert.ToInt32(puanLabel.Text) + atikKutusu.BosaltmaPuani);
            }
        }

        //atik ekleme butonlarinin kullanacagi fonksiyon yazildi
        /*parametre olarak tiklanacak butonun atikkutusu turu, o atik kutusuna ait atiklar
         *atik kutusuna ait liste ve progress bar eklendi
         */
        public void kutuyaEkle(IAtikKutusu atikKutusu,IAtik atik1,ProgressBar atikBar,ListBox atikListBox, IAtik atik2)
        {
            //atilan atigin dogru kutuya atildigini kontrol etmek icin yazildi
            if (atikKutusu.Ekle(atik1) || atikKutusu.Ekle(atik2))
            {
                //atikla resmin uyusup uyusmadigi kontrol edilmek icin yazildi
                if (atik1.Image == panel7.BackgroundImage)
                {
                    //atik kutuya atilmadan once kutuda yeterince yer olup olmamasi kontrol edilmek icin yazildi
                    if (atikBar.Value < atikKutusu.Kapasite - atik1.Hacim)
                    {
                        atikKutusu.DoluHacim += atik1.Hacim;

                        puanLabel.Text = Convert.ToString(Convert.ToInt32(puanLabel.Text) + atik1.Hacim);

                        atikBar.Value = atikKutusu.DoluHacim;

                        atikListBox.Items.Add(atik1.Isim);

                        AtikUret();
                    }
                }

                //atikla resmin uyusup uyusmadigi kontrol edilmek icin yazildi
                else if (atik2.Image == panel7.BackgroundImage)
                {
                    //atik kutuya atilmadan once kutuda yeterince yer olup olmamasi kontrol edilmek icin yazildi
                    if (atikBar.Value < atikKutusu.Kapasite - atik2.Hacim)
                    {
                        atikKutusu.DoluHacim += atik2.Hacim;

                        atikBar.Value = atikKutusu.DoluHacim;

                        puanLabel.Text = Convert.ToString(Convert.ToInt32(puanLabel.Text) + atik2.Hacim);

                        atikListBox.Items.Add(atik2.Isim);

                        AtikUret();
                    }                  
                }
            }
        }
    }
}
