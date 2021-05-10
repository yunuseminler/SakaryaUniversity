package g191210046;

import java.util.ArrayList;

public class Eyleyici implements Bildirim,Subject{
	private ArrayList observers;
	boolean durum;
	
	public Eyleyici() {
		observers = new ArrayList();
		this.durum= false;
	}
	
	@Override
	public void bildir(){
		if(durum == true){
			System.out.println("Durum: Açık");	
		}
		else {
			System.out.println("Durum: Kapalı");
		}
		
	}
	
	public void sogutucuyuAc(){
		if(!(durum==true)){
			durum = true;
			notifyObservers();
		}
		else {
			notifyObservers();
		}
	}
	public void sogutucuyuKapat(){
		if(!(durum==false)){
			durum = false;
			notifyObservers();
		} else {
			notifyObservers();
		}
		
	}
	public void registerObserver(Observer o) {
        observers.add(o);
    }
           
    public void removeObserver(Observer o) {
        int i = observers.indexOf(o);
        if (i >= 0) {
            observers.remove(i);
        }
    }
           
    public void notifyObservers() {
        for (int i = 0; i < observers.size(); i++) {
            Observer observer = (Observer)observers.get(i);
            observer.update(this.durum);
        }
    }
        
}
