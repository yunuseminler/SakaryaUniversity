package Game;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Oyuna hoşgeldiniz");
		System.out.print("Satir sayisini giriniz: ");
		int satirSayisi = scan.nextInt(); 
		System.out.print("Sutun sayisini giriniz: ");
		int sutunSayisi = scan.nextInt();
		Game game = new Game(satirSayisi,sutunSayisi);
		game.run();
	}

}
