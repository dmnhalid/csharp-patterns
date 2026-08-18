namespace Types;

// KONU: Built-in types (int, long, double, decimal, bool, char, string...)
//
// Amaç: Temel tiplerin aralıklarını, hassasiyetlerini ve ne zaman hangisinin
// kullanılması gerektiğini kod üzerinden görmek.
//
// Yapılacaklar (TODO):
// 1. int, long, double, decimal, bool, char, string değişkenleri tanımla,
//    her birinin default değerini yazdır (default(int) gibi).
// 2. int.MinValue / int.MaxValue, long.MinValue / long.MaxValue gibi
//    sınır değerleri yazdır.
// 3. double ile decimal arasındaki hassasiyet farkını göster:
//    Örnek: 0.1 + 0.2 işlemini double ve decimal ile yapıp sonuçları
//    karşılaştır (double'da beklenmedik ondalık hatası görürsün).
// 4. Neden para/finans hesaplarında decimal tercih edilir, bunu
//    yorum satırıyla kısaca açıkla (kendi cümlenle).
// 5. (Bonus) char aritmetiği dene: 'A' + 1 gibi bir işlemin sonucu ne olur?

public static class BuiltInTypes
{
    public static void Run()
    {
        Console.WriteLine("--- BuiltInTypes ---");

        // 1) Default degerler
        int defaultInt = default(int);
        long defaultLong = default(long);
        double defaultDouble = default(double);
        decimal defaultDecimal = default(decimal);
        bool defaultBool = default(bool);
        char defaultChar = default(char);
        string? defaultString = default(string); // reference type oldugu icin default null

        Console.WriteLine("1) Default degerler:");
        Console.WriteLine($"   int     : {defaultInt}");
        Console.WriteLine($"   long    : {defaultLong}");
        Console.WriteLine($"   double  : {defaultDouble}");
        Console.WriteLine($"   decimal : {defaultDecimal}");
        Console.WriteLine($"   bool    : {defaultBool}");
        Console.WriteLine($"   char    : '{defaultChar}' (görünmez, aslında \\0 karakteri)");
        Console.WriteLine($"   string  : {(defaultString is null ? "null" : defaultString)}");

    }
}
