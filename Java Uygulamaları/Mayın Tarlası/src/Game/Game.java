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
		this.mayinSayisi =((this.satir*this.sutun)/4);
		this.mayinlar = new int [this.mayinSayisi][2]; 
		mayinKoy();
		
	}
	public void run() {
		sifirla();
		while(true) {
			ekranaYaz();
			input();
			
			if(kontrol()){
				System.out.println("Oyun bitti kaybettiniz.");
				break;
			}
			else {
				hesapla();
				if(isWin()){
					ekranaYaz();
					System.out.println("Tebrikler kazandınız");
					break;
				}
			}
		}
		
	}
	public Boolean isWin() {
		for(int i = 0;i<this.mayinSayisi;i++) {
			this.game[this.mayinlar[i][0]][this.mayinlar[i][1]] = "*";
		}
		for(int i = 0;i<this.satir;i++) {
			for(int j = 0;j<this.sutun;j++) {
				if(this.game[i][j].equals("-")) {
					for(int n = 0;n<this.mayinSayisi;n++) {
						this.game[this.mayinlar[n][0]][this.mayinlar[n][1]] = "-";
					}
					return false;
				}
			}
			
		}
		
		return true;
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
	public void hesapla() {
		int mayinSayi = 0;
		for(int i = 0;i<this.mayinSayisi;i++) {
			if(this.mayinlar[i][0]==this.inputSatir || this.mayinlar[i][0]==(this.inputSatir-1) || this.mayinlar[i][0]==(this.inputSatir+1)) {
				if(this.mayinlar[i][1]==this.inputSutun || this.mayinlar[i][1]==(this.inputSutun-1) || this.mayinlar[i][1]==(this.inputSutun+1)) {
					mayinSayi++;
				}
			}
		}
		this.game[this.inputSatir][this.inputSutun]= String.valueOf(mayinSayi);
	}
	public void input() {
		Scanner scan = new Scanner(System.in);
		System.out.print("Satir giriniz: ");
		this.inputSatir = (scan.nextInt());
		System.out.print("Sutun giriniz: ");
		this.inputSutun  = (scan.nextInt());
	}
	public Boolean kontrol() {
		for(int i = 0;i<this.mayinSayisi;i++) {
			if(this.mayinlar[i][0]==(this.inputSatir)) {
				if(this.mayinlar[i][1]==(this.inputSutun)) {
					return true;
				}
			}
		}
		return false;
	}
	public void sifirla() {
		for(int i = 0;i<this.satir;i++) {
			for(int j = 0;j<this.sutun;j++) {
				this.game[i][j] = "-";
			}
		}
	}
	public void ekranaYaz() {
		System.out.print(" ");
		for(int j = 0;j<this.sutun;j++) {
			System.out.print(" " + j);
		}
		System.out.print("\n");
		for(int i = 0;i<this.satir;i++) {
			System.out.print(i);
			for(int j = 0;j<this.sutun;j++) {
				System.out.print(" " + this.game[i][j]);
			}
			System.out.print("\n");
		}
	} 
}
