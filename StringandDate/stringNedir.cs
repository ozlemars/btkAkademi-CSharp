// Karakterler ve stringler (metinler) 
// Stringler, referans tiptedir, bu nedenle null değer alabilirler.

char cinsiyet = 'K'; // Cinsiyeti tek bir karakterle temsil ediyoruz.
string cinsiyetYazisi = "Kadın"; // Cinsiyeti tam olarak yazıyla belirtiyoruz.
string ad = "Özlem"; // Kişinin adı
string soyad = "Arslan"; // Kişinin soyadı
string yas = "23"; // Yaşı string olarak saklıyoruz (matematiksel işlem yapılmayacaksa).

// Farklı şekillerde string birleştirme örnekleri

// 1. Tüm bilgileri tek bir string içinde sabit olarak belirtiyoruz.
string mesaj = "Özlem Arslan isimli kişi 23 yaşındadır";

// 2. Değişkenleri kullanarak dinamik bir mesaj oluşturuyoruz.
// String concatenation (birleştirme) işlemi yapıyoruz.
string mesaj2 = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır";

// 3. Kullanıcıdan değerleri alarak dinamik bir mesaj oluşturuyoruz.
Console.Write("Adınız: ");
string kullaniciAdi = Console.ReadLine();

Console.Write("Soyadınız: ");
string kullaniciSoyadi = Console.ReadLine();

Console.Write("Yaşınız: ");
string kullaniciYasi = Console.ReadLine();

// String interpolation kullanarak daha okunaklı bir şekilde birleştirme
string mesaj3 = $"{kullaniciAdi} {kullaniciSoyadi} isimli kişi {kullaniciYasi} yaşındadır.";

// Tüm mesajları ekrana yazdırıyoruz
Console.WriteLine(mesaj);
Console.WriteLine(mesaj2);
Console.WriteLine(mesaj3);