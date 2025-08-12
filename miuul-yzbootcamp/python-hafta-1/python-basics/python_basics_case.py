#####################################
# Python Temelleri - Ödev Scripti
#####################################
# Soru 1:
# Bir integer, bir float ve bir complex sayı tanımlayın.
# Bu sayıların türlerini yazdırın ve aralarında 1-2 işlem yapın.
a=10
type(a)
(print(type(a)))

b=0.18
type(b)
(print(type(b)))

c=10j +18
type(c)
(print(type(c)))

z=a-b
print(z)

x=a+b-c
print(x)
#####################################
# Soru 2:
# İsminizi içeren bir string değişkeni oluşturun.
# Bu stringin ilk ve son karakterini yazdırın. Ayrıca tüm harfleri büyük yaparak ekrana yazdırın.

name="selin"
print(name[0])
print(name[4])
print(name.upper())
#####################################
# Soru 3:
# Aşağıdaki string içinde "veri" kelimesi geçiyor mu kontrol edin.
# Ardından bu stringi boşluklardan bölerek liste haline getirin.

sentence = "Veri bilimi yapay zeka ile birleştiğinde güçlü sonuçlar doğurabilir."
if"veri" in sentence:
    print("Evet, string içinde 'veri' kelimesi geçiyor.")
elif "Veri" in sentence:
    print("Evet, string içinde 'Veri' kelimesi geçiyor.")
else:
    print("Hayır, geçmiyor.")

bol=sentence.split()
print(bol)
#####################################
# Soru 4:
# İçerisinde 3 farklı türde veri bulunan bir liste oluşturun.
# Listenin uzunluğunu, ilk ve son elemanını yazdırın.
# Ardından bu listeye yeni bir eleman ekleyin ve ikinci elemanı silin.

liste=["u",18,9.9,["selin"]]
len(liste)
print(len(liste))
print(liste[0])
print(liste[3])

liste.append(12)
print(liste)

liste.pop(1)
print(liste)
#####################################
# Soru 5:
# 2 parametre alan bir fonksiyon yazın. Bu fonksiyon, aldığı iki sayının ortalamasını dönsün.

def param(sayi1, sayi2):
    result=(sayi1+sayi2)/2
    print(result)
param(12,16)
#####################################
# Soru 6:
# Kullanıcının yaşına göre mesaj yazdıran bir fonksiyon yazın:
# 18'den küçükse "Çok gençsin!", 18-40 arasıysa "Harika bir yaştasın!", 40'tan büyükse "Deneyim önemli!" mesajını yazdırsın.

def yas_goster(yas):
    if yas<18:
        print("çok gençsin maşallah kıymetini bil")
    elif yas<=40:
        print("hala çıtırsın")
    else:
        print("deneyim önemli!")

yas_goster(8)
yas_goster(36)
#####################################
# Soru 7:
# İçerisinde sayılar olan bir liste içindeki sayıları dolaşarak 2 katını ekrana yazdırın (for döngüsü ile).

sayi=[1,5,12]
for say in sayi:
    print(say*2)
#####################################
# Soru 8:
# 1'den başlayarak 20 dahil olacak şekilde çift sayıları yazdırın (while döngüsü ile).
num=0
while num<20:
    num=num+2
    print(num)
#####################################
# Soru 9:
# Bir çalışanın haftalık maaşını hesaplayan bir fonksiyon yazın.
# Saatlik ücreti ve haftalık toplam çalışma saati parametre olarak alınsın.
# Haftada 40 saatten fazla çalıştıysa, fazla saatler için %50 zamlı ücret ödensin (mesai).
# Örnek: 45 saat çalışan biri için 5 saatlik mesai uygulanmalı.

def maas_hesapla(saatlik_ucret, toplam_calisma_saati):
    if toplam_calisma_saati <= 40:
        maas = saatlik_ucret * toplam_calisma_saati

    else:
        normal_ucret = saatlik_ucret * 40
        mesai_saati = toplam_calisma_saati - 40
        mesai_ucreti = mesai_saati * (saatlik_ucret * 1.5)

        maas = normal_ucret + mesai_ucreti

    # Maaş değerini ekrana yazdırır
    print(f"Haftalık maaşınız: {maas} TL")

maas_hesapla(45,5)