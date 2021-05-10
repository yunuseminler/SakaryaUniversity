
/** *
* @author Yunus Emre Eminler g191210046 yunus.eminler@sakarya.edu.tr
* @since 3 Nisan 2021
* <p>
* 	Bu class dosya islemlerinin yonetilmesini ve kontrollerini saglar.
* </p>
*  */

package g191210046;

import java.io.*;
import java.util.Scanner;

public class Dosya {
	public void fileRead() throws IOException { //Bu fonksiyon main fonksiyondan çağırılan fonksiyondur. Programın genel işleyişini sağlar. Classları ayıklar.
		File dosyam = new File("program.cpp");
		Scanner dosya = new Scanner(dosyam);
		int sinifSayisi = 0;							//Dosyada okunan sınıfların sayisini tutan değişken
		String[] siniflar = new String[5];				//Dosyada okunan sınıfların isimlerini tutan dizi. Uzunluğu sabit verilmiştir fakat yeni değer eklemek için kullanılan fonksiyonda kontrolleri yapılmıştır.
		int[] tekrar = new int[5];						//Dosyada okunan sınıfların kaç kere tekrar edildiği, kalıtımda kullanıldığının sayısını tutan dizi. Uzunluğu sabit verilmiştir fakat yeni değer eklemek için kullanılan fonksiyonda kontrolleri yapılmıştır.
		while (dosya.hasNextLine()) {
			String text = sonraki(dosya);				//Dosyadaki satır sonraki fonksiyonu sayesinde okunarak gerekli işlemler yapılıyor ve text isimli değişkene atanıyor.
			String[] newText = text.split(" ");			//okunan satır " " karakterine göre parçalanıyor
			String sinifAdi = " ";						//Okunacak olan sınıf adını tutacak olan değişken
			if (newText[0].equals("class")) {			//Parçalanan satırın 1. elemanı "class" kelimesine eşit ise içeriye giriyor.
				sinifSayisi++;							//Yeni bir sınıf okunduğu için sınıfSayisi arttırılıyor.
				if (newText[1].contains("{")) {			//Okunan sınıf isminin sonunda "{" karakteri var ise sınıf isminden çıkartılıyor.
					sinifAdi = newText[1].substring(0, newText[1].length() - 1);
				} else {								//Eğer okunan satır içerisinde ":" karakteri var ise kalıtım aldığı anlaşılıyor. ":" karakterinden öncesi sınıf ismi olarak atanıyor.
					if (newText[1].contains(":")) {
						newText = newText[1].split(":");
						sinifAdi = newText[0];
					} else {							//Eğer hiçbiri yok ise classın yanındakş kelime direkt olarak sınıf ismine atanıyor.
						sinifAdi = newText[1];
					}
				}
				System.out.println("Sınıf: " + sinifAdi + "\n");
				siniflar = ekle(siniflar, sinifSayisi, sinifAdi);//Sınıflar dizisine okunan sınıfın ismi ekle fonksiyonu yardımıyla ekleniyor.
				tekrar = kontrol(tekrar, sinifSayisi);			 //Sınıf sayısı arttırıldığı için tekrar dizisin uzunulupunun yeterli olup olmadığı kontrol eden fonksiyon çağrılıyor.
				newText = text.split(" ");
				int index = (newText.length - 1);				//newText dizisinin son elemanın index numarası alınıyor.
				if(newText[index].equals("{")) {				//Eğer kalıtım alınan sınıf ile "{" karakteri arasında boşluk varsa sondan bir önceki eleman alınır.
					newText[index] = newText[index-1];
				}
				else if (newText[index].contains("{")) {				//Eğer son elemanın son karakteri "{" ise elemandan çıkarılıyor.
					newText[index] = newText[index].substring(0, newText[index].length() - 1);
				}
				for (int i = 0; i < sinifSayisi; i++) {			//Kalıtım alınan sınıf ismi sınıflar dizisinin içerisindeki index numarası bulunuyor ve tekrar dizisinin o index numarasındaki değeri 1 arttırılıyor.
					if (siniflar[i].equals(newText[index])) {
						tekrar[i]++;
					}
				}
				while (true) {								//Class okuması bittiği için "};" karakterlerini görene kadar dosyanın içerisini okumaya devam ediyor.
					text = sonraki(dosya);
					if (text.contains("public")) {			//public satırı bulunduğu için bundan sonrasını değerlendirecektir.
						while (true) {
							text = metodAyikla(text, dosya); //Metodları bulmak için metod ayıkla fonksiyonu çağrılıyor.
							if (text.contains("};")) {
								break;
							}
						}
					}
					if (text.contains("};")) {
						break;
					}
				}

			}
		}
		System.out.println("Super Sınıflar:\n"); 	//Kalıtım alınan sınıflar ve kaç kere alındığı ekrana yazdırılıyor.
		for (int i = 0; i < sinifSayisi; i++) {
			if (tekrar[i] > 1) {
				System.out.println("	" + siniflar[i] + ": " + (tekrar[i] - 1));
			}
		}

		dosya.close();
	}

