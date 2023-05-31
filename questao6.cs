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
            int[] temperaturas = new int[31];
            int somaTemperaturas = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Digite a temperatura do dia {i + 1}: ");
                temperaturas[i] = Convert.ToInt32(Console.ReadLine());
                somaTemperaturas += temperaturas[i];
            }

            int menorTemperatura = temperaturas[0];
            int maiorTemperatura = temperaturas[0];

            foreach (int temperatura in temperaturas)
            {
                if (temperatura < menorTemperatura)
                {
                    menorTemperatura = temperatura;
                }

                if (temperatura > maiorTemperatura)
                {
                    maiorTemperatura = temperatura;
                }
            }

            double temperaturaMedia = (double)somaTemperaturas / temperaturas.Length;
            int diasInferioresMedia = 0;

            foreach (int temperatura in temperaturas)
            {
                if (temperatura < temperaturaMedia)
                {
                    diasInferioresMedia++;
                }
            }

            Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
            Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");
            Console.WriteLine($"Temperatura média: {temperaturaMedia:F2}°C");
            Console.WriteLine($"Número de dias com temperatura inferior à média: {diasInferioresMedia}");

            Console.ReadLine();
        }
    }
}
