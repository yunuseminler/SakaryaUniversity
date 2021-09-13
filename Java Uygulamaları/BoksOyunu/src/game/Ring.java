package game;

public class Ring {
	public Fighter[] fighters = new Fighter[4];
	public Round round;
	public Ring() {
		fighters[0] = new Speedy("Speedy",22,10,6,3);
		fighters[1] = new Lifter("Lifter",30,4,9,7);	
		fighters[2] = new Balancer("Balancer",25,3,10,7);	
		fighters[3] = new Powered("Powered",35,1,7,5);	
	}
	public void roundStart(int first,int second) {
		round = new Round(fighters[first],fighters[second]);
		round.roundStart();
	}
	public void ekranaKarakterleriYaz() {
		for(int i = 0;i< 6;i++) {
			for(int j = 0;j<this.fighters.length;j++) {
				if(i==0) {
					System.out.format("%-11s: %-8s ", "Ad", this.fighters[j].name);
				}
				else if(i==1) {
					System.out.format("%-11s: %-8d ", "Yas", this.fighters[j].age);
				}
				else if(i==2) {
					System.out.format("%-11s: %-8d ", "Max Hasar", this.fighters[j].maxDamage);
				}
				else if(i==3) {
					System.out.format("%-11s: %-8d ", "Min Hasar", this.fighters[j].minDamage);
				}
				else if(i==4){
					System.out.format("%-11s: %-8d ", "Dodge Sansi", this.fighters[j].dodgeChance);
				}
				else {
					System.out.format("     %-16d ", j+1);
				}
			}
			System.out.print("\n");
		}
	};
	
}
