/** *
* @author Yunus Emre Eminler g191210046 yunus.eminler@sakarya.edu.tr
* @since 3 Nisan 2021
* <p>
* 	Bu class dosya islemlerinin yonetilmesini saglayan class yapısından bir nesne oluşturur ve gerekli fonksiyonu çagirir.
*  */


package g191210046;
import java.io.IOException;

public class main {

	public static void main(String[] args) throws IOException {//İhtiyacımız olan sınıftan nesne tanımlaması yapılıyor ve gerekli fonksiyon çağrılıyor.
		Dosya dosyam = new Dosya();
		dosyam.fileRead();
	}

}
