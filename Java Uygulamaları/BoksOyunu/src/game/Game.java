package game;
import java.util.Scanner;
import java.util.Random;


public class Game {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Random r = new Random();
		int _secim;
		Ring ring = new Ring();
		System.out.println("Hoşgeldiniz Lütfen karakterinizi seçiniz");
		ring.ekranaKarakterleriYaz();
		System.out.print("Karakterinizi Seçiniz: ");
		while(true) {
			String secim = scan.nextLine();	
			if(secim.equals("1")||secim.equals("2")||secim.equals("3")||secim.equals("4")) {
				_secim = Integer.parseInt(secim)-1;
				break;
			}
			else {
				System.out.print("Yanlış secim yaptınız lütfen tekrar seciniz: ");
			}
		}
		int rakip;
		while(true) {
			rakip = r.nextInt(4);
			if(!(rakip == _secim)) {break;}
		}
		System.out.print("Seciminiz: " + ring.fighters[_secim].name + "\nRakibiniz: " + ring.fighters[rakip].name + "\n");
		ring.roundStart(_secim,rakip);
		scan.close();
	}

}
