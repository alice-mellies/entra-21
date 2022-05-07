// See https://aka.ms/new-console-template for more information

using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------MENU--------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
7 - Exercicio 07");

Console.WriteLine("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio1 = new Exercicio01();
    exercicio1.Executar();
}
if (opcaoDesejada == 2)
{
    Exercicio02 exercicio2 = new Exercicio02();
    exercicio2.Executar();
}
if (opcaoDesejada == 3)
{
    Exercicio03 exercicio3 = new Exercicio03();
    exercicio3.Executar();
}
if (opcaoDesejada == 4)
{
    Exercicio04 exercicio4 = new Exercicio04();
    exercicio4.Executar();
}

