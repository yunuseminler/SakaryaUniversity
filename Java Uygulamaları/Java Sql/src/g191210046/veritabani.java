package g191210046;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class veritabani {
	String url = "jdbc:postgresql://localhost:5432/girisBilgileri";
	Connection conn = null;
	
	public void baglan(){
		try {
			conn = DriverManager.getConnection(url,"postgres","1140");
		} catch (SQLException e) {
			System.out.println("Bağlantı başarısız");
		}
	}
	
	public void baglantiyiKes() {
		try {
			conn.close();
		} catch (SQLException e) {
			System.out.println("Bağlantı kesilmedi");
		}
	}
	
	public boolean kontrolEt(String deger,String sutun){
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
