using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo05
    {
        public void Executar()
        {
            int somaIdade = 0;
            int indice = 0;
            int maiorIdade = -200;
            int menorIdade = 200;

            while (indice < 2)

            {
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                somaIdade = somaIdade + idade;
                indice = indice + 1;

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if (idade < menorIdade)
                {
                    menorIdade = idade;
                }


            }
            double mediaIdade = somaIdade / indice;
            Console.WriteLine("Média das Idades: " + mediaIdade + "\nmenor idade: " + menorIdade + "\nmaior idade: " + maiorIdade);

        }
    }
}
