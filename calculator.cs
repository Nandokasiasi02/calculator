using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Apikasi Kalkulator";

            Console.WriteLine("Pilih menu kalkulator : ");
            Console.WriteLine("1. Pertambahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian ");

            Console.WriteLine();
            Console.Write("Inputkan nomor menu [1 - 4] = ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            if (pilihan == 1)
            {
                Console.WriteLine();
                Console.Write("Inputkan Nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));

                Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                Console.ReadKey();

            }
            else if (pilihan == 2)
            {
                Console.WriteLine();
                Console.Write("Inputkan Nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));

                Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                Console.ReadKey();

            }
            else if (pilihan == 3)
            {
                Console.WriteLine();
                Console.Write("Inputkan Nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));

                Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                Console.ReadKey();
            }
            else if (pilihan == 4)
            {
                Console.WriteLine();
                Console.Write("Inputkan Nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

                Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak sesuai!");

                Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                Console.ReadKey();
            }



        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}