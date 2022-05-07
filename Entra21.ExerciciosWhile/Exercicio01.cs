using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int peca = 0;

            while(peca < 13)
            {
                Console.WriteLine("Digite o nome e o valor da peça: ");
                string nomeValorPeca = Console.ReadLine();

                peca = peca + 1;
            }
        }
    }
}
