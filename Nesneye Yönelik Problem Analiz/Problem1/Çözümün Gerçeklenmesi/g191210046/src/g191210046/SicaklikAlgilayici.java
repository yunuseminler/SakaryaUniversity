package g191210046;
import java.util.Random;

public class SicaklikAlgilayici implements Bildirim{
	int sicaklik;
	
	@Override
	public void bildir(){
		System.out.println("Sicaklik = "+ sicaklik + " °C");	
	}
	
	public void sicaklikOlc() {
		Random r= new Random();
		sicaklik = r.nextInt(30)-10;
	}
}
