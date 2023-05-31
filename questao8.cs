using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5Atp
{
    public static class questao8
    {
        public static void rodar(string[] args)
        {
            int[,] matriz = new int[4, 4];

            PreencherMatriz(matriz);
            Console.WriteLine("Matriz preenchida:");
            ImprimirMatriz(matriz);

            int somaAbaixoDiagonal = CalcularSomaAbaixoDiagonal(matriz);
            Console.WriteLine("Soma dos elementos abaixo da diagonal principal: " + somaAbaixoDiagonal);

            Console.WriteLine("Elementos da diagonal principal:");
            ExibirDiagonalPrincipal(matriz);

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

        static int CalcularSomaAbaixoDiagonal(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j < i)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            return soma;
        }

        static void ExibirDiagonalPrincipal(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();
        }
    }
