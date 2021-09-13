package game;

import java.util.Random;

public class Round {
	Fighter[] fighters;
	public Round(Fighter first, Fighter second){
		fighters = new Fighter[2];
		fighters[0] = first;
		fighters[1] = second;	
	}
	public void roundStart(){
		sleep();
		System.out.println("Round başladı");
		while(true){
			int index = choose();
			int damage = fighters[index].attack();
			sleep();
			System.out.println(fighters[index].name + " " + damage + "Hasar verdi");
			for(int i = 0;i<fighters.length;i++) {
				if(!(i==index)) {
					if(dodge(fighters[i])){
						System.out.println(fighters[i].name + " hasardan kaçındı");
					}
					else {
						if((fighters[i].health - damage) >0) {
							fighters[i].health -= damage;
						}
						else {
							fighters[i].life = 0;
						}
					}
				}
			}
			
			if(fighters[0].life == 0 || fighters[1].life == 0) {
				break;
			}
		}
		
		for(int i = 0;i<fighters.length;i++) {
			if(fighters[i].life == 0) {
				if(i==0) {
					System.out.println(fighters[i+1].name + " Kazandı");	
				}
				else {
					System.out.println(fighters[i-1].name + " Kazandı");
				}
				
			}
		}
		
	}
	public void sleep() {
		Random r = new Random();
		try {
			Thread.sleep(r.nextInt(800)+400);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	public int choose() {
		Random r = new Random();
		return r.nextInt(2);
	}
	public Boolean dodge(Fighter a){
		Random r = new Random();
		if(0 == r.nextInt(100/a.dodgeChance)) {
			return true;
		}
		return false;
	}
}
