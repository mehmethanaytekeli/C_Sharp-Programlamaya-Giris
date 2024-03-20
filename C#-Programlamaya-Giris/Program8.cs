using System;

class Program
{
    static double silindirhacmi(double taban,double yukseklik)
    {
        double hacim;
        hacim = taban * yukseklik * Math.PI * taban;
        return hacim;
    }
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Taban Yarıçapı kaç?");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yüksekliği kaç?");
        b = Convert.ToInt32(Console.ReadLine()); ;
        Console.WriteLine(Math.Round(silindirhacmi(a,b)));
    }
}