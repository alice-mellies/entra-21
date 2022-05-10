using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
       public void Executar()
        {
            int quantidadeProdutos = 0;
            double valorProduto = 0;
            double valorPedido = 0;

            while(quantidadeProdutos < 5)

            {
                Console.WriteLine("Digite o nome do produto");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Dgite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de produtos: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                valorPedido = valorProduto + quantidadeProdutos;
                valorPedido = valorPedido + valorProduto;

                

            }
            Console.WriteLine("O valor do pedido sem desconto é: " + valorPedido );
            double valorPedidoDesconto = valorPedido - 150;
            Console.WriteLine("O valor do pedido com desconto é: " + valorPedidoDesconto);

        }
    }
}
