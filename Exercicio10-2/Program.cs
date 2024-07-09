
Console.WriteLine("Exercício 2: Utilizando o método OrderBy Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar" +
    " os valores em ordem crescente\n");

int[] numeros = { 5, 2, 8, 3, 1, 7, 4, 6 };
Console.WriteLine("Ordem que esta = 5, 2, 8, 3, 1, 7, 4, 6 ");
var result = numeros.OrderBy(n => n);
Console.WriteLine("\nNúmeros na ordem ascendente:");
foreach (var n in result)
{
    Console.Write(n + " ");
}
Console.ReadKey();
