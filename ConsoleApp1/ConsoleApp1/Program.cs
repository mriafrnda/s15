using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Filas="); int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Columnas="); int c = int.Parse(Console.ReadLine());
            int[,] m = new int[f, c];
            do { Console.Write("(1)Leer (2)Generar (3)Imprimir (4)Contar (5)Transpuesta (0)Salir ->"); opcion = int.Parse(Console.ReadLine()); Menu(opcion, m, f, c); }
            while (opcion != 0);
        }
        static void Menu(int opcion, int[,] m, int f, int c)
        {
            switch (opcion)
            {
                case 1: Leer(m, f, c); break;
                case 2: Generar(m, f, c); break;
                case 3: Imprimir(m, f, c); break;
                case 4: Contar(m, f, c); break;
                case 5: Transpuesta(m, f, c); break;
                case 0: Console.WriteLine("Saliedo..."); break;
                default: Console.WriteLine("Opción Inconrrecta"); break;
            }
        }
        static void Leer(int[,] m, int f, int c)
        {
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("m[]" + i + "," + j + "]=");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Generar(int[,] m, int f, int c)
        {
            Random num = new Random();
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++) { m[i, j] = num.Next(10); }
            }
        }
        static void Imprimir(int[,] m, int f, int c)
        {
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++) { Console.Write("\t" + m[i, j]); }
                Console.WriteLine();
            }
        }
        static void Contar(int[,] m, int f, int c)
        {
            int total = 0;
            for (int i = 0; i < f; i++)
            {
                int cont = 0;
                for (int j = 0; j < c; j++)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        cont++; total++;
                    }
                    Console.WriteLine(i + "->" + cont + "pares");
                }
                Console.WriteLine("Total de pares=" + total);
            }
        }
        static void Transpuesta(int[,] m, int f, int c) {
                int[,] temp = new int[c, f];
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    temp[j, i] = m[i, j];
                }
            }
            Imprimir(temp,c,f);
        } 
    }
}
