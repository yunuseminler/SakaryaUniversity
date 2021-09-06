
import java.util.Scanner;

public class Not {
    public static void main(String[] args) {

// Değişkenler tanımlandı ve veri girişi için scanner kodu kullanıldı.     
    double mat, fiz, kim, tur, tar, muz;
    Scanner input = new Scanner(System.in);
  
// Kullanıcıdan not değerleri alınarak değişkenlere atandı.       
    System.out.print("Matematik notunuzu giriniz = ");
    mat = input.nextInt();

    System.out.print("Fizik notunuzu giriniz = ");
    fiz = input.nextInt();

    System.out.print("Kimya notunuzu giriniz = ");
    kim = input.nextInt();

    System.out.print("Türkçe notunuzu giriniz = ");
    tur = input.nextInt();

    System.out.print("Tarih notunuzu giriniz = ");
    tar = input.nextInt();

    System.out.print("Müzik notunuzu giriniz = ");
    muz = input.nextInt();

// Değişkenler ile işlemler yapılarak ortalama değer hesaplandı.    
    double toplam = mat+fiz+kim+tur+tar+muz;
    double ortalama = toplam/6;
    
// Bulunan sonuç istenen koşul ile sorgulanarak ekrana yazdırıldı.
    System.out.println("Ortamanız = " + ortalama);
    boolean kosul1 = ortalama >= 50;
    System.out.println("Durum = " + (kosul1==true ? "Geçti" : "Kaldı"));
    
    }
}