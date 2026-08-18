namespace Types;

// KONU: Value types vs Reference types
//
// Amaç: Bir değişkeni başka bir değişkene atadığında (veya bir metoda
// parametre olarak geçtiğinde) verinin KOPYALANIP kopyalanmadığını,
// yoksa aynı referansın mı paylaşıldığını gözlemlemek.
//
// Yapılacaklar (TODO):
// 1. Bir "int a = 10;" tanımla, "int b = a;" ile kopyala, b'yi değiştir,
//    a'nın değişip değişmediğini yazdır (değişmemeli - value type).
// 2. Basit bir "Point" struct'ı tanımla (X, Y int alanları), aynı deneyi
//    struct ile tekrar et.
// 3. Basit bir "PointClass" class'ı tanımla (aynı alanlarla), aynı
//    deneyi class ile tekrar et (bu sefer değişmeli - reference type).
// 4. Bir metoda struct ve class'ı parametre olarak geçir, metot içinde
//    değiştir, çağıran taraftaki değerin etkilenip etkilenmediğine bak.
// 5. (Bonus) "ref" ve "in" keyword'lerini value type parametrelerde
//    dene, davranışın nasıl değiştiğini gözlemle.

public struct Point
{
    public int X;
    public int Y;
}

public class PointClass
{
    public int X;
    public int Y;   
}

public static class ValueVsReference
{
    public static void Run()
    {
        Console.WriteLine("--- ValueVsReference ---");
        // 1) int - value type
        int a = 10;
        int b = a; // b, a'nın bir KOPYASI
        b = 20;
        Console.WriteLine($"1) a = {a}, b = {b}  -> a degismedi (value type)");

        // 2) struct - value type
        Point p1 = new Point { X = 1, Y = 1 };
        Point p2 = p1; // p2, p1'in bir KOPYASI
        p2.X = 99; // p2.X'i degistir, p1.X degismemeli, Y hiçbir şekilde değişmedi
        Console.WriteLine($"2) p1.X = {p1.X}, p2.X = {p2.X}  -> p1 degismedi (struct = value type)");

        // 3) class - reference type
        PointClass pc1 = new PointClass { X = 1, Y = 1 };
        PointClass pc2 = pc1; // pc2, pc1 ile AYNI nesneyi gosteriyor (referans kopyalandi, nesne degil)
        pc2.X = 99;
        Console.WriteLine($"3) pc1.X = {pc1.X}, pc2.X = {pc2.X}  -> pc1 DE degisti (class = reference type)");

        // 4) Metoda parametre olarak gecirme
        Point p3 = new Point { X = 5, Y = 5 };
        ChangeStruct(p3);
        Console.WriteLine($"4a) Struct metoda kopya olarak gider -> p3.X = {p3.X} (degismedi)");

        PointClass pc3 = new PointClass { X = 5, Y = 5 };
        ChangeClass(pc3);
        Console.WriteLine($"4b) Class metoda referans olarak gider -> pc3.X = {pc3.X} (degisti)");

        // 5) ref ve in ile value type parametreler
        int x = 1;
        ChangeWithRef(ref x); // ref: metot icinde yapilan degisiklik disariya da yansir
        Console.WriteLine($"5a) ref ile cagrildi -> x = {x} (degisti)");

        int y = 1;
        ReadWithIn(in y); // in: sadece okumaya izin verir, degistirilemez
        Console.WriteLine($"5b) in ile cagrildi -> y = {y} (degismedi, zaten degistirmeye izin yok)");

    }
    private static void ChangeStruct(Point p)
    {
        p.X = 1000; // burada degisen sadece metodun kendi kopyasi
        // p'nin disaridaki kopyasi degismiyor sadece bu değer burada local olarak kalıyor
        // return ile geri dondurup disarida tekrar atama yaparsan disaridaki degisir
    }

    private static void ChangeClass(PointClass pc)
    {
        pc.X = 1000; // burada disaridaki nesnenin kendisi degisiyor
    }

    private static void ChangeWithRef(ref int value)
    {
        value = 1000;
    }

    private static void ReadWithIn(in int value)
    {
        // value = 1000; // bu satırı acarsan derleme hatasi alirsin, "in" ile deger degistirilemez
        Console.WriteLine($"   (metot icinde okundu: {value})");
    }
}
