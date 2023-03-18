using System;

namespace Tugas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator: ");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Input No Menu Yang Tersedia[1..4]: ");
            int nomor = int.Parse(Console.ReadLine());

            int a, b;
            //switch
            switch (nomor)
            {

                case 1:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Penambahan {0} + {1} = {2} ", a, b, Penambahan(a, b));
                    Console.WriteLine("Tekan key apa aja buat keluar");
                    break;

                case 2:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                    break;

                case 3:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
                    break;

                case 4:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));
                    break;

                default:
                    Console.WriteLine("\nLah kan ga ada bro di atas liat lagi deh");
                    Console.WriteLine("Tekan key apa aja buat keluar");
                    break;

            }

            Console.ReadKey();
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