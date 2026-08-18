namespace Types;

// KONU: Nullable types
//
// Amaç: Value type'ların normalde null olamadığını, "?" ile nullable
// yapıldığında nasıl davrandığını ve null kontrol operatörlerini
// (??, ??=, ?.) öğrenmek.
//
// Yapılacaklar (TODO):
// 1. "int? age = null;" tanımla, HasValue ve Value property'lerini kullan.
// 2. Value'ya null iken erişmeyi dene, ne tür bir hata aldığını gözlemle
//    (InvalidOperationException).
// 3. "??" operatörünü kullanarak null ise varsayılan bir değer ata
//    (örnek: int result = age ?? 0;).
// 4. "??=" operatörünü kullanarak değişken null ise değer ata.
// 5. Nullable bir reference type ile ("string? name = null;") "?."
//    (null-conditional) operatörünü dene (örnek: name?.Length).
// 6. (Bonus) Nullable<T> struct'ının aslında ne olduğunu bir yorumla
//    kendi cümlenle açıkla.

public static class NullableTypes
{
    public static void Run()
    {
        Console.WriteLine("--- NullableTypes ---");

        // TODO: buraya yaz
    }
}
