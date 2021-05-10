package g191210046;

public class Notif{
	private Bildirim message;

    public void bildir(Bildirim mesaj) {
    		this.message = mesaj;
    		this.message.bildir();
    }
    
}
