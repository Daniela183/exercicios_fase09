
Console.WriteLine("2- Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir as seguintes especificações:" +
    "\r\n a-Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna um inteiro." +
    "\r\n b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros " +
    "\r\n c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido." +
    "\r\n d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela." +
    "\r\nDica: Utilize o método Invoke do delegate para invocar a operação matemática\n");

//Func<int, int, int> somar = (a, b) => a + b;
//int resultado = somar(10, 20);
//Console.WriteLine(resultado);

OperacaoMatematica opMat = new OperacaoMatematica(Soma);
// Executa o delegate com os valores 5 e 7 e exibe o resultado
int resultado = opMat.Invoke(5, 7);
Console.WriteLine(" Resultado da operação de soma: " + resultado);
Console.ReadKey();
static int Soma(int x, int y)
{
    return x + y;
}
delegate int OperacaoMatematica(int x, int y);