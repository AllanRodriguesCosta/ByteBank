using ByteBank.Contas;
using ByteBank.Titular;
using ByteBankContas;
using System.Globalization;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta de André = "+contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//contaDaMaria.Depositar(300);

//Console.WriteLine("Saldo da conta de Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo de André = "+ contaDoAndre.saldo);
//Console.WriteLine("Saldo de Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia= 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = "+conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta " + conta.conta);
//Console.WriteLine("N° Agência " + conta.numero_agencia);
//Console.WriteLine("Saldo " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 23;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);

/*
ContaCorrente conta5 = new ContaCorrente(283, "1234-X");

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");

ContaCorrente conta7 = new ContaCorrente(285, "9877-Z");

Console.WriteLine("A quantidade total de contas criadas é: "+ContaCorrente.TotalDeContasCriadas);

Console.WriteLine("O valor da taxa de operação é: "+ContaCorrente.TaxaOperacao);
*/

/*
try 
{
    ContaCorrente conta1 = new ContaCorrente(278, "1234-X");
    conta1.Sacar(50);
    conta1.GetSaldo();
    Console.WriteLine(conta1.GetSaldo());

    conta1.Sacar(150);
    conta1.GetSaldo();
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}
*/

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{ 
   
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    
}
catch(IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida!");
}
finally 
{
    leitor.Fechar(); 
}