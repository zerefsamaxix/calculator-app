using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
 public class Calculator{
    static void Main(string[] args)
    {
        Console.Title = "Calculator Apk";
        Console.Write("Pilih Menu Kalkulator = ");
        Console.Write("\n\n1.Penjumlahan\n2.Pengurangan\n3.Perkalian\n4.Pembagian\n\n");
        Console.Write("Pilihan Anda = ");
        int pilihan = int.Parse(Console.ReadLine());

        Console.WriteLine();
        if (pilihan==1){
            Console.Write("Masukan Angka Pertama = ");
            int a = int.Parse(Console.ReadLine());
    
            Console.Write("Masukan Angka Kedua = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Penambahan  {0} + {1} = {2}", a, b, penambahan(a,b));
        }else if (pilihan==2){
            Console.Write("Masukan Angka Pertama = ");
            int a = int.Parse(Console.ReadLine());
    
            Console.Write("Masukan Angka Kedua = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
        }else if (pilihan==3){
            Console.Write("Masukan Angka Pertama = ");
            int a = int.Parse(Console.ReadLine());
    
            Console.Write("Masukan Angka Kedua = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Perkalian   {0} * {1} = {2}", a, b, perkalian(a,b));
        }else if (pilihan==4){
            Console.Write("Masukan Angka Pertama = ");
            int a = int.Parse(Console.ReadLine());
    
            Console.Write("Masukan Angka Kedua = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil Pembagian   {0} / {1} = {2}", a, b, pembagian(a,b));
        }else{
            Console.WriteLine("Maaf Tidak Ada Pilihan Lain");
            
		}
        Console.WriteLine("Tekan Apapun....");
        Console.ReadLine();
    }
    static int penambahan(int a, int b)
    {
        return a+b;
    }
    
    static int pengurangan(int a, int b)
    {
        return a-b;
    }
    
    static int perkalian(int a, int b)
    {
        return a*b;
    }
    
    static int pembagian(int a, int b)
    {
        return a/b;
    }

    }
    }