namespace Types;

// KONU: Struct vs Class (ve record struct / record class)
//
// Amaç: Ne zaman struct, ne zaman class kullanılması gerektiğini pratik
// örneklerle görmek.
//
// Yapılacaklar (TODO):
// 1. Küçük, değişmez (immutable) bir veri taşımak için bir struct tanımla
//    (örnek: "readonly struct Money(decimal Amount, string Currency)").
// 2. Aynı veriyi bir class ile tanımla, ikisi arasındaki bellek/kopyalama
//    davranışı farkını (ValueVsReference dosyasında öğrendiğinle
//    bağlantılı) bir yorumla özetle.
// 3. "record class" ve "record struct" tanımla, otomatik gelen
//    ToString(), Equals(), == operatörü davranışlarını dene.
// 4. İki farklı struct/record örneğini "==" ile karşılaştır, class için
//    aynısını yap - value equality mi reference equality mi olduğunu
//    gözlemle.
// 5. (Bonus) Struct'ların neden "büyük" veri yapıları için önerilmediğini
//    (her kopyalamada tüm alanların kopyalanması) bir yorumla açıkla.

public static class StructVsClass
{
    public static void Run()
    {
        Console.WriteLine("--- StructVsClass ---");

        // TODO: buraya yaz
    }
}
