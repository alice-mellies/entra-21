using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            int quantidadeCarros = 0;
            int contador = 0;
            int mediaAno = 0;
            int somaAno = 0;
            double somaValor = 0;
            double mediaValor = 0;
            int quantidadeA = 0;
            int quantidadeG = 0;
            Console.WriteLine("Digite a quantidade de carros a cadastrar");
            quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            

            while(contador < quantidadeCarros)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToLower().Trim();
                Console.WriteLine("Digite o valor do carro");
                double valorCarro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());
                contador = contador + 1;
                somaAno = somaAno + anoCarro;
                somaValor = somaValor + valorCarro;
                if(modeloCarro.StartsWith("a") == true)
                {
                    quantidadeA = quantidadeA + 1;
                }
                if (modeloCarro.StartsWith("g") == true)
                {
                    quantidadeG = quantidadeG + 1;
                }


            }
            mediaAno = somaAno / quantidadeCarros;
            mediaValor = mediaValor / quantidadeCarros;

            Console.WriteLine("A média do ano dos carros é: " + mediaAno);
            Console.WriteLine("A média do valor dos carro é: " + somaAno);
            Console.WriteLine("A quantidade de carros que começa com a letra A é: " + quantidadeA);
            Console.WriteLine("A quantidade de carros que começa com a letra G é: " + quantidadeG);

            
          


        }
    }
}
