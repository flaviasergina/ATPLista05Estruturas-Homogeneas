using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5Atp
{
    public static class questao10
    {
        public static void rodar(string[] args)
        {
            int[,] matriz = new int[10, 10];

            PreencherMatriz(matriz);
            Console.WriteLine("Matriz original:");
            ExibirMatriz(matriz);

            TrocarLinhas(matriz, 2, 8);
            Console.WriteLine("Matriz após trocar linha 2 com linha 8:");
            ExibirMatriz(matriz);

            TrocarColunas(matriz, 4, 10);
            Console.WriteLine("Matriz após trocar coluna 4 com coluna 10:");
            ExibirMatriz(matriz);

            TrocarDiagonais(matriz);
            Console.WriteLine("Matriz após trocar diagonal principal com diagonal secundária:");
            ExibirMatriz(matriz);

            TrocarLinhaColuna(matriz, 5, 10);
            Console.WriteLine("Matriz após trocar linha 5 com coluna 10:");
            ExibirMatriz(matriz);

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

        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
        {
            int tamanho = matriz.GetLength(1);

            for (int j = 0; j < tamanho; j++)
            {
                int temp = matriz[linha1 - 1, j];
                matriz[linha1 - 1, j] = matriz[linha2 - 1, j];
                matriz[linha2 - 1, j] = temp;
            }
        }

        static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                int temp = matriz[i, coluna1 - 1];
                matriz[i, coluna1 - 1] = matriz[i, coluna2 - 1];
                matriz[i, coluna2 - 1] = temp;
            }
        }

        static void TrocarDiagonais(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                int temp = matriz[i, i];
                matriz[i, i] = matriz[i, tamanho - i - 1];
                matriz[i, tamanho - i - 1] = temp;
            }
        }

        static void TrocarLinhaColuna(int[,] matriz, int linha, int coluna)
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                int temp = matriz[i, linha - 1];
                matriz[i, linha - 1] = matriz[i, coluna - 1];
                matriz[i, coluna - 1] = temp;
            }
        }
    }
}
