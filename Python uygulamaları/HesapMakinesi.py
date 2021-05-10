print("Hesap makinesine hoşgeldiniz.")
print("Yapmak istediğiniz işlemi giriniz.")
print("* çarpma, / bölme, + toplama, - çıkarma")

while True:
    while(True):
        answer = input("işlem :")
        if not(answer == '*' or answer == '/' or answer=='+' or answer=='-'):
            print("Farklı işaret girdiniz. Tekrar girin")
        else:
            break
    while True:
        sayi1 = input("1. sayi girin : ")
        if(sayi1.isdigit()):
            sayi1 = int(sayi1)
            break
        else:
            print("Lütfen sadece sayi giriniz.")
    while True:
        sayi2 = input("2. sayi girin : ")
        if sayi2.isdigit():
            sayi2 = int(sayi2)
            break
        else:
            print("Lütfen sadece sayi giriniz.")
    
    if(answer == '*'):
        print(f"Çarpım sonucu = {sayi1*sayi2}")
    elif(answer=='/'):
        print(f"Bölme sonucu = {sayi1/sayi2}")
    elif(answer=='+'):
        print(f"Toplama sonucu = {sayi1+sayi2}")
    else:
        print(f"Çıkartma sonucu = {sayi1-sayi2}")
    
    
    while(True):
        answer = input("Başka işlem yapmak ister misiniz ? (y/n) : ")
        if not (answer=='y' or answer == 'n'):
            print("Farklı karakter girdiniz. Tekrar girin")
        else:
            break
    if(answer == 'n'):
        print("Program sonlandırıldı")
        exit()

