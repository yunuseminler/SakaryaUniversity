package g191210046;

public class Program implements Observer{//Programin isleyisini saglayan Class tnaimlasi. Builder ve Observer desenini destekler.
	agArayuzu arayuz;
	Eyleyici eyleyici;
	SicaklikAlgilayici sicaklikModul;
	Notif notif;
	
	
	public Program(Builder builder){//Builder nesnesi sayesinde baslangic atamalari yapiliyor ve eyleyici modulunun dinleyicisi olarak tanimlaniyor.
		this.arayuz = builder.arayuz;
        this.eyleyici = builder.eyleyici;
        this.sicaklikModul = builder.sicaklikModul;
		eyleyici.registerObserver(this);
		notif = new Notif();
	}
	
	public void calistir() {//Programi calistirmaya ve islemesine yarayan fonksiyon. Arayuzden dondurulen degere gore islem yapiyor.
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
				System.out.println("Program Sona Ermistir.");
				System.exit(0);
				break;
			}
		}
		
	}
	
	public void update(boolean durum){//Observer Deseninin guncelleme fonksiyonu tanimlamasi.
		if(durum == true) {
			System.out.println("Durum guncellendi. Durum: Acik");
		} else {
			System.out.println("Durum guncellendi. Durum: Kapali");
		}
		
	};
	
	public static class Builder{//Builder deseninin class tanimlamasi
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
