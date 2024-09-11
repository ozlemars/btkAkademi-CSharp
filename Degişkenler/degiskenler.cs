/* 2.DEĞİŞKENLER
Değişken türünü bilmiyorsak "var" yazabiliriz.

System.Console.WriteLine(5000 * 1.08); //urunA
System.Console.WriteLine(3000 * 1.08); //urunB
System.Console.WriteLine(6000 * 1.08); //urunC

-- Tekrarlanmasını önlemek adına kdv değişkeni atıyoruz.
*/

var kdvOrani = 1.08;
var urunA = 5000;
var urunB = 5000;
var urunC = 5000;
var urunD= 5000; //urunA ile aynı değere sahip olmasına rağmen farklı değişkenler

System.Console.WriteLine(urunA * kdvOrani);
System.Console.WriteLine(urunB * kdvOrani);
System.Console.WriteLine(urunC * kdvOrani); 
System.Console.WriteLine(urunD * kdvOrani); 

/* 2.1 Değişken Tanımlama

- Değişken tanımlanırken adlandırmada boşluk kullanılmaz. (urun_adi kullanılabilir.)
- Değişkenler aynı ada sahip olamaz.
- Küçük harf büyük harfe duyarlı. Farklı büyük/küçük harfler arasında ayrım yapar (örneğin, "A" ≠ "a").
- Türkçe karakter kullanmamaya özen gösterelim.
- Eğer iki kelime kullanıyorsak ikinci kelimenin ilk harfi büyük.(camelCase)
- camelCase: kelimelerin tek bir büyük harfle ayrılmasını ve ilk kelime ile başlayan boşluk veya noktalama işaretleri olmadan sözcük öbekleri yazma uygulamasıdır.
- PascalCase: Pascal Case'in Camel Case'den farkı ise, ilk harfin de büyük harfle başlamasıdır.
- değiken türünü bilmiyorsak "var" kullanabiliriz.
*/
var sayi = 20;
var urunAdi = "Poco X3 Pro"; 
var fiyat = 1000.25;
var satistaMi = false;
var urunNo ="001"; //matematiksel işlemde kullanılmayacaksa tırnak içine yazılabilir.

Console.WriteLine(sayi);
Console.WriteLine(urunAdi);
Console.WriteLine(fiyat);
Console.WriteLine(satistaMi);
Console.WriteLine(urunNo);
 