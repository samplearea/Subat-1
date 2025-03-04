using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan alınan 5 sayıyı bir diziye ekleyelim.
        int[] dizi = new int[5];  

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write("Bir sayı girin: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Dizinin elemanları:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi[i]);
        }

        // Dizinin en büyük sayısını bulalım.
        int enBuyuk = dizi[0];

        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        Console.WriteLine("Dizinin en büyük sayısı: " + enBuyuk);
    }
}
