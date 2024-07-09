
Console.WriteLine("6- Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação de adição ou subtração desses" +
    " números, a ser definida em tempo de execução por um delegate Func<int, int, int>.\n");

int numero1 = 5;
int numero2 = 3;
Func<int, int, int> operacao = (a, b) => a + b;
Console.WriteLine($"O resultado da operação é {Operar(numero1, numero2, operacao)}");
operacao = (a, b) => a - b;
Console.WriteLine($"O resultado da operação é {Operar(numero1, numero2, operacao)}");
Console.ReadKey();
static int Operar(int num1, int num2, Func<int, int, int> operacao)
{
    return operacao(num1, num2);
}
