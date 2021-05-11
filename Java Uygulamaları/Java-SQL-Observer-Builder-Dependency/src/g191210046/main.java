package g191210046;

public class main {

	public static void main(String[] args) {//Main Fonksiyonu tanimlaniyor
		agArayuzu arayuz = new agArayuzu();
		Eyleyici eyleyici = new Eyleyici();
		SicaklikAlgilayici sicaklikModul = new SicaklikAlgilayici();
		Program programim = new Program.Builder().arayuz(arayuz).eyleyici(eyleyici).sicaklikModul(sicaklikModul).build();//Builder classi kullanilarak program nesnesi oluşturuluyor.
		programim.calistir();
		
		
	}

}