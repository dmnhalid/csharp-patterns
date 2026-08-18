namespace Types;

// KONU: Boxing / Unboxing
//
// Amaç: Bir value type'ın object'e (referans tipine) "sarılmasının"
// (boxing) ve geri "çıkarılmasının" (unboxing) nasıl çalıştığını ve
// performans maliyetini görmek.
//
// Yapılacaklar (TODO):
// 1. "int i = 42; object o = i;" ile boxing yap (value type heap'e kopyalanır).
// 2. "int j = (int)o;" ile unboxing yap.
// 3. Boxing sonrası "o"yu değiştirip "i"nin etkilenip etkilenmediğini
//    kontrol et (etkilenmemeli, çünkü ayrı bir kopya heap'te).
// 4. Yanlış tipe unboxing denemesi yap (örnek: object'e int koyup
//    (double) ile unboxing dene), InvalidCastException'ı gözlemle.
// 5. Bir "ArrayList" (non-generic, System.Collections) ile bir
//    "List<int>" (generic) arasındaki boxing farkını karşılaştır -
//    ArrayList'e int eklemenin her seferinde boxing yaptığını,
//    List<int>'in yapmadığını yorum olarak not al.
// 6. (Bonus) Basit bir Stopwatch ile çok sayıda (örnek: 1 milyon) boxing
//    işleminin süresini ölçüp generic koleksiyonla karşılaştır.

public static class BoxingUnboxing
{
    public static void Run()
    {
        Console.WriteLine("--- BoxingUnboxing ---");

        // TODO: buraya yaz
    }
}
