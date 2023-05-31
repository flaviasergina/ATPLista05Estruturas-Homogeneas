using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5Atp
{
    public static class questao9
    {
        public static void rodar(string[] args)
        {
            int[,] matrizA = new int[4, 6];
            int[,] matrizB = new int[4, 6];

            PreencherMatrizes(matrizA, matrizB);
            Console.WriteLine("Matriz A:");
            ImprimirMatriz(matrizA);
            Console.WriteLine("Matriz B:");
            ImprimirMatriz(matrizB);

            int[,] matrizSoma = CalcularSomaMatrizes(matrizA, matrizB);
            Console.WriteLine("Matriz Soma (A + B):");
            ImprimirMatriz(matrizSoma);

            int[,] matrizDiferenca = CalcularDiferencaMatrizes(matrizA, matrizB);
            Console.WriteLine("Matriz Diferença (A - B):");
            ImprimirMatriz(matrizDiferenca);

            Console.ReadLine();
        }

        static void PreencherMatrizes(int[,] matrizA, int[,] matrizB)
        {
            Random random = new Random();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(1, 10);
                    matrizB[i, j] = random.Next(1, 10);
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
            Console.WriteLine();
        }

        static int[,] CalcularSomaMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizSoma = new int[4, 6];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            return matrizSoma;
        }

        static int[,] CalcularDiferencaMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizDiferenca = new int[4, 6];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizDiferenca[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            return matrizDiferenca;
        }
    }
}
