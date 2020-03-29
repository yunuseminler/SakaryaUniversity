using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g191210046
{

    public partial class Form1 : Form
    {
        //Ürünler tanımlanıyor
        Buzdolabi Fridge;
        LedTv Tv;
        Laptop Pc;
        CepTel Telefon;
        public Form1()
        {

            //urunlerin başlangıçtaki değerleri form uygulamasına yazdırılıyor
            Random Rastgele = new Random();
            Fridge = new Buzdolabi("Buzdolabi", "Beko", "L500", "Dondurucu", 6000, 350, "A++", Rastgele, 5);
            Tv = new LedTv("Led Tv", "Samsung", "C350", "İnce", 10000, 49, "4096x2160", Rastgele, 18);
            Pc = new Laptop("Bilgisayar", "Monster", "TSİ", "Güçlü", 8400, 13, "1920X1080", 500, 24, 4000, Rastgele, 15);
            Telefon = new CepTel("Telefon", "Sony", "E4G", "İyi Kamera", 3000, 64, 8, 3000, Rastgele, 20);
            InitializeComponent();
            this.TvFiyat_lbl.Text = Tv.HamFiyat.ToString();
            this.TvStok_lbl.Text = Tv.StokAdedi.ToString();
            this.TvAdet_nud.Maximum = Tv.StokAdedi;
            this.TelFiyat_lbl.Text = Telefon.HamFiyat.ToString();
            this.TelStok_lbl.Text = Telefon.StokAdedi.ToString();
            this.TelAdet_nud.Maximum = Telefon.StokAdedi;
            this.DolapFiyat_lbl.Text = Fridge.HamFiyat.ToString();
            this.DolapStok_lbl.Text = Fridge.StokAdedi.ToString();
            this.DolapAdet_nud.Maximum = Fridge.StokAdedi;
            this.LaptopFiyat_lbl.Text = Pc.HamFiyat.ToString();
            this.LaptopStok_lbl.Text = Pc.StokAdedi.ToString();
            this.LaptopAdet_nud.Maximum = Pc.StokAdedi;
        }
        //Stok sayısı güncellenerek Adeti gösteren numericupdown aracı sıfırlanıyor
        public void sifirla()
        {

            TelAdet_nud.Value = 0;
            TvAdet_nud.Value = 0;
            DolapAdet_nud.Value = 0;
            LaptopAdet_nud.Value = 0;

            this.TvStok_lbl.Text = Tv.StokAdedi.ToString();
            this.TelStok_lbl.Text = Telefon.StokAdedi.ToString();
            this.DolapStok_lbl.Text = Fridge.StokAdedi.ToString();
            this.LaptopStok_lbl.Text = Pc.StokAdedi.ToString();
        }
        //Exit butonunun çıkışısını sağlıyor
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sepete ekleye tıklanınca olan olaylar
        private void Ekle_Click(object sender, EventArgs e)
        {

            //Sepet temizleniyor
            fiyat_lb.Items.Clear();
            isim_lb.Items.Clear();
            adet_lb.Items.Clear();

            Sepet Sepetim = new Sepet();
            Tv.SecilenAdet = Convert.ToInt32(TvAdet_nud.Value);
            //Secilen adet kadar tv'nin kdv'li fiyatı hesaplanarak bilgileriyle birlikte Listboxlara ekleniyor

            if (Tv.SecilenAdet > 0 && (Tv.StokAdedi - Tv.SecilenAdet) >= 0)
            {

                fiyat_lb.Items.Add(Sepetim.SepeteUrunEkle(Tv));
                isim_lb.Items.Add(Tv.Ad);
                adet_lb.Items.Add(Tv.SecilenAdet);
                Tv.StokAdedi -= Tv.SecilenAdet;
            }

            Fridge.SecilenAdet = Convert.ToInt32(DolapAdet_nud.Value);
            //Secilen adet kadar Buzdolabı'nın kdv'li fiyatı hesaplanarak bilgileriyle birlikte Listboxlara ekleniyor

            if (Fridge.SecilenAdet > 0 && (Fridge.StokAdedi - Fridge.SecilenAdet) >= 0)
            {
                fiyat_lb.Items.Add(Sepetim.SepeteUrunEkle(Fridge));
                isim_lb.Items.Add(Fridge.Ad);
                adet_lb.Items.Add(Fridge.SecilenAdet);
                Fridge.StokAdedi -= Fridge.SecilenAdet;
            }

            Pc.SecilenAdet = Convert.ToInt32(LaptopAdet_nud.Value);
            //Secilen adet kadar Bilgisayar'ın kdv'li fiyatı hesaplanarak bilgileriyle birlikte Listboxlara ekleniyor
            if (Pc.SecilenAdet > 0 && (Fridge.StokAdedi - Pc.SecilenAdet) >= 0)
            {
                fiyat_lb.Items.Add(Sepetim.SepeteUrunEkle(Pc));
                isim_lb.Items.Add(Pc.Ad);
                adet_lb.Items.Add(Pc.SecilenAdet);
                Pc.StokAdedi -= Pc.SecilenAdet;
            }

            Telefon.SecilenAdet = Convert.ToInt32(TelAdet_nud.Value);
            //Secilen adet kadar Telefon'un kdv'li fiyatı hesaplanarak bilgileriyle birlikte Listboxlara ekleniyor
            if (Telefon.SecilenAdet > 0 && (Telefon.StokAdedi - Telefon.SecilenAdet) >= 0)
            {
                fiyat_lb.Items.Add(Sepetim.SepeteUrunEkle(Telefon));
                isim_lb.Items.Add(Telefon.Ad);
                adet_lb.Items.Add(Telefon.SecilenAdet);
                Telefon.StokAdedi -= Telefon.SecilenAdet;
            }

            //Adet sayacını sıfırlayan ve stok labelını güncelleyen fonksiyon cağrılıyor
            sifirla();

            int toplam = 0;
            //Kdv'li fiyatlar toplanarak değişkene aktarılıyor
            for (int i = 0; i < fiyat_lb.Items.Count; i++)
            {
                    toplam += Convert.ToInt32(fiyat_lb.Items[i]);
                
            }
            //Toplam fiyat gerekli labela yazdırılıyor
            Toplam_lbl.Text = toplam.ToString() + "TL";

        }

        //Ürünleri Sil butonu Basıldığında çalışan fonksiyon
        private void Sil_Click(object sender, EventArgs e)
        {
            //Adet listboxunda kaç tane eleman varsa o sayı kadar döndürüyor, Listboxun elemanları arasında gezinmemizi sağlıyor
            for (int i = 0; i < adet_lb.Items.Count; i++)
            {
                
                //Gelen Adet sayısının satırındaki ürün ismine eşitse Adet sayısınını o ürünün stoğuna ekliyor
                if (isim_lb.Items[i].ToString() == "Buzdolabi")
                {
                    Fridge.StokAdedi += Convert.ToInt32(adet_lb.Items[i]);
                }

                else if (isim_lb.Items[i].ToString() == "Led Tv")
                {
                    Tv.StokAdedi += Convert.ToInt32(adet_lb.Items[i]);
                }

                else if (isim_lb.Items[i].ToString() == "Bilgisayar")
                {
                    Pc.StokAdedi += Convert.ToInt32(adet_lb.Items[i]);
                }

                else
                {
                    Telefon.StokAdedi += Convert.ToInt32(adet_lb.Items[i]);
                }
            }

            //Adet sayacını sıfırlayan ve stok labelını güncelleyen fonksiyon cağrılıyor
            sifirla();
            //Listboxlar sıfırlanıyor
            fiyat_lb.Items.Clear();
            isim_lb.Items.Clear();
            adet_lb.Items.Clear();
            Toplam_lbl.Text = "--";
        }
    }
    class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public double HamFiyat;
        public int StokAdedi;
        public int SecilenAdet;
        public int KdvOrani;
        public double KdvliFiyat;
        //Kdv Hesaplıyor
        public void KdvHesap(int KdvOran)
        {
            this.KdvliFiyat = (HamFiyat + ((HamFiyat * KdvOran) / 100));
        }
        //Gelen değerleri ilgili değişkenlere atıyor
        public void Ata(string Ad, string Marka, string Model, string Ozellik, double HamFiyat, Random Rastgele, int Oran)
        {
            this.Ad = Ad;
            this.Marka = Marka;
            this.Model = Model;
            this.Ozellik = Ozellik;
            this.HamFiyat = HamFiyat;
            this.StokAdedi = Rastgele.Next(1, 100);
            this.KdvOrani = Oran;
        }

    }
    class Buzdolabi : Urun
    {
        public double IcHacim;
        public string EnerjiSinifi;
        public Buzdolabi(string Ad, string Marka, string Model, string Ozellik, double HamFiyat, double IcHacim, string EnerjiSinifi, Random Rastgele, int Oran)
        {
            Ata(Ad, Marka, Model, Ozellik, HamFiyat, Rastgele, Oran);
            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;
        }

    }

    class LedTv : Urun
    {
        public double EkranBoyutu;
        public string EkranCozunurlugu;
        public LedTv(string Ad, string Marka, string Model, string Ozellik, double HamFiyat, double EkranBoyutu, string EkranCozunurlugu, Random Rastgele, int Oran)
        {
            Ata(Ad, Marka, Model, Ozellik, HamFiyat, Rastgele, Oran);
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurlugu = EkranCozunurlugu;
        }
    }
    class CepTel : Urun
    {
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;
        public CepTel(string Ad, string Marka, string Model, string Ozellik, double HamFiyat, int DahiliHafiza, int RamKapasitesi, int PilGucu, Random Rastgele, int Oran)
        {
            Ata(Ad, Marka, Model, Ozellik, HamFiyat, Rastgele, Oran);
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;
        }
    }
    class Laptop : Urun
    {
        public double EkranBoyutu;
        public string EkranCozunurluk;
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;
        public Laptop(string Ad, string Marka, string Model, string Ozellik, double HamFiyat, double EkranBoyutu, string EkranCozunurluk, int DahiliHafiza, int RamKapasitesi, int PilGucu, Random Rastgele, int Oran)
        {
            Ata(Ad, Marka, Model, Ozellik, HamFiyat, Rastgele, Oran);
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurluk = EkranCozunurluk;
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;
        }

    }

    class Sepet
    {
        public double SepeteUrunEkle(Urun GelenUrun)
        {
            GelenUrun.KdvHesap(GelenUrun.KdvOrani);
            return (GelenUrun.KdvliFiyat * GelenUrun.SecilenAdet);
        }
    }
}
