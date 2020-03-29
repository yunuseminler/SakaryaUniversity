/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1. Odev
**				ÖĞRENCİ ADI............: Yunus Emre Eminler
**				ÖĞRENCİ NUMARASI.......: g191210046
**              DERSİN ALINDIĞI GRUP...: 2. Ogretim B grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g191210046
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ogrNotuSayisi = new int[9];
            int ogrSayisi = 0;
            string[] harfNotlari = new string[] { "AA", "BA", "BB", "CB", "CC", "DC", "DD", "FD", "FF" };

            FileStream fs = new FileStream("kayit.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           
            string metin = sr.ReadLine();
            //Dosyanın Sonuna kadar okuyoruz
            while (metin != null)
            {
                string[] okunanSatir = metin.Split();
                string ad = okunanSatir[0];
                string soyad = okunanSatir[1];
                string ogrNo = okunanSatir[2];
                double odevNotu;

                //Okunan deger gr'ye eşitmi diye bakıyoruz değilse okunan degeri atıyoruz
               if (okunanSatir[3] == "gr") {
                         odevNotu = 0;
               }
                else {  
                    odevNotu  = Convert.ToDouble(okunanSatir[3]);
                }

                double vizeNotu;
                
                //Okunan deger gr'ye eşitmi diye bakıyoruz değilse okunan degeri atıyoruz
                if (okunanSatir[4] == "gr")
                {
                    vizeNotu = 0;
                }
                else
                {
                    vizeNotu = Convert.ToDouble(okunanSatir[4]);
                }
               
                double finalNotu;

                //Okunan deger gr'ye eşitmi diye bakıyoruz değilse okunan degeri atıyoru<
                if (okunanSatir[5] == "gr")
                {
                    finalNotu = 0;
                }
                else
                {
                    finalNotu = Convert.ToDouble(okunanSatir[5]);
                }

                double odevEtkisi = Convert.ToDouble(okunanSatir[6]);
                double vizeEtkisi = Convert.ToDouble(okunanSatir[7]);
                double finalEtkisi = Convert.ToDouble(okunanSatir[8]);
                double ogrNotu = (odevNotu * odevEtkisi / 100) + (vizeNotu * vizeEtkisi / 100) + (finalNotu * finalEtkisi / 100);
                
                //Ogrenci Notundan kaçar tane oldugunu ogrenmek icin 9 elemanlı bir diziyle sayıyoruz. dizinin her bir elemanı bir harf notunu temsil ediyor.
                if (ogrNotu >= 90)
                {
                    ogrNotuSayisi[0]++;
                }
                else if (ogrNotu >= 85)
                {
                    ogrNotuSayisi[1]++;
                }
                else if (ogrNotu >= 80)
                {
                    ogrNotuSayisi[2]++;
                }
                else if (ogrNotu >= 75)
                {
                    ogrNotuSayisi[3]++;
                }
                else if (ogrNotu >= 65)
                {
                    ogrNotuSayisi[4]++;
                }
                else if (ogrNotu >= 58)
                {
                    ogrNotuSayisi[5]++;
                }
                else if (ogrNotu >= 50)
                {
                    ogrNotuSayisi[6]++;
                }
                else if (ogrNotu >= 40)
                {
                    ogrNotuSayisi[7]++;
                }
                else
                {
                    ogrNotuSayisi[8]++;
                }

                metin = sr.ReadLine();
            }

            //Sinif yüzde hesabi yapmak için Ogrenci Sayısını hesaplıyoruz
            for (int i = 0; i < 9; i++)
            {
                ogrSayisi = ogrSayisi + ogrNotuSayisi[i];
            }
            sr.Close();
            fs.Close();

            FileStream fs1 = new FileStream("sonuc.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
           
            //Dosyaya istatistikleri yazdırıyoruz.
            for (int i = 0; i < 9; i++) {
                sw.WriteLine(harfNotlari[i] + " Harf notuna sahip " + ogrNotuSayisi[i] + " Ogrenci var. Sınıfın " + (ogrNotuSayisi[i] * 100 / ogrSayisi) + "%'u " + harfNotlari[i] + " Harf notuna sahip.");
            }

            sw.Flush();
            sw.Close();
            fs1.Close();

        }

    }
}
