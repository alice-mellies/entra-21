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
            int opcao = 5;

            while(opcao >= 5)
            {
                Console.WriteLine("Digite um número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(@"1 - SOMAR
2 - SUBTRAIR
3 - MULTIPLICAR
4 - DIVIDIR
5 - SAIR");
                Console.WriteLine("Escolha uma opção do menu acima ");
                int opçaoMenu = Convert.ToInt32(Console.ReadLine());

				if (opçaoMenu == 1)
				{
					Console.WriteLine("A soma dos numeros é: " + (numero1 + numero2));

				}
				else if (opçaoMenu == 2)
				{
					Console.WriteLine("A subtração dos numeros é: " + (numero1 - numero2));
				}
				else if (opçaoMenu == 3)
				{
					Console.WriteLine("A multiplicação dos numeros é: " + (numero1 * numero2));
				}
				else if (opçaoMenu == 4)
				{
					Console.WriteLine("A divisão dos numeros é: " + (numero1 / numero2));
				}
				
				opcao = opcao + 1;
			}
		}


	}
}
    

