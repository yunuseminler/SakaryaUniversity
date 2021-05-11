package g191210046;

public interface Subject {//Observer deseni icin Subject interface'i tanimlaniyor
	public void registerObserver(Observer o);
    public void removeObserver(Observer o);
    public void notifyObservers();
}
