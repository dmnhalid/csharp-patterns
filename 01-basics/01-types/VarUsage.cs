namespace Types;

// KONU: var kullanımı (implicit typing)
//
// Amaç: "var" ile tanımlanan değişkenin derleme zamanında tipinin nasıl
// belirlendiğini ve ne zaman kullanmanın okunabilirliği artırıp ne zaman
// azalttığını görmek.
//
// Yapılacaklar (TODO):
// 1. "var x = 5;" gibi birkaç örnekte var kullan, GetType() ile gerçek
//    tipin ne olduğunu yazdır.
// 2. Okunabilirliği ARTIRAN bir var kullanımı örneği yaz (örnek: uzun
//    generic tip isimleri, "var list = new Dictionary<string, List<int>>();").
// 3. Okunabilirliği AZALTAN bir var kullanımı örneği yaz (örnek: bir
//    metot çağrısının dönüş tipi isimden anlaşılmıyorsa, "var result =
//    DoSomething();" gibi).
// 4. var'ın derleme zamanında (compile-time) tip belirlediğini, runtime'da
//    dynamic gibi davranmadığını bir yorumla açıkla.
// 5. (Bonus) var'ın nerelerde KULLANILAMAYACAĞINI dene (örnek: field
//    tanımlarında, metot parametrelerinde var kullanılamaz).

public static class VarUsage
{
    public static void Run()
    {
        Console.WriteLine("--- VarUsage ---");

        // TODO: buraya yaz
    }
}
