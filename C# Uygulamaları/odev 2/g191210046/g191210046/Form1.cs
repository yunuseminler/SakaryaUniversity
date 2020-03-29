/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2. Ödev
**				ÖĞRENCİ ADI............: Yunus Emre Eminler
**				ÖĞRENCİ NUMARASI.......: G191210046
**              DERSİN ALINDIĞI GRUP...: B grubu
****************************************************************************/

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
        //Butona tıklandığında eklenecek araçlar tanımlanıyor
        Label NewX_lbl;
        Label NewY_lbl;
        Label Toplam_lbl;
        ListBox Xcarpan_lbox;
        ListBox Ycarpan_lbox;
        TextBox XcarpanToplamı_txt;
        TextBox YcarpanToplamı_txt;

        public Form1()
        {
            InitializeComponent();
        }

        //Exit tuşuna basılınca Programın kapanmasını sağlayan fonksiyon
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Butona tıklandığında Yeni araçların özelliklerini ayarlayarak Form'a ekleyen fonksiyon
        private void Olustur()
        {
            this.Width = 600;
            this.Height = 340;
            // Yeni X Labeli
            NewX_lbl = new Label();
            NewX_lbl.AutoSize = true;
            NewX_lbl.Location = new Point(350, 30);
            NewX_lbl.Text = "X";
            NewX_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(NewX_lbl);
            //Yeni Y Labeli
            NewY_lbl = new Label();
            NewY_lbl.AutoSize = true;
            NewY_lbl.Location = new Point(460, 30);
            NewY_lbl.Text = "Y";
            NewY_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(NewY_lbl);
            //X Çarpanları için Yeni List box
            Xcarpan_lbox = new ListBox();
            Xcarpan_lbox.Location = new Point(310, 55);
            Xcarpan_lbox.Size = new System.Drawing.Size(100, 170);
            this.Controls.Add(Xcarpan_lbox);
            //Y Çarpanları için yeni List box
            Ycarpan_lbox = new ListBox();
            Ycarpan_lbox.Location = new Point(420, 55);
            Ycarpan_lbox.Size = new System.Drawing.Size(100, 170);
            this.Controls.Add(Ycarpan_lbox);
            //X carpanlarının toplamı için text box
            XcarpanToplamı_txt = new TextBox();
            XcarpanToplamı_txt.Location = new Point(310, 240);
            XcarpanToplamı_txt.Enabled = false;
            this.Controls.Add(XcarpanToplamı_txt);
            //Y Çarpanlarının toplamı için yeni text box
            YcarpanToplamı_txt = new TextBox();
            YcarpanToplamı_txt.Location = new Point(420, 240);
            YcarpanToplamı_txt.Enabled = false;
            this.Controls.Add(YcarpanToplamı_txt);
            //Toplamları yazan Label
            Toplam_lbl = new Label();
            Toplam_lbl.AutoSize = true;
            Toplam_lbl.Location = new Point(220, 240);
            Toplam_lbl.Text = "Toplamlar";
            Toplam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(Toplam_lbl);

            //X ve Y sayı girişleri engelleniyor.
            x_txt.Enabled = false;
            y_txt.Enabled = false;
        }
        //Girilen sayılar çarpanlara ayrılarak gerekli araçlara yazılıyor
        private void Yaz()
        {
            int y;
            int x;
            //X sayısı girilmesi gereken yer boş mu yada boşluk mu diye kontrol ediliyor
            if (!string.IsNullOrWhiteSpace(x_txt.Text))
            {
                x = Convert.ToInt32(x_txt.Text);
            }
            else
            {
                x = 0;
            }

            //Y sayısı girilmesi gereken yer boş mu yada boşluk mu diye kontrol ediliyor
            if (!string.IsNullOrWhiteSpace(y_txt.Text))
            {
                y = Convert.ToInt32(y_txt.Text);
            }
            else
            {
                y = 0;
            }

            int xToplami = 0;
            int yToplami = 0;
            //X sayisi çarpanlarına ayrılarak toplamları hesaplanıyor
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    Xcarpan_lbox.Items.Add(i);
                    xToplami += i;
                }
            }

            //Y sayisi çarpanlarına ayrılarak toplamları hesaplanıyor
            XcarpanToplamı_txt.Text = xToplami.ToString();
            for (int i = 1; i < y; i++)
            {
                if (y % i == 0)
                {
                    Ycarpan_lbox.Items.Add(i);
                    yToplami += i;
                }
            }
            YcarpanToplamı_txt.Text = yToplami.ToString();
        }

        //Arkadaş mı butonuna tıklandığında gerekli fonksiyonlar çağrılıyor.
        private void friend_btn_Click(object sender, EventArgs e)
        {
            Olustur();
            Yaz();
        }

        //X sayısının girilmesi gereken textbox'ın sadece sayı girilmesini kontrol eden fonksiyon 
        private void x_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !((int)e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        //Y sayısının girilmesi gereken textbox'ın sadece sayı girilmesini kontrol eden fonksiyon
        private void y_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !((int)e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

    }
}
