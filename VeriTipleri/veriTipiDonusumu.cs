/*
    Veri Tipi Dönüşümleri
    implicit casting => bilinçsiz tür dönüşümü
    explicit casting => bilinçli tür dönüşümü

--string iki veri toplanırsa 10+20 ise yanyana yazdırır 1020
--matematiksel sonuç istiyorsak dönüştürme işlemi yapmamız lazım "Convert.toInt32()"
*/


 int a = 8;
long b = a;
 System.Console.WriteLine(b); //implicit


 long d = 32;
 int c = (int)d; 
 System.Console.WriteLine(d); //explicit


 int x = 10;
 string z = Convert.ToString(x); //x.ToStrin() şeklinde de yazılabilir.  int to string
 System.Console.WriteLine(x);

/* Uygulama: Kullanıcıdan 2 sayı girişi isteyiniz. Ve istenilen 2 sayıyı toplayınız.

System.Console.Write("1.sayıyı girişi yapınız:"); //writeLine arasındaki fark "Line" alt satıra geçmesini sağlar.
var sayi1 = Convert.ToInt32( Console.ReadLine());//string to integer

System.Console.Write("2.sayıyı girişi yapınız:");
var sayi2 =Convert.ToInt32( Console.ReadLine());

int toplam =  sayi1 + sayi2;
System.Console.WriteLine(toplam);

*/