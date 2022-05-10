// See https://aka.ms/new-console-template for more information

using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------MENU--------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
7 - Exercicio 07
8 - Exercicio 08
9 - Exercicio 09
10 - Exercicio 10
11 - Exercicio 11
12 - Exercicio 12
13 - Exercicio 13
14 - Exercicio 14
15 - Exercicio 15
16 - Exercicio 16
17 - Exercicio 17");

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
if (opcaoDesejada == 5)
{
    Exercicio05 exercicio5 = new Exercicio05();
    exercicio5.Executar();
}
if (opcaoDesejada == 6)
{
    Exercicio06 exercicio6 = new Exercicio06();
    exercicio6.Executar();
}
if (opcaoDesejada == 7)
{
    Exercicio07 exercicio7 = new Exercicio07();
    exercicio7.Executar();
}
if (opcaoDesejada == 8)
{
    Exercicio06 exercicio6 = new Exercicio06();
    exercicio6.Executar();
}




