using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo04
    {
        public void Executar()
        {
            string texto = "";
            string nome = "";
            while (nome != "Fim");
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                texto = texto + nome +"\n";
            }
        }
    }
}
