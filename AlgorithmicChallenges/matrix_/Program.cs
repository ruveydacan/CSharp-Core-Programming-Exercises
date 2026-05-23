using System;

class Program
{
    static void Main()
    {
        // Sabit 3x4 matrisimiz
        int[,] dizi = {
            { 12, 45, 8, 21 },
            { 33, 7, 56, 14 },
            { 19, 82, 4, 37 }
        };

        // Sütun toplamlarını saklamak için 4 elemanlı bir dizi (Sütun sayısı kadar)
        int[] sutunToplamlari = new int[4];

        Console.WriteLine("--- SATIR VE SÜTUN TOPLAMLARI TABLOSU ---\n");

        // Başlıklar
        Console.WriteLine("S1".PadLeft(8) + "S2".PadLeft(8) + "S3".PadLeft(8) + "S4".PadLeft(8) + " | " + "TOPLAM".PadLeft(8));
        Console.WriteLine(new string('-', 45));

        // 1. SATIRLARI HESAPLA VE YAZDIR
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            int satirToplami = 0;
            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                Console.Write(dizi[i, j].ToString().PadLeft(8));

                satirToplami += dizi[i, j];           // Satır toplamına ekle
                sutunToplamlari[j] += dizi[i, j];     // İlgili sütun toplamına ekle
            }
            Console.WriteLine(" | " + satirToplami.ToString().PadLeft(8));
        }

        // 2. SÜTUN TOPLAMLARINI EN ALTA YAZDIR
        Console.WriteLine(new string('-', 45));

        // Sütun toplamları satırı
        foreach (int toplam in sutunToplamlari)
        {
            Console.Write(toplam.ToString().PadLeft(8));
        }
        Console.WriteLine(" <--- Sütun Toplamları");

        Console.ReadKey();
    }
}