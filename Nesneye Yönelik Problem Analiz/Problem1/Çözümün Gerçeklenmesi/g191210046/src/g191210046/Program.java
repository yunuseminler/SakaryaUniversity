package g191210046;

public class Program implements Observer{
	agArayuzu arayuz;
	Eyleyici eyleyici;
	SicaklikAlgilayici sicaklikModul;
	Notif notif;
	
	
	public Program(Builder builder){
		this.arayuz = builder.arayuz;
        this.eyleyici = builder.eyleyici;
        this.sicaklikModul = builder.sicaklikModul;
		eyleyici.registerObserver(this);
	}
	
	public void calistir() {
		notif = new Notif();
		arayuz.basla();
		while(true) {
			String islem = arayuz.ekranaYaz();
			switch(islem) {
			case "1":
				eyleyici.sogutucuyuAc();
				break;
			case "2":
				eyleyici.sogutucuyuKapat();
				break;
			case "3":
				sicaklikModul.sicaklikOlc();
				notif.bildir(sicaklikModul);
				break;
			case "4":
				System.out.println("Program Sona Ermiştir.");
				System.exit(0);
				break;
			}
		}
		
	}
	
	public void update(boolean durum){
		if(durum == true) {
			System.out.println("Durum güncellendi. Durum: Açık");
		} else {
			System.out.println("Durum güncellendi. Durum: Kapalı");
		}
		
	};
	
	public static class Builder{
		agArayuzu arayuz;
		Eyleyici eyleyici;
		SicaklikAlgilayici sicaklikModul;

        public Builder(){ }

        public Builder arayuz(agArayuzu arayuz){
            this.arayuz = arayuz;
            return this;
        }
        
        public Builder eyleyici(Eyleyici eyleyici){
            this.eyleyici = eyleyici;
            return this;
        }
        
        public Builder sicaklikModul(SicaklikAlgilayici sicaklikModul){
            this.sicaklikModul = sicaklikModul;
            return this;
        }

        public Program build(){
            return new Program(this);
        }

    }
}