	public int[] kontrol(int[] tekrar, int sinifSayisi) {//Bu fonksiyon gönderilen int dizisinin uzunluğu gelen sayıdan küçük ise, gönderilen dizi daha büyük bir diziye aktarılıp geriye döndürülür.  Değer kaybı olmaz.
		if (tekrar.length < sinifSayisi) {//Eğer gönderilen sayı dizinin uzunluğundan büyük ise, daha büyük bir dizi tanımlanıp diğer dizideki değerler yeni diziye aktarılıyor. Değer kaybı olmuyor.
			int[] temp = new int[sinifSayisi + 5];
			for (int i = 0; i < tekrar.length; i++) {
				temp[i] = tekrar[i];
			}
			tekrar = temp;
		}
		return tekrar;
	}

	public String[] ekle(String[] siniflar, int sinifSayisi, String sinifAdi) {//Bu fonksiyon gönderilen string dizisinine yeni eleman ekler eğer dizinin uzunluğu gelen sayıdan küçük ise, gönderilen dizi daha büyük bir diziye aktarılıp geriye döndürülür. Değer kaybı olmaz.
		if (siniflar.length < sinifSayisi) {//Eğer gönderilen sayı dizinin uzunluğundan büyük ise, daha büyük bir dizi tanımlanıp diğer dizideki değerler yeni diziye aktarılıyor. Değer kaybı olmuyor.
			String[] temp = new String[sinifSayisi + 5];
			for (int i = 0; i < siniflar.length; i++) {
				temp[i] = siniflar[i];
			}
			siniflar = temp;
		}
		siniflar[sinifSayisi - 1] = sinifAdi; // Yeni diziye dışardan gönderilen yeni değer atanıyor.

		return siniflar;
	}

	public String metodAyikla(String text, Scanner dosyam) {// fileRead dosyasında ayıklanan classların metodlarını ayıklar.
		String fonkAdi;
		String donusTipi = "void";
		String[] parametreler = new String[10];
		if (bul(text)) {									//Satır düzenini kontrol ediyor. Eğer satır "public: Metod()" düzeninde ise çözümlemeye bu satırdan başlanıyor.Eğer yok ise bir sonraki satıra geçiliyor.
			int index = text.indexOf(":");
			text = text.substring(index + 1);
			text = text.trim();
		} else {
			text = sonraki(dosyam);
		}
		text = text.replace("(", "@");						//"(" karakterinin aranması sytax hatası verdiğinden dolayı karakter var ise "@" karakteri ile değiştiriliyor.
		if (text.contains("@")) {							//"@" karakteri var ise Metod çözümleme başlıyor.
			String[] temp;
			temp = text.split("@");							//"@" karakterine göre ifade bölünüyor.
			fonkAdi = temp[0];								//"@" karakterinden öncesi fonkAdi değişkenine atanıyor.
			fonkAdi = fonkAdi.trim();
			if (text.contains(":")) {						//Eğer okunan satırda ":" ifadesi var ise kalıtım olduğu anlamına geliyor. Dönüş tipi ve fonk adi atanıyor.
				String[] temp1 = fonkAdi.split(" ");
				donusTipi = "Nesne adresi";
				fonkAdi = temp1[0];
			} else if (fonkAdi.contains(" ")) {				//Eğer "@" karakterinden önceki ifadede " " karakteri var ise fonksiyonun dönüş tipi olduğu anlaşılıyor ver " " ifadesiyle parçalıyor ilk değer dönüş tipine, ikinci değer ise fonksiyon adına atanıyor.
				String[] temp1 = fonkAdi.split(" ");
				if (temp1[0].equals("friend")) {			//Eğer ilk değer "friend" ise 2. ifade dönüs tipi, 3.ifade ise fonkAdi olarak atanıyor.
					donusTipi = temp1[1];
					fonkAdi = temp1[2];
				} else {									//Eğer hiçbiri yok ise ilk ifade dönüş tipi ikinci ifade ise fonkAdi olarak atanıyor.
					donusTipi = temp1[0];
					fonkAdi = temp1[1];
				}
			}
			System.out.println("	" + fonkAdi);			//Fonksiyon adı ekrana yazılıyor.
			if (temp.length > 1) {							//Eğer "@" ifadesi ile parçalanan satır ifadesinin uzunluğu 1 elemandan uzun ise bu satırda parametre olduğu anlaşılıyor. Uzun değil ise bu satırda parametre olmadığı anlaşılıyor.
				temp[1] = temp[1].replace(",", " ");		//parametreler arasındaki "," karakteri " " ile değiştiriliyor. 
				temp = temp[1].split(" ");					//Parametreler " " karakteri ile parçalanıyor.
				int index1 = 0;
				for (int i = 0; i < temp.length; i += 2) {	//")" karakterini görene kadar okunan değerleri parametre dizisine aktarıyor.
					if (temp[i].contains(")") & i == 0) {
						break;
					}
					parametreler[index1] = temp[i];
					index1++;
				}
				if (!(temp[(temp.length - 1)].contains(")"))) {//Eğer okunan satırda ")" ifadesi yok ise parametrelerin birden fazla satırda olduğu anlaşılıyor ve bir sonraki satıra geçiliyor.
					parametreler = parametreBul(dosyam,parametreler); // parametreler hesaplanıyor.
					index1 = indexHesapla(parametreler); //kaç parametre oldugu değeri hesaplanıyor.
				}
				while (!text.contains("}")) {	//"}" karakteri görünene kadar dosyadaki satırları okuyor."}" karakteri metodun sonunu gösteriyor.
					text = sonraki(dosyam);
				}
				ekranaYaz(parametreler, index1, donusTipi);//Metodlar Ekrana Yazılıyor.
			} else { 		//Eğer "@" ifadesi ile parçalanan satırın uzunluğu 1 den büyük değilse bu satırda parametre olmadığı anlaşılıyor ve alt satıra geçiliyor.
				parametreler = parametreBul(dosyam,parametreler);	//Parametreler hesaplanıyor.
				int index1 = indexHesapla(parametreler);	//Kaç parametre olduğu bilgisi hesaplanıyor.
				ekranaYaz(parametreler, index1, donusTipi);//Metodlar Ekrana Yazılıyor.
			}
		}
		if (text.equals("};")) {//"};" karakterleri görünene kadar okunuyor. eğer görünürse Class bitmiştir. fonksiyondan çıkılıyor.
			return "};";
		} else {
			return " ";
		}
	}
	
