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
        int defaultInt = default(int);      //default int degeri 0'dır.
        long defaultLong = default(long);   //default long degeri 0'dır.
        double defaultDouble = default(double); //default double degeri 0.0'dır.
        decimal defaultDecimal = default(decimal); //default decimal degeri 0.0'dır.
        bool defaultBool = default(bool);   //default bool degeri false'dır.
        char defaultChar = default(char);   //default char degeri \\0'dır.
        string? defaultString = default(string); // reference type oldugu icin default "null"

        Console.WriteLine("1) Default degerler:");
        Console.WriteLine($"   int     : {defaultInt}");
        Console.WriteLine($"   long    : {defaultLong}");
        Console.WriteLine($"   double  : {defaultDouble}");
        Console.WriteLine($"   decimal : {defaultDecimal}");
        Console.WriteLine($"   bool    : {defaultBool}");
        Console.WriteLine($"   char    : '{defaultChar}' (görünmez, aslında \\0 karakteri)");
        Console.WriteLine($"   string  : {(defaultString is null ? "null" : defaultString)}");

        // 2) Min/Max sinir degerleri
        Console.WriteLine();
        Console.WriteLine("2) Sinir degerleri:");
        Console.WriteLine($"   int.MinValue  = {int.MinValue}");
        Console.WriteLine($"   int.MaxValue  = {int.MaxValue}");
        Console.WriteLine($"   long.MinValue = {long.MinValue}");
        Console.WriteLine($"   long.MaxValue = {long.MaxValue}");

        // 3) double vs decimal hassasiyet farki
        Console.WriteLine();
        Console.WriteLine("3) double vs decimal hassasiyet:");
        double doubleResult = 0.1 + 0.2;
        decimal decimalResult = 0.1m + 0.2m; // 'm' suffix -> decimal literal
        Console.WriteLine($"   double : 0.1 + 0.2 = {doubleResult}  (beklenen 0.3 degil!)");
        Console.WriteLine($"   decimal: 0.1 + 0.2 = {decimalResult}  (tam olarak 0.3)");

        // 4) Neden decimal tercih edilir?
        // double, sayilari ikili (binary) tabanda sakladigi icin bazi ondalik
        // kesirleri (0.1 gibi) TAM olarak temsil edemez, kucuk yuvarlama
        // hatalari birikir. decimal ise 10'luk (decimal) tabanda calisir,
        // bu yuzden para/finans gibi kurus/tam ondalik hassasiyet gerektiren
        // islemlerde beklenmedik yuvarlama hatalarina yol acmaz.
        Console.WriteLine();
        Console.WriteLine("4) Para hesaplarinda decimal tercih edilir cunku ikili");
        Console.WriteLine("   tabanli double'da olusan yuvarlama hatalarindan etkilenmez.");

        // 5) (Bonus) char aritmetigi
        Console.WriteLine();
        int charPlusOne = 'A' + 1; // char, int'e implicit olarak donusur (Unicode kod noktasi)
        char nextChar = (char)('A' + 1); // sonucu tekrar char'a cevirmek icin explicit cast gerekir
        Console.WriteLine($"5) 'A' + 1 = {charPlusOne} (int olarak, Unicode kod noktasi)");
        Console.WriteLine($"   (char)('A' + 1) = '{nextChar}' (tekrar char'a cast edilince harf gorunur)");
    }
}
