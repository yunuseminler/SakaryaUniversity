package g191210046;
import java.util.Scanner;

public class agArayuzu {//Kullanicinin islemlerini yaptigi arayuzun class tanimlamasidir.
	Scanner girdi = new Scanner(System.in);
	String kullanici;
	String sifre;
	veritabani veritabanim;
	
	public agArayuzu() {//Yapici fonksiyonda veritabani ile baglanti saglaniyor.
		veritabanim = new veritabani();
		veritabanim.baglan();
	}
	public void basla(){//Ekrana giris ekranini yazdiriyor. Kullanici islemlerinden once dogrulama saglaniyor.
		System.out.println("Hosgeldiniz \n");
		while(true){
			System.out.print("Kullanici adi: ");
			kullanici = girdi.next();
			if(veritabanim.kontrolEt(kullanici,"kullaniciAdi")) {//girilen degerin veritabaninda olup olmadigi kontrol ediliyor.
				int i;
				for(i = 3;i>0;i--) {
					System.out.print("Sifre: ");
					sifre = girdi.next();
					if(veritabanim.kontrolEt(sifre,"sifre")) {
						System.out.println("Giris basarili.");
						veritabanim.baglantiyiKes();
						break;
						
					}
					else {
						System.out.println(i-1 + " yanlis hakkiniz kaldi tekrar deneyiniz");

					}
				}
				if(i == 0) {
					System.out.println("\nisleminiz iptal olmustur. Tekrar deneyin.");
				}
				else {break;}
				
			} 
			else {
				System.out.println("Kullanici adiniz hatalidir tekrar deneyiniz.");
			}
		}
		
		
	}
	public String ekranaYaz(){//Menu arayuzunu ekrana yazdiran fonksiyon. Girilen degeri geri dondurur.
		String islem;
		while(true) {
			System.out.println("\n1) Sogutucuyu Ac");
			System.out.println("2) Sogutucuyu Kapat");
			System.out.println("3) Sicaklik Goster");
			System.out.println("4) cikis Yap");
			System.out.print("Yapilacak islemi seciniz: ");
			islem = girdi.next();
			if(islem == "1" || islem == "2" || islem == "3") {
				System.out.println("Gecerli islem numarasi giriniz.");
			}
			else {
				break;
			}
		}
		return islem;


		
	}
}
