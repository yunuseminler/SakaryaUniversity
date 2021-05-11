package g191210046;
import java.util.Random;

public class SicaklikAlgilayici implements Bildirim{//Sicaklik modulunun class tanimlamasi. Dependency ilkesini destekliyor.
	int sicaklik;
	
	@Override
	public void bildir(){//Dependency ilkesi doğrultusunda kalitim aldiği interface'in fonksiyon tanimi yapiliyor.
		System.out.println("Sicaklik = "+ sicaklik + " °C");	
	}
	
	public void sicaklikOlc() {//Sicaklik değerini -10 ile 20 arasinda rastgele değer atiyor.
		Random r= new Random();
		sicaklik = r.nextInt(30)-10;
	}
}
