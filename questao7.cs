using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5Atp
{
    public static class questao7
    {
        public static void rodar(string[] args)
        {
            int[,] matriz = new int[5, 5];

            PreencherMatriz(matriz);
            Console.WriteLine("Matriz preenchida:");
            ImprimirMatriz(matriz);

            int somaLinha4 = CalcularSomaLinha4(matriz);
            Console.WriteLine("Soma da linha 4: " + somaLinha4);

            int somaColuna2 = CalcularSomaColuna2(matriz);
            Console.WriteLine("Soma da coluna 2: " + somaColuna2);

            int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal(matriz);
            Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal);

            int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria(matriz);
            Console.WriteLine("Soma da diagonal secundária: " + somaDiagonalSecundaria);

            int somaTotal = CalcularSomaTotal(matriz);
            Console.WriteLine("Soma total da matriz: " + somaTotal);

            Console.ReadLine();
        }

        static void PreencherMatriz(int[,] matriz)
        {
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 10);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int CalcularSomaLinha4(int[,] matriz)
        {
            int soma = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[3, j];
            }

            return soma;
        }

        static int CalcularSomaColuna2(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, 1];
            }

            return soma;
        }

        static int CalcularSomaDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, i];
            }

            return soma;
        }

        static int CalcularSomaDiagonalSecundaria(int[,] matriz)
        {
            int soma = 0;
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                soma += matriz[i, tamanho - i - 1];
            }

            return soma;
        }

        static int CalcularSomaTotal(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            return soma;
        }
    }
}
