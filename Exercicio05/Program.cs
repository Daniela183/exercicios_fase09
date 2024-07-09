
Console.WriteLine("5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros de 1 a 20. Para isso, " +
    "você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e imprima na tela apenas os números pares.\n");

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
Action<int> imprimirPares = (num) => {
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
};
numeros.ForEach(imprimirPares);
Console.ReadKey();
