package Game;
import java.util.Random;
import java.util.Scanner;

public class Game {
	public String[][] game;
	int satir;
	int sutun;
	int inputSatir; 
	int inputSutun;
	int mayinSayisi;
	int mayinlar[][];
	
	public Game(int satir,int sutun) {
		this.satir = satir;
		this.sutun = sutun;
		this.game = new String[this.satir][this.sutun];
		this.mayinSayisi =((satir*sutun)/4);
		this.mayinlar = new int [this.mayinSayisi][2]; 
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
		for(int i = 0;i<this.mayinSayisi;i++) {
				int temp = 0;
				int temp1 = 0;
				Boolean a = false;
				while(a==false) {
				temp = r.nextInt(this.satir);
				temp1 = r.nextInt(this.sutun);
				if(i==0) {
					a = true;
				}
				for(int j = 0;j<i;j++) {
					if(!(this.mayinlar[j][0] == temp)) {
						if(!(this.mayinlar[j][1]==temp1)) {
							a = true;
						}
					}
				}
				if(a==true) {
					break;
				}
					
				}
				this.mayinlar[i][0] = temp;
				this.mayinlar[i][1] = temp1;
		}
		
	}
	public Boolean kontrolMayin(int sa,int su) {
		return false;
	}
	public void input() {
	
		Scanner scan = new Scanner(System.in);
		System.out.print("Satir giriniz: ");
		this.inputSatir = scan.nextInt();
		System.out.print("Sutun giriniz: ");
		this.inputSutun  = scan.nextInt();
		scan.close();
	}
	public Boolean kontrol(int sa,int su) {
		for(int i = 0;i<this.mayinSayisi;i++) {
			if(this.mayinlar[i][0]==sa) {
				if(this.mayinlar[i][1]==su) {
					return true;
				}
			}
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
