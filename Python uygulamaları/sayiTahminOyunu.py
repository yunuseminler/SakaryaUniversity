#Sayı tahmin oyunu
import random
import time

denemeSayisi = 1
print("Sayı tahmin oyununa hoşgeldiniz.")


while True:
    while True:
        answer = input("Yeni oyuna başla ? (y/n) : ")
        if(answer == 'y' or answer == 'n'):
            break
        else:
            print("Lütfen sadece y yada n harflerinden birini giriniz")
    
    if(answer == 'n'):
        print("Katıldığınız için teşekkürler.")
        exit()
    
    rsayi = random.randint(0,100)
    print("Sayınız oluşturuldu.")
    
    startTime = time.time()

    while (answer == 'y'):
        cevap = int(input("Cevabınız : "))
        if(cevap == rsayi):
            print("Tebrikler cevabınız doğru.",end = ' ')
            break
        elif(cevap > rsayi):
            print("Sayıdan büyüktür.")
        else:
            print("Sayidan küçüktür.")
        denemeSayisi += 1

    endTime = time.time()
    print(f"Tahmin süreniz {round((endTime-startTime),2)} saniyedir. Deneme sayınız : {denemeSayisi}")
