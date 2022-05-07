using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhileS
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int idade = 128;

            while (idade >= 128)
            {
                Console.WriteLine("Digite sua idade: ");
                int minhaIdade = Convert.ToInt32(Console.ReadLine());

                idade = idade + 1;
            }
        }
    }
}
