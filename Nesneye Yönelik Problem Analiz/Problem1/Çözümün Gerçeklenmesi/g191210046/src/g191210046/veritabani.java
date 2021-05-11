package g191210046;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class veritabani {//Program ile veritabani arasindaki bağlantiyi kuran ve kontrol eden class tanimlamasi.
	String url = "jdbc:postgresql://localhost:5432/girisBilgileri";
	Connection conn = null;
	
	public void baglan(){//Veritabani ile program arasindaki ilk bağlantiyi gerceklestiren fonskiyon.
		try {
			conn = DriverManager.getConnection(url,"postgres","1140");
		} catch (SQLException e) {
			System.out.println("Bağlanti basarisiz");
		}
	}
	
	public void baglantiyiKes() {//Veritabani ile program arasindaki bağlantiyi sonlandiran fonskiyon.
		try {
			conn.close();
		} catch (SQLException e) {
			System.out.println("Bağlanti kesilmedi");
		}
	}
	
	public boolean kontrolEt(String deger,String sutun){//Gonderilen değeri veri tabaninda arayan fonksiyon. Var ise true yok ise false donduruyor.
		try {
			String sorgu = "SELECT * FROM \"Kullanici\" WHERE \""+ sutun +"\" = '"+ deger +"'";
			Statement st = conn.createStatement();
			ResultSet rs = st.executeQuery(sorgu);
			rs.next();
			if(rs.getString(sutun)== null) {
				return false;
			}
			else{
				return true;
			}
			
		} catch (SQLException e) {
			return false;
		}
	}

}
