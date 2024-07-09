
Console.WriteLine("Exercício 4: Utilizando o método FirstOrDefault Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ " +
    "para obter o primeiro número par do array\n");

int[] numeros = { 5, 2, 8, 3, 1, 7, 4, 6 };
Console.WriteLine("5, 2, 8, 3, 1, 7, 4, 6 ");
int result = numeros.FirstOrDefault(n => n % 2 == 0);
Console.WriteLine("\nPrimeiro número par: " + result);
Console.ReadKey();