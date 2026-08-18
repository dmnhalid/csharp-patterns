namespace Types;

// KONU: Type conversion (implicit / explicit / Convert / Parse / TryParse)
//
// Amaç: Farklı dönüştürme yollarını ve aralarındaki güvenlik/performans
// farkını görmek.
//
// Yapılacaklar (TODO):
// 1. Implicit conversion örneği: int'ten double'a otomatik dönüşüm.
// 2. Explicit conversion (cast) örneği: double'dan int'e "(int)" ile
//    dönüşüm, veri kaybı olup olmadığını gözlemle.
// 3. "int.Parse" ile geçersiz bir string'i sayıya çevirmeyi dene,
//    fırlayan exception'ı gözlemle (try/catch ile yakala).
// 4. Aynı işlemi "int.TryParse" ile yap, exception fırlatmadan false
//    dönmesini gözlemle. Neden TryParse kullanıcı girdisi için daha
//    güvenli, bunu bir yorumla açıkla.
// 5. "Convert.ToInt32" ile Parse arasındaki farkı araştır ve kısaca
//    yorum olarak not al (özellikle null davranışı farklı).
// 6. (Bonus) checked/unchecked blokları ile overflow davranışını dene.

public static class TypeConversion
{
    public static void Run()
    {
        Console.WriteLine("--- TypeConversion ---");

        // TODO: buraya yaz
    }
}
