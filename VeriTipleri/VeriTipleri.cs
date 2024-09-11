/*
    C# veri Tipleri
    Value Types:
        Tam Sayı:byte, short, int, long
        Ondalıklı Sayılar: float(tanımlamak için "f" ekle) double, decimal(tanımlamak için "m" ekle)
        Diğer: char((' ')tanımlamak için tek tırnak kullan), boolean, struct

    Reference Types:
        String, Class, Array, Interface    


float urunKilosu = 1.25f;
char cinsiyet = 'K';
string cinsiyet2 = "Kadın";
*/

 /*
 2.2 Uygulama: Değişkenler
 -Uygulama 1: Bir öğrencinin aşağdaki bilgileri için gerekli değişkenleri oluşurunuz.
 Öğrenci Adı
 Öğrenci Soyadı
 Öğrenci Ad ve Soyadı
 Öğrenci Numarası
 Öğrenci Cinsiyeti
 Öğrenci tc Kimlik
 Öğrenci doğum yılı
 Öğreci Adres bilgisi
 Öğrenci Yaşı
*/

 string studentName = "Özlem";
 string studentSurname= "Arslan";
 string studentName_studentSurname = studentName+ " " + studentSurname;
 int studentNo = 2298;
 string gender = "woman";
 long idNo = 012345678910; //int değer için fazla uzun. "Long" kullandık.
 int birthYear = 2001;
 string adress = "Başakşehir / İstanbul";
 int studentYear = 23;

 System.Console.WriteLine(studentName_studentSurname);
 

 /*
 -Uygulama 2 : Aşağadaki ürünlerin toplam bilgisini hesaplayınız.
 Ürün 1 => 50 TL
 Ürün 2 => 68.5 TL
 Ürün 3 => 356.45 TL
*/

 int urun1 = 50;
 double urun2 = 68.5;
 double urun3 = 356.45;
//Double: derleyiciye yerleştirilmiş ve kesirleri barındıran ondalık noktalı sayıları tutan sayısal değişkenleri tanımlamak için kullanılan temel bir türdür

var toplam = urun1+urun2+urun3;
System.Console.WriteLine(toplam);
