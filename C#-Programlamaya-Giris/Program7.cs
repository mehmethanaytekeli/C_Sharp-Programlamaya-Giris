using System;

class Program
{
    public static int fak(int sayi1)
    {
        if (sayi1 <= 1) { 
            return sayi1;
        }
        else
        {
            return sayi1 *fak(sayi1 - 1);
        }

    }

    static void Main(string[] args)
    {
        int sayi1;
        Console.Write("faktoryiyel sayısı: ");

        sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fak(sayi1));
    }
}
