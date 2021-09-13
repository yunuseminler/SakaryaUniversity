package game;

import java.util.Random;

public class Fighter {
	 String name;
	 int age;
	 double health;
	 int maxDamage;
	 int minDamage;
	 int dodgeChance;
	 int life;
	
	public Fighter(String name,int age,int dodgeChance,int maxDamage,int minDamage) {
		this.name = name;
		this.age = age;
		this.health = 100;
		this.maxDamage = maxDamage;
		this.minDamage = minDamage;
		this.dodgeChance =  dodgeChance;
		this.life = 1;
	}
	public int attack() {
		Random r = new Random();
		return r.nextInt((maxDamage+1)-minDamage) + minDamage;
	}
	
	public int skill(int damage) {
		return 0;
	}

}
