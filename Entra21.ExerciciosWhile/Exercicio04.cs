using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double peso = 0;
            int contador = 0;

            while ((peso >= 0) && (peso <= 300)) 
            {
                Console.Write("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                contador = contador + 1;

            }
            Console.WriteLine("A quantidade de pessoas que informaram seu peso é: " + contador);

        }
    }
}
