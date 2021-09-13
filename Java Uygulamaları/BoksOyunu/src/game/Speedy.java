package game;

import java.util.Random;

public class Speedy extends Fighter {

	public Speedy(String name, int age, int dodgeChance, int maxDamage, int minDamage) {
		super(name, age, dodgeChance, maxDamage, minDamage);
	}
	
	@Override
	public int attack() {
		Random r = new Random();
		int damage = r.nextInt((maxDamage+1)-minDamage) + minDamage;
		if(0 == r.nextInt(2)) {
			damage = this.skill(damage);
			System.out.println("Speedy yeteneğini kullandı");
		}
		return damage;
	}
	@Override
	public int skill(int damage) {
		return damage *= 2;
	}
}
