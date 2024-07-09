
Console.WriteLine("Exercício 1: Utilizando o método Where Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter " +
    "somente as strings que contenham a letra 'a'.\n");

string[] frutas = { "banana", "abacaxi", "uva", "laranja", "abacate", "Kiwi" };
var result = frutas.Where(w => w.Contains('a'));
Console.WriteLine("\nFrutas que contém a letra 'a':");
foreach (var fruta in result)
{
    Console.Write(" " + fruta + " ");
}
Console.ReadKey();
