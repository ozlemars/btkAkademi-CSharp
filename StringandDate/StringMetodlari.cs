
/*
    String Methods:  String bir obje üzerinden ulaşabileceğimiz çeşitli metodları içerir:
Length: String'in uzunluğunu döndürür.
ToLower(): String'i küçük harfe çevirir.
ToUpper(): String'i büyük harfe çevirir.
Trim(): String'in başındaki ve sonundaki boşlukları kaldırır.
Split() metodu, metinleri ayırıp parçalamak için sıkça kullanılan güçlü bir string metodudur
StartsWith() metodu, bir string'in belirli bir karakter veya alt string ile başlayıp başlamadığını kontrol eden bir metottur. Eğer string, verilen karakter ya da alt string ile başlıyorsa true, başlamıyorsa false döner. !büyük/küçük harfe duyarlıdır.!
EndsWith(), bir string'in belirli bir karakter ya da alt string ile bitip bitmediğini kontrol etmek için kullanılır ve büyük/küçük harfe duyarlıdır. Bu metod, string doğrulama ve veri kontrol işlemlerinde faydalıdır.
Contains() metodu, bir string içinde belirli bir alt string veya karakterin bulunup bulunmadığını kontrol eder. Büyük/küçük harfe duyarlıdır ve metin arama işlemlerinde sıklıkla kullanılır.
IndexOf() metodu, bir string içinde belirtilen karakterin veya alt string'in ilk geçtiği yerin indeks numarasını döner. Eğer karakter veya alt string bulunamazsa -1 döner. Bu yöntem, metin içinde bir karakterin veya kelimenin hangi konumda olduğunu bulmak için kullanılır.
Substring(): String'in bir kısmını döndürür.
*/

string message = "Bugün C# çalışmak için güzel bir gün.";
//var sonuc = message.Length; // 37 boşluklar ve noktalama işareti (.) dahil.
//var sonuc = message.ToLower();
//var sonuc = message.ToUpper();
//var sonuc = message.Trim();
//var sonuc = message.Split(" ") [3]; //System.String[] --için gelir.
//var sonuc = message[0]; //B
//var sonuc = message.StartsWith("Bugün"); //true döner.
//var sonuc = message.EndsWith("Gün."); //False dönerçünkü küçük harf/ büyük harfe duyarlı
//var sonuc = message.Contains("C"); //true
//var sonuc = message.IndexOf("çalışmak"); //9
//var sonuc = message.IndexOf("abc"); //-1
//var sonuc = message.Substring(15); //ak için güzel bir gün.
System.Console.WriteLine(sonuc); 

