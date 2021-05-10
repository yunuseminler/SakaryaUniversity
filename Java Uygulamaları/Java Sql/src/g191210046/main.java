package g191210046;

public class main {

	public static void main(String[] args) {
		agArayuzu arayuz = new agArayuzu();
		Eyleyici eyleyici = new Eyleyici();
		SicaklikAlgilayici sicaklikModul = new SicaklikAlgilayici();
		Program programim = new Program.Builder().arayuz(arayuz).eyleyici(eyleyici).sicaklikModul(sicaklikModul).build();
		programim.calistir();
		
		
	}

}
