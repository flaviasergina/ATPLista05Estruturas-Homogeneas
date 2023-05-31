using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5Atp
{
    public static class questao6
    {
        public static void rodar()
        {
            Random random = new Random();
            int[] numerosSorteados = new int[3];
            for (int i = 0; i < 3; i++)

            {
                numerosSorteados[i] = random.Next(10, 51);
            }

            return numerosSorteados;
        }

        static void TentarAcertarNumero(int[] numerosSorteados)
        {
            while (true)
            {
                Console.Write("Digite um número entre 10 e 50: ");
                int tentativa;
                if (int.TryParse(Console.ReadLine(), out tentativa))
                {
                    if (Array.IndexOf(numerosSorteados, tentativa) != -1)
                    {
                        Console.WriteLine("Parabéns! Você acertou um número sorteado.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }

        static void Main()
        {
            int[] numerosSorteados = SortearNumeros();
            Console.WriteLine("Números sorteados: " + string.Join(", ", numerosSorteados));
            TentarAcertarNumero(numerosSorteados);
        }
    }
}
