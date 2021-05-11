package g191210046;

public class Notif{//Dependency ilkesi dogrultusunda bagimliligi ortadan kaldirmak icin tanimlanan yardimci class.
	private Bildirim message;

    public void bildir(Bildirim mesaj) {//Gonderilen Bildirim nesnesin bildir fonksiyonunu cagiriyor.
    		this.message = mesaj;
    		this.message.bildir();
    }
    
}
