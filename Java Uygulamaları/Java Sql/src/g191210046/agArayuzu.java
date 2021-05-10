package g191210046;
import java.util.Scanner;

public class agArayuzu {
	Scanner girdi = new Scanner(System.in);
	String kullanici;
	String sifre;
	veritabani veritabanim;
	
	public agArayuzu() {
		veritabanim = new veritabani();
		veritabanim.baglan();
	}
	public void basla(){
		while(true){
			System.out.println("Hoşgeldiniz \n");
			System.out.print("Kullanici adi: ");
			kullanici = girdi.next();
			if(veritabanim.kontrolEt(kullanici,"kullaniciAdi")) {
				int i;
				for(i = 3;i>0;i--) {
					System.out.print("Sifre: ");
					sifre = girdi.next();
					if(veritabanim.kontrolEt(sifre,"sifre")) {
						System.out.println("Giriş başarılı.");
						veritabanim.baglantiyiKes();
						break;
						
					}
					else {
						System.out.println(i-1 + " yanlış hakkiniz kaldı tekrar deneyiniz");

					}
				}
				if(i == 0) {
					System.out.println("\nIşleminiz iptal olmuştur. Tekrar deneyin.");
				}
				else {break;}
				
			} 
			else {
				System.out.println("Kullanici adınız hatalıdır tekrar deneyiniz.");
			}
		}
		
		
	}
	public String ekranaYaz(){
		String islem;
		while(true) {
			System.out.println("\n1) Sogutucuyu Aç");
			System.out.println("2) Sogutucuyu Kapat");
			System.out.println("3) Sıcaklık Göster");
			System.out.println("4) Çıkış Yap");
			System.out.print("Yapılacak işlemi seçiniz: ");
			islem = girdi.next();
			if(islem == "1" || islem == "2" || islem == "3") {
				System.out.println("Gecerli islem numarası giriniz.");
			}
			else {
				break;
			}
		}
		return islem;


		
	}
}
