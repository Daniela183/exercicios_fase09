
using System;

Console.WriteLine("9- Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros, retorne a soma de todos" +
    " os elementos da lista que são ímpares. Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns " +
    "números pares e use o método de extensão criado para obter a soma dos números ímpares da lista\n");

List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int soma = numeros.SomarNumerosImpares();
Console.WriteLine("Soma de números ímpares " + soma);
Console.ReadKey();
public static class ListExtensions
{
    public static int SomarNumerosImpares(this List<int> list)
    {
        int soma = 0;
        foreach (int n in list)
        {
            if (n % 2 == 1)
            {
                soma += n;
            }
        }
    return soma;
    }
}
