using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G191210046
{
    public partial class Form1 : Form
    {
        //Atık interface'i tanımlanıyor
        public interface IAtik {
            int Hacim { get; }
            System.Drawing.Image image { get; }
        }
        //Dolabilen interface'i tanımlanıyor
        public interface IDolabilen
        {
            int Kapasite { get; set; }
            int DoluHacim { get; }
            int DolulukOrani { get; set; }
        }
        //Atık kutusu interface'i tanımlanıyor
        public interface IAtikKutusu : IDolabilen
        {
            int BosaltmaPuani { get; }
            bool Ekle(Atik atik);
            bool Bosalt();

        }
        //Atık kutusu interface i tanımlanıyor
        public class AtikKutusu : IAtikKutusu
        {
            public int BosaltmaPuani { get; }
            public int Kapasite { get; set; }
            public int DoluHacim { get; set; }
            public int DolulukOrani { get; set; }
            //Kurucu fonksiyon gereklideğerleri atıyor
            public AtikKutusu(int BosaltmaPuani,int Kapasite) {
                this.BosaltmaPuani = BosaltmaPuani;
                this.Kapasite = Kapasite;
                DoluHacim = 0;
                DolulukOrani = 0;
            }
            // gönderilen atığın kutuya girip giremeyeceğini söyleyen fonksiyon
            public bool Ekle(Atik atik)
            {
                if(atik.Hacim<=(Kapasite-DoluHacim)) 
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            // Kutuyu boşaltıp boşaltamayacağımızı söyleyen fonksiyon
            public bool Bosalt()
            {
                if (DolulukOrani>=75)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            // bu fonksiyon doluluk oranını hesaplıyor
            public void DolulukOraniHesapla() {
                DolulukOrani = Convert.ToInt32((DoluHacim*100)/Kapasite);
            }

        }
        // Atik Classı oluşturuluyor
        public class Atik : IAtik
        {
            public string atikAdi{ get; }
            public int Hacim { get; }
            public Image image{ get; }
            //Kurucu fonksiyon gerekli değerleri veriyor
            public Atik(int Hacim, string dizin,string atikAdi)
            {
                this.Hacim = Hacim;
                this.image = Image.FromFile(dizin);
                this.atikAdi = atikAdi;
            }
            
        }


        public Form1()
        {
            InitializeComponent();
        }

        Atik[] Atiklar;
        AtikKutusu[] Kutular;
        public void Form1_Load(object sender, EventArgs e)
        {
            //Atıklar ve atık kutuları için yer isteniyor ve başlangıç değerleri gönderiliyor.
            Atiklar = new Atik[8];
            Atiklar[0] = new Atik(550,"salca.jpg","Salça Kutusu");
            Atiklar[1] = new Atik(350, "kola.jpg","Kola Kutusu");
            Atiklar[2] = new Atik(250, "gazete.png","Gazete");
            Atiklar[3] = new Atik(200, "dergi.jpg","Dergi");
            Atiklar[4] = new Atik(600, "sise.jpg","Cam Şişe");
            Atiklar[5] = new Atik(250, "bardak.jpg","Cam Bardak");
            Atiklar[6] = new Atik(120, "salatalık.jpg","Salatalık");
            Atiklar[7] = new Atik(150, "domates.jpg","Domates");
            Kutular = new AtikKutusu[4];
            Kutular[0] = new AtikKutusu(525,700);
            Kutular[1] = new AtikKutusu(900,1200);
            Kutular[2] = new AtikKutusu(1650,2200);
            Kutular[3] = new AtikKutusu(1725,2300);
        }
        int rastgeleAtik;
        // rastgele atık seçen ve resmini çizen fonksiyon
        public void RastgeleResimCiz() {
            Random Rastgele = new Random();
            rastgeleAtik = Rastgele.Next(0, 8);
            this.resim.Image = Atiklar[rastgeleAtik].image;
        }
        //Çıkış butonuna basınca formu kapatan fonksiyon
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Yeni oyun butonuna basınca oyunu başlatan fonksiyon 
        private void new_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            oyunuBaslat();
            puan_gb.BackColor = System.Drawing.Color.Pink;
            sure_gb.BackColor = System.Drawing.Color.Pink;
            sure = 60;
            sure_lbl.Text = sure.ToString();
            RastgeleResimCiz();
            puan = 0;
            puan_lbl.Text = "0";

        }
        public int sure;
        public int puan = 0;
        // her 1 saniye geçtiğinde çalışan fonksiyon
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                timer1.Stop();
                oyunuBitir();
            }
            else {
                sure--;
                sure_lbl.Text = sure.ToString();
                
            }

        }
        //Organik tuşuna basınca çalışan fonksiyon
        private void organik_btn_Click(object sender, EventArgs e)
        {
            //Eğer rastgele atığın dizi numarası 6-7 ise içeriye girer
            if (rastgeleAtik == 6 || rastgeleAtik == 7) {
                //Gelen atığın atık kutusuna girip giremeyeceğini sorgulayan if else girebiliyor ise kutuya ekleyerek yeni atık oluşturuyor
                if (Kutular[0].Ekle(Atiklar[rastgeleAtik]) == true) {
                    organik_ltb.Items.Add(Atiklar[rastgeleAtik].atikAdi+" ("+ Atiklar[rastgeleAtik].Hacim+")");
                    puan += Atiklar[rastgeleAtik].Hacim;
                    puan_lbl.Text = puan.ToString();
                    Kutular[0].DoluHacim += Atiklar[rastgeleAtik].Hacim;
                    Kutular[0].DolulukOraniHesapla();
                    organik_pb.Value = Kutular[0].DolulukOrani;
                    RastgeleResimCiz();
                }
            }
        }
        //Kağıt tuşuna basınca çalışan fonksiyon
        private void kagit_btn_Click(object sender, EventArgs e)
        {
            //Eğer rastgele atığın dizi numarası 2-3 ise içeriye girer
            if (rastgeleAtik == 2 || rastgeleAtik == 3)
            {
                //Gelen atığın atık kutusuna girip giremeyeceğini sorgulayan if else girebiliyor ise kutuya ekleyerek yeni atık oluşturuyor
                if (Kutular[1].Ekle(Atiklar[rastgeleAtik]) == true)
                {
                    kagit_ltb.Items.Add(Atiklar[rastgeleAtik].atikAdi + " (" + Atiklar[rastgeleAtik].Hacim + ")");
                    puan += Atiklar[rastgeleAtik].Hacim;
                    puan_lbl.Text = puan.ToString();
                    Kutular[1].DoluHacim += Atiklar[rastgeleAtik].Hacim;
                    Kutular[1].DolulukOraniHesapla();
                    kagit_pb.Value = Kutular[1].DolulukOrani;
                    RastgeleResimCiz();
                }
            }
        }
        //Cam tuşuna basınca çalışan fonksiyon
        private void cam_btn_Click(object sender, EventArgs e)
        {
            //Eğer rastgele atığın dizi numarası 4-5 ise içeriye girer
            if (rastgeleAtik == 4 || rastgeleAtik == 5)
            {
                //Gelen atığın atık kutusuna girip giremeyeceğini sorgulayan if else girebiliyor ise kutuya ekleyerek yeni atık oluşturuyor
                if (Kutular[2].Ekle(Atiklar[rastgeleAtik]) == true)
                {
                    cam_ltb.Items.Add(Atiklar[rastgeleAtik].atikAdi + " (" + Atiklar[rastgeleAtik].Hacim + ")");
                    puan += Atiklar[rastgeleAtik].Hacim;
                    puan_lbl.Text = puan.ToString();
                    Kutular[2].DoluHacim += Atiklar[rastgeleAtik].Hacim;
                    Kutular[2].DolulukOraniHesapla();
                    cam_pb.Value = Kutular[2].DolulukOrani;
                    RastgeleResimCiz();
                }
            }
        }
        //Metal tuşuna basınca çalışan fonksiyon
        private void metal_btn_Click(object sender, EventArgs e)
        {
            //Eğer rastgele atığın dizi numarası 0-1 ise içeriye girer
            if (rastgeleAtik == 0 || rastgeleAtik == 1)
            {
                //Gelen atığın atık kutusuna girip giremeyeceğini sorgulayan if else girebiliyor ise kutuya ekleyerek yeni atık oluşturuyor
                if (Kutular[3].Ekle(Atiklar[rastgeleAtik]) == true)
                {
                    metal_ltb.Items.Add(Atiklar[rastgeleAtik].atikAdi + " (" + Atiklar[rastgeleAtik].Hacim + ")");
                    puan += Atiklar[rastgeleAtik].Hacim;
                    puan_lbl.Text = puan.ToString();
                    Kutular[3].DoluHacim += Atiklar[rastgeleAtik].Hacim;
                    Kutular[3].DolulukOraniHesapla();
                    metal_pb.Value = Kutular[3].DolulukOrani;
                    RastgeleResimCiz();
                }
            }
        }
        //Organik boşalt tuşuna basınca çalışan fonksiyon
        private void organik_bos_btn_Click(object sender, EventArgs e)
        {
            //Eğer kutunun hacmi 75% ten büyük ise içeriye girer
            if (Kutular[0].Bosalt() == true) {
                sure += 3;
                sure_lbl.Text = sure.ToString();
                organik_ltb.Items.Clear();
                Kutular[0].DoluHacim = 0;
                organik_pb.Value = 0;
            }
        }
        //Kağıt boşalt tuşuna basınca çalışan fonksiyon
        private void kagit_bos_btn_Click(object sender, EventArgs e)
        {
            //Eğer kutunun hacmi 75% ten büyük ise içeriye girer
            if (Kutular[1].Bosalt() == true)
            {
                sure += 3;
                sure_lbl.Text = sure.ToString();
                kagit_ltb.Items.Clear();
                puan += 1000;
                puan_lbl.Text = puan.ToString();
                Kutular[1].DoluHacim = 0;
                kagit_pb.Value = 0;
            }
        }
        //Cam boşalt tuşuna basınca çalışan fonksiyon
        private void cam_bos_btn_Click(object sender, EventArgs e)
        {
            //Eğer kutunun hacmi 75% ten büyük ise içeriye girer
            if (Kutular[2].Bosalt() == true)
            {
                sure += 3;
                sure_lbl.Text = sure.ToString();
                cam_ltb.Items.Clear();
                puan += 600;
                puan_lbl.Text = puan.ToString();
                Kutular[2].DoluHacim = 0;
                cam_pb.Value = 0;
            }
        }
        //Metal boşalt tuşuna basınca çalışan fonksiyon
        private void metal_bos_btn_Click(object sender, EventArgs e)
        {
            //Eğer kutunun hacmi 75% ten büyük ise içeriye girer
            if (Kutular[3].Bosalt() == true)
            {
                sure += 3;
                sure_lbl.Text = sure.ToString();
                metal_ltb.Items.Clear();
                puan += 800;
                puan_lbl.Text = puan.ToString();
                Kutular[3].DoluHacim = 0;
                metal_pb.Value = 0;
            }
        }
        //Oyunu baslatan fonksiyon bütün butonları kullanılabilir hale getirir,puanları sıfırlar,listboxları temizler.
        private void oyunuBaslat() {
            organik_bos_btn.Enabled = true;
            organik_btn.Enabled = true;
            metal_bos_btn.Enabled = true;
            metal_btn.Enabled = true;
            cam_bos_btn.Enabled = true;
            cam_btn.Enabled = true;
            kagit_bos_btn.Enabled = true;
            kagit_btn.Enabled = true;
            metal_pb.Value = 0;
            metal_ltb.Items.Clear();
            kagit_pb.Value = 0;
            kagit_ltb.Items.Clear();
            cam_pb.Value = 0;
            cam_ltb.Items.Clear();
            organik_pb.Value = 0;
            organik_ltb.Items.Clear();
            for (int i = 0; i < 4; i++) {
                Kutular[i].DoluHacim = 0;
                Kutular[i].DolulukOrani = 0;
            }



        }
        //süre bitince butonlara basmayı engeller.
        private void oyunuBitir() {
            organik_bos_btn.Enabled = false;
            organik_btn.Enabled = false;
            metal_bos_btn.Enabled = false;
            metal_btn.Enabled = false;
            cam_bos_btn.Enabled = false;
            cam_btn.Enabled = false;
            kagit_bos_btn.Enabled = false;
            kagit_btn.Enabled = false;
        }
    }
}
