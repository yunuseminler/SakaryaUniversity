package game;

import java.util.Random;

public class Balancer extends Fighter{
	public int skill;

	public Balancer(String name, int age, int dodgeChance, int maxDamage, int minDamage) {
		super(name, age, dodgeChance, maxDamage, minDamage);
		skill = 0;
		// TODO Auto-generated constructor stub
	}
	@Override
	public int attack() {
		Random r = new Random();
		int damage = r.nextInt((maxDamage+1)-minDamage) + minDamage;
		if(this.skill > 0) {
			this.skill--;
			return damage + 2;
		}
		else if(0 == r.nextInt(5)) {
			damage = this.skill(damage);
			System.out.println("Balancer yeteneğini kullandı");
		}
		return damage;
	}
	@Override
	public int skill(int damage) {
		this.skill = 3;
		return damage /= 2;
	}
}
