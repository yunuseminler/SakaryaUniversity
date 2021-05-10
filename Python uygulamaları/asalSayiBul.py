# Girilen sayinin asal sayi olup olmadığını bulan program.

number = int(input("Sayi giriniz : "))

i = 2
check = 0

while(i<number):
    if((number % i)==0):
        check = 1
        break
    else:
        i += 1

if(not(check == 0)):
    print("Sayiniz asal sayi değildir.")
else:
    print("Sayiniz asal sayidir.")

