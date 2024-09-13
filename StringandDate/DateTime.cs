/*
DateTime: DateTime yapısı, belirli bir tarih ve saati temsil etmek için kullanılan değer bir tiptir. Bu yapı sayesinde tarihler arasında işlem yapma, farklı formatlarda tarih gösterimi, saat dilimi ayarları gibi birçok işlemi gerçekleştirebilirsiniz.
DateTime dt = new DateTime(); satırı, bir tarih ve saat nesnesi oluşturmak için kullanılan temel bir ifadedir. 
*/
var simdi = DateTime.Now;
// System.Console.WriteLine(simdi);
// System.Console.WriteLine(simdi.Year);
// System.Console.WriteLine(simdi.Month);
// System.Console.WriteLine(simdi.Day);
// System.Console.WriteLine(simdi.DayOfWeek);

DateTime dt = new DateTime(2001, 01, 22); // yıl, ay, gün şeklinde yazılmalı.
DateTime dt2 = dt.AddYears(1); // 22.01.2002 00:00:00 

var fark = simdi - dt;
System.Console.WriteLine(fark.TotalDays);