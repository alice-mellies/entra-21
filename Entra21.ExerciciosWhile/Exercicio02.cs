using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nome = "";
            int quantidade = 0;

            while (nome != "fim")
            {
                Console.Write("Digite um nome, quando você digitar fim irá encerrar: ");
                nome = Console.ReadLine().ToLower().Trim();
                quantidade = quantidade + 1;


            }
        }
    }
}
