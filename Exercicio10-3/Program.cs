
Console.WriteLine("Exercício 3: Utilizando o método GroupBy Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para" +
    " agrupar as strings por tamanho\n");

string[] palavras = { "banana", "abacaxi", "uva","Kiwi", "laranja", "abacate",
"maça", "pera" };
var result = palavras.GroupBy(p => p.Length);
Console.WriteLine("Palavras agrupadas por tamanho:");
foreach (var group in result)
{
    Console.WriteLine("\nPalavras com tamanho " + group.Key + ":");
    foreach (var palavra in group)
    {
        Console.Write(" " + palavra + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();
