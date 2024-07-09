
Console.WriteLine("3- Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas ao usuário. O programa deve" +
    " seguir as seguintes especificações:\r\na-) Defina um multicast delegate chamado MensagemBoasVindas que não recebe parâmetros e não retorna nenhum " +
    "valor.\r\nb-) Defina duas funções que exibem uma mensagem de boas-vindas: uma em português e outra em inglês." +
    "\r\nc-) Crie um objeto delegate do tipo MensagemBoasVindas e adicione as duas funções criadas a ele usando o operador +=." +
    "\r\nd-) Chame o delegate para executar as duas funções e exibir as mensagens de boas-vindas.\n");

MensagemBoasVindas mensagem = new MensagemBoasVindas(BoasVindasEmPortugues);
mensagem += BoasVindasEmIngles;
mensagem.Invoke();
Console.ReadKey();
static void BoasVindasEmPortugues()
{
    Console.WriteLine(" Bem-vindo!");
}
static void BoasVindasEmIngles()
{
    Console.WriteLine(" Welcome!");
}
delegate void MensagemBoasVindas();
