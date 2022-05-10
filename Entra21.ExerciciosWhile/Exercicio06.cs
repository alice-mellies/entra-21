using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nome = "";
            double valorPedido = 0;
         

            while(nome != "sair")
             
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();
                if (nome != "sair")
                {
                    Console.WriteLine("Digite o valor do produto: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de produtos: ");
                    int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    valorPedido = valor + quantidadeProdutos;
                    valorPedido = valorPedido + valor;
                }
            }
            Console.WriteLine("O valor do pedido sem desconto é: " + valorPedido);
            double valorPedidoComDesconto = valorPedido - 0.95;

            Console.WriteLine("O valor do pedido com desconto é: " + valorPedidoComDesconto);
        }
    }
}
