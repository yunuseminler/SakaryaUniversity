package Game;
import java.util.Random;
import java.util.Scanner;

public class Game {
	public String[][] game;
	int satir;
	int sutun;
	int inputSatir; 
	int inputSutun;
	int[] mayin;
	
	public Game(int satir,int sutun) {
		this.satir = satir;
		this.sutun = sutun;
		game = new String[this.satir][this.sutun];
		mayin = new int[((satir*sutun)/4)*2];
		for(int i = 0;i<mayin.length;i++) {
			mayin[i] = -1;
		}
		mayinKoy();
		
	}
	public void run() {
		sifirla();
		while(true) {
			ekranaYaz();
			input();
			if(kontrol(inputSatir,inputSutun)){
				System.out.println("Oyun bitti kaybettiniz.");
				break;
			}
		}
		
	}
	public void mayinKoy() {
		Random r = new Random();
		for(int i = 0;i<mayin.length;i+=2) {
			
		}
		
	}
	
	public void input() {
		Scanner scan = new Scanner(System.in);
		System.out.print("Satir giriniz: ");
		inputSatir = scan.nextInt();
		System.out.print("Sutun giriniz: ");
		inputSutun  = scan.nextInt();
		scan.close();
	}
	public Boolean kontrol(int sa,int su) {
		if(game[sa-1][su-1].equals("e")) {
			
		}
		return false;
	}
	
	public void sifirla() {
		for(int i = 0;i<satir;i++) {
			for(int j = 0;j<sutun;j++) {
				game[i][j] = "-";
			}
		}
	}
	
	
	public void ekranaYaz() {
		for(int i = 0;i<satir;i++) {
			for(int j = 0;j<sutun;j++) {
				System.out.print(" " + game[i][j]);
			}
			System.out.print("\n");
		}
	} 
}
