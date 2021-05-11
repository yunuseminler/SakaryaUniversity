package g191210046;

import java.util.ArrayList;

public class Eyleyici implements Bildirim,Subject{//Eyleyici modulunun class tanimlamasi. Observer tasarim deseninin ve Dependency ilkesini destekliyor.
	private ArrayList observers;
	boolean durum;
	
	public Eyleyici() {//Eyleyici modulunun yapici fonksiyonu.
		observers = new ArrayList();
		this.durum= false;
	}
	
	@Override
	public void bildir(){//Dependency ilkesi dogrultusunda kalitim aldigi interface'in fonksiyon tanimi yapiliyor.
		if(durum == true){
			System.out.println("Durum: Acik");	
		}
		else {
			System.out.println("Durum: Kapali");
		}
		
	}
	
	public void sogutucuyuAc(){//Sogutucuyu acmaya yarayan fonksiyon. Sonucunda Observerlar uyariliyor.
		if(!(durum==true)){
			durum = true;
			notifyObservers();
		}
		else {
			notifyObservers();
		}
	}
	public void sogutucuyuKapat(){//Sogutucuyu kapatmaya yarayan fonksiyon. Sonucunda Observerlar uyariliyor.
		if(!(durum==false)){
			durum = false;
			notifyObservers();
		} else {
			notifyObservers();
		}
		
	}
	public void registerObserver(Observer o) {//Listeye Observer eklemek icin kullanilan fonksiyon.
        observers.add(o);
    }
           
    public void removeObserver(Observer o) {//Listeden observer cikarmak icin kullanilan fonksyon.
        int i = observers.indexOf(o);
        if (i >= 0) {
            observers.remove(i);
        }
    }
           
    public void notifyObservers() {//Observerlari uayarmaya yarayan fonksiyon.
        for (int i = 0; i < observers.size(); i++) {
            Observer observer = (Observer)observers.get(i);
            observer.update(this.durum);
        }
    }
        
}
