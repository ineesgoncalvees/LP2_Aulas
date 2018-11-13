using System;
using System.IO;
using System.IO.Compression;

namespace MyAula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
        }

        public static void Exercicio1()
        {
            FileStream file = File.Create("ficheiro.txt");

            StreamWriter sw = new StreamWriter(file);

            sw.WriteLine("qwdfghn");

            sw.WriteLine(1234);

            sw.WriteLine(12.123);

            sw.Close();
        }

        public static void Exercicio2()
        {
            string frase1;
            int frase2;
            double frase3;

            FileStream file = File.OpenRead("ficheiro.txt");

            StreamReader sr = new StreamReader(file);

            frase1 = sr.ReadLine();
            Console.WriteLine(frase1);

            frase2 = Convert.ToInt32(sr.ReadLine());
            Console.WriteLine(frase2);

            frase3 = Convert.ToDouble(sr.ReadLine());
            Console.WriteLine(frase3);

            sr.Close();
        }

        public static void Exercicio3()
        {
            FileStream file = File.Create("ficheirobinario.txt");

            BinaryWriter bw = new BinaryWriter(file);

            bw.Write("lkjhgfd");

            bw.Write(1234);

            bw.Write(123.234);

            bw.Close();
        }

        public static void Exercicio4()
        {
            string frase1;
            int frase2;
            double frase3;

            FileStream file = File.OpenRead("ficheirobinario.txt");

            BinaryReader br = new BinaryReader(file);

            frase1 = br.ReadString();
            frase2 = br.ReadInt32();
            frase3 = br.ReadDouble();

            Console.WriteLine(frase1);
            Console.WriteLine(frase2);
            Console.WriteLine(frase3);

            br.Close();
        }
    }
}
