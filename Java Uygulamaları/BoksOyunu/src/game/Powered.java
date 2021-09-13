package game;

import java.util.Random;

public class Powered extends Fighter{

	public Powered(String name, int age, int dodgeChance, int maxDamage, int minDamage) {
		super(name, age, dodgeChance, maxDamage, minDamage);
		// TODO Auto-generated constructor stub
	}
	@Override
	public int attack() {
		Random r = new Random();
		int damage = r.nextInt((maxDamage+1)-minDamage) + minDamage;
		if(0 == r.nextInt(5)) {
			damage = this.skill(damage);
			System.out.println("Powered yeteneğini kullandı");
		}
		return damage;
	}
	@Override
	public int skill(int damage) {
		return damage *= 2;
	}
}
