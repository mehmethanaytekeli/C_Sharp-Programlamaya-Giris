using System;

class Program
{
    public static int topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

    static void Main(string[] args)
    {
        int sayi1;
        Console.Write("1. sayı: ");
   
        sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Toplam: " + topla(3, sayi1, 5));
    }
}
