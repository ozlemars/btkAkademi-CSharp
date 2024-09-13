/*
    String Uygulamları
    Replace() metodu, bir string içindeki belirli bir karakter veya alt string'i başka bir karakter veya alt string ile değiştirmek için kullanılır. Bu metod, özellikle metin düzenleme işlemlerinde ve veri temizleme süreçlerinde faydalıdır. 
*/
// string kursAdi =".NET7 ile C# Programlama Dili";

// 1- Kaç karaktere sahiptir?
//var sonuc = kursAdi.Length;

// 2- Hepsini küçük harf yapınız.
//var sonuc = kursAdi.ToLower();

// 3- '.' ile mi başlamaktadır?
//var sonuc = kursAdi.StartsWith(".");

// 4- C# bilgisi hangi konumda bulunmaktadır?
//var sonuc = kursAdi.IndexOf("C#");

// 5- String 'C#' bilgisini içeriyor mu?
//var sonuc = kursAdi.Contains("C#");

// 6- 'Dili' kelimesiyerine 'Dersleri' yazınız. (replace)
// var sonuc = kursAdi.Replace("Dili","Dersleri");

// System.Console.WriteLine(sonuc);

/*
DateTime: 
*/
var simdi = DateTime.Now;
System.Console.WriteLine(simdi);