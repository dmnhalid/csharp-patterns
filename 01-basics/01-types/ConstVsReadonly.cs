namespace Types;

// KONU: const vs readonly
//
// Amaç: İki "değişmez değer" tanımlama yönteminin ne zaman derlendiğini
// (compile-time vs runtime) ve nerede kullanılmaları gerektiğini görmek.
//
// Yapılacaklar (TODO):
// 1. Bir "const" alan tanımla (örnek: "const double Pi = 3.14159;"),
//    const'un mutlaka derleme zamanında bilinen bir değer olması
//    gerektiğini not al (örnek: "const" bir metot sonucunu tutamaz).
// 2. Bir "readonly" alan tanımla, bu alana sadece constructor içinde
//    değer atanabildiğini göster.
// 3. "static readonly" ile "const" arasındaki farkı dene: const,
//    kullanıldığı yere derleme zamanında "gömülür" (inline edilir);
//    static readonly ise çalışma zamanında okunur. Bunu bir yorumla
//    açıkla (ipucu: farklı DLL'ler arasında const değiştirip yeniden
//    derlemeden kullanmanın neden sorun çıkarabileceğini araştır).
// 4. (Bonus) readonly bir struct alanı ile readonly bir class alanının
//    (reference type) davranış farkını dene - readonly class alanı,
//    referansın kendisinin değişmesini engeller ama nesnenin İÇİNDEKİ
//    alanların değişmesini engellemez.

public static class ConstVsReadonly
{
    public static void Run()
    {
        Console.WriteLine("--- ConstVsReadonly ---");

        // TODO: buraya yaz
    }
}
