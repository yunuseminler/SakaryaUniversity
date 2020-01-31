/****************************************************************************
**
**                ÖĞRENCİ ADI...........................:  Yunus Emre Eminler
**                ÖĞRENCİ NUMARASI..............:  g191210046
**                DERS GRUBU…………………..:  2.Ogretim B grubu
****************************************************************************/

#include <iostream>
#include <iomanip>

using namespace std;

void matrisYazmaMenu(int boyut,int matris[25][25]); //int main()'den sonra matrisYazmaMenu adlı fonksiyon oldugunu belirtiyor


int main(){
    int matris[25][25];
    int boyut,menü,satir,sutun,tutucu[25];
    srand(time(0));//Rastgele verilen sayilarin program her calistirildiginda farkli degerler vermesini saglar.
    
    do{
        cout << "Matrisin boyutunu giriniz. (5 ile 25 arasinda olmasi gerekiyor)" << endl;
        cin >> boyut;
        }
    while(boyut<5 || boyut >25 );  //Bu do while döngüsü girilen boyutun 5 ile 25 arasinda olup olmadigini kontrol ediyor.
    for(int i=0;i<boyut;i++){   //Bu for döngüsü matrisin elemanlarina 1-9 arasinda rastgele deger veriyor.
        for(int j=0;j<boyut;j++){
            matris[i][j]= rand()%9+1;
        }
    }
    do{
    matrisYazmaMenu(boyut,matris); //Menusuyle birlikte matrisi yazdirir.
    
        cin >> menü;
        while(menü>4 || menü<1){
            cout << "Hangi islemi yapmak istiyorsaniz basindaki sayiyi giriniz. (Sadece 1,2,3,4 sayilarini giriniz.)" << endl;
            cin >> menü;
        } //Bu do while dönüsü girilen degerin 1-4 arasinda olup olmadigini kontrol ediyor.
    switch(menü){
       case 1:
       cout << "İslem yapmak istediginiz satir ve sutun degerini girin" << endl;
       cin >> satir >> sutun;
            
            if(satir > boyut || satir<1){
                cout << "Satir degeriniz matrisin boyutu ile uyusmamaktadir."<< endl;
                break;
            }
               
            else if(sutun <1 || sutun>boyut){
                cout << "Sutun degeriniz matrisin boyutu ile uyusmamaktadir." <<endl;
                   break;
            }
              
            else{
                int satirtutucu[25];
                   int toplamtutucu=0;
                   satir=satir-1;
                   sutun=sutun-1;
                   for(int l=0;l<boyut;l++){  //Matrisin girilen sutun degerindeki degerleri tutucu bir diziye aktariyor.
                       tutucu[l]=matris[l][sutun];
                   }
                   for(int l=0;l<boyut;l++){  //Matrisin girilen satr degerindeki degerleri sutun degerine yaziyor.
                      satirtutucu[l]=matris[satir][l];
                   }
                  
                  for(int l=0;l<boyut;l++){  //Matrisin girilen satr degerindeki degerleri sutun degerine yaziyor.
                     matris[l][sutun]=satirtutucu[l];
                  }
                toplamtutucu=matris[satir][sutun]; //Kesisecek olan degerlerin birinin kaybolmamasi icin gecici toplam tutucu degerine atanıyor.
                for(int l=0;l<boyut;l++){ //Tutucu dizideki matris sutun degerlerini satira yaziyor.
                       matris[satir][l]=tutucu[l];
                   }
                   matris[satir][sutun]=matris[satir][sutun]+toplamtutucu;//Kesisen degerleri toplayip kesisen matris elemanina yaziyor.
                break;
               }
            
       case 2:
            cout << "İslem yapmak istediginiz satir numarasi giriniz" << endl;
            cin >>satir;
            
            if(satir>boyut || satir<1){
                cout << "Satir degeriniz matrisin boyutu ile uyusmamaktadir."<< endl;
                break;
            }
            
            else{
                satir=satir-1;
                int index=0;
                int ciftindex=0;
                for(int l=0;l<boyut;l++){//Girilen satir sayisindaki elemanlari kontrol ediyor.
                    if(matris[satir][l]%2==0){
                        tutucu[ciftindex]=matris[satir][l];//Eleman cift ise tutucu bir diziye aktariliyor.
                        ciftindex++;
                    }
                    
                    else{
                        matris[satir][index]=matris[satir][l]; //Tek ise matrisin ilk elemanina yazdiriyor.
                        index++;
                    }
                    }
                int ciftsayi=boyut-index;//Cift sayilarin sayisini buluyoruz
                for(int l=0;l<ciftsayi;l++){//Tek sayilar en bastan itibaren yazildiktan sonra kalan elemanlara cift sayilari atiyor.
                    matris[satir][index]=tutucu[l];
                    index++;
                }
                
                break;
            }
       case 3:
            cout << "İslem yapmak istediginiz sutun numarasi giriniz" << endl;
            cin >>sutun;
            if(sutun>boyut || sutun<1){
                cout << "Sutun degeriniz matrisin boyutu ile uyusmamaktadir."<< endl;
            break;
            }
            else{
                sutun=sutun-1;
                for(int l=0;l<boyut;l++){ //Matrisin secilen sutundaki elemanlari gecici bir diziye aktariliyor.
                    tutucu[l]=matris[l][sutun];
                }
                int gecici=boyut-1;
                for(int l=0;l<boyut;l++){//Matrisin secilen sutundaki elemanlarina gecici dizideki elemanlari sondan baslayarak atiyor.
                    matris[l][sutun]=tutucu[gecici];
                    gecici--;
                }
                
                break;
                
            }
        case 4:
            int index=0;
            for(int i=0;i<boyut;i++){//Matrisin bütün elemanlari toplaniyor ve index degerine ataniyor.
                for(int j=0;j<boyut;j++){
                    index=matris[i][j]+index;
                }
            }
                
            index=index+matris[0][0];
            for(int i=0;i<boyut;i++){
                for(int j=0;j<boyut;j++){
                    matris[i][j]=index-matris[i][j];//İndex degerinden matrisin [i][j]'nci elemani cikartilip tekrar [i][j]'nci degerine yaziliyor.
                    index=matris[i][j];//Bir onceki yapilan islemde cikan sonuc yeni matris index degeri olarak ataniyor.
                    }
                }
            break;
}
    }
    
    while(1);/*Bu döngü bütün switch case yapisini icine alır.Switch case icinde tekrar menü yazdirmaya ihtiyac duyulursa switch case döngüsü kirilir ve Menü ile birlikte matris tekrar yazilir.*/
    
}

void matrisYazmaMenu(int boyut,int matris[25][25]){
    cout << "    ";
    for(int k=0;k<boyut;k++){//Sutun numaralari yazdirilir.
        cout << setw(5) << left << k+1;
    }
    cout << endl << "   -";
    for(int l=0;l<boyut-1;l++){//Sutun numaralarinin altindaki cizgiler yazdirilir.
        cout << "-----";
    }
    cout<<"--" << endl;
    for(int i=0;i<boyut;i++){//Satir numaralari ile birlikte yanindaki | isareti ekrana yazdirilir.
        cout << setw(2)<< left <<i+1 << "| ";
        for(int j=0;j<boyut;j++){//Matrisin elemanlari yazdirilir.
            cout <<setw(5) << left << matris[i][j];
        }
        cout << endl;
    }
    cout << endl  << "1) Sutun Satir degistir." << endl<< "2) Tekleri basa al(satir)" << endl<< "3) Ters cevir (sutun)" << endl << "4) Toplamlari yazdir" << endl;
    
}