	public int indexHesapla(String[] parametreler){//Gönderilen dizi içerisinde kaç tane null olmayan değer olduğunu hesaplıyor.
		int index = 0;
		for(int i = 0;i< parametreler.length;i++) {
			if(parametreler[i] != null) {
				index++;
			}
			else {
				break;
			}
		}
		return index;
	}

	public String[] parametreBul(Scanner dosyam,String[] parametreler) {//Parametreleri bulur.
		String text;
		String temp[];
		int index1 = 0;
		do {
			text = sonraki(dosyam);
			text = text.replace(",", " ");	//parametreler arasındaki "," karakteri " " ile değiştiriliyor. 
			temp = text.split(" ");			//Parametreler " " karakteri ile parçalanıyor.
			if(temp.length>parametreler.length) {//Okunacak değerlerin uzunluğu dizinin uzunluğundan fazla ise yeni dizi oluşturuluyor.
				parametreler = new String[temp.length+5];
			}
			for (int i = 0; i < temp.length; i += 2) {//Parametreler okunup diziye atanıyor.
				parametreler[index1] = temp[i];
				index1++;
			}
		} while (!(text.contains(")")));//")" karakteri görene kadar okuyor.
		
		return parametreler;
	}
	
	public void ekranaYaz(String[] parametreler, int index1, String donusTipi) {//Özellikleri gönderilen fonksiyonu uygun formatta ekrana yazar.
		if (!(index1 == 0)) {//Eğer 0 parametresi var ise else bloğu çalışıyor. 0 dan farklı parametreye sahip ise içeriye giriyor.
			System.out.print("		Parametreler:" + index1 + " (");
			for (int i = 0; i < index1; i++) {//Parametreler yazdırılıyor.
				if (i == (index1 - 1)) {//Son parametreyi yazdırdıktan sonra dönüş türünü yazdırıyor.
					System.out.print(parametreler[i] + ")\n");
					System.out.println("		Dönüş Türü: " + donusTipi + "\n");
				} else {
					System.out.print(parametreler[i] + ", ");
				}
			}
		} else {//0 parametreye sahip ise bu blok çalışıyor.
			System.out.println("		Parametreler:" + index1);
			System.out.println("		Dönüş Türü: " + donusTipi + "\n");
		}
	}

	public boolean bul(String text) {//Gönderilen String içerisinde public: 'dan sonra karakter olup olmadığını kontrol ediyor.
		text = text.replace(" ", "");
		if (text.length() > (text.indexOf("public") + 7)) {
			return true;
		}
		return false;
	}

	public String sonraki(Scanner dosyam) {//Dosyadan sonraki satırı okuyor, eğer okuduğu satır boş ise bir sonraki satıra geçiyor, dosyadaki fazladan " " karakteri varsa tek karaktere düşürüyor ve geri döndürüyor.
		if (dosyam.hasNextLine()) { // Dosyanın sonraki satırı olup olmadığını kontrol ediyor.
			String text = dosyam.nextLine();
			while (text.equals("")) {//Eğer okunan satır boş ise bir sonraki satırı okuyor.
				text = dosyam.nextLine();
			}
			return text.replaceAll("\\s+", " ");//Okunan satırda fazladan " " karakteri var ise tek " " karaktere düşürüyor.
		} else {
			return " ";
		}
	}
}
