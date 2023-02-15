using ByteBank.Funcionários;
using ByteBank_ADM.ADM.Funcionários;
using ByteBank_ADM.ADM.Parcerias;
using ByteBank_ADM.ADM.SistemaInterno;
using ByteBank_ADM.ADM.Utilitario;

//Pedro e Roberta, primeira parte do módulo sobre herança e classes.
#region 
//Funcionario pedro = new Funcionario("123456789",2000);
//pedro.Nome = "Pedro Silveira";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Dominguez";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Tootal de bonificações: "+gerenciador.TotalDeBonificacao);
//Console.WriteLine("Tootal de Funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion



// Calculo das Bonificações
//CalcularBonificacao();

//UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    // Novos funcionários

    // paula - diretora
    Diretor paula = new Diretor("321456987");
    paula.Nome = "paula guimarães";

    Console.WriteLine(paula.Nome);
    Console.WriteLine(paula.GetBonificacao());

    // carlos - auxiliar
    Auxiliar carlos = new Auxiliar("321654987");
    carlos.Nome = "carlos tavares";

    Console.WriteLine(carlos.Nome);
    Console.WriteLine(carlos.GetBonificacao());

    // julia - designer
    Designer julia = new Designer("123789456");
    julia.Nome = "julia azevedo";

    Console.WriteLine(julia.Nome);
    Console.WriteLine(julia.GetBonificacao());

    // matheus - gerente de contas
    GerenteDeContas matheus = new GerenteDeContas("456789123");
    matheus.Nome = "matheus rodrigues";

    Console.WriteLine(matheus.Nome);
    Console.WriteLine(matheus.GetBonificacao());


 //Registro dos funcionários
#region
gerenciador.Registrar(paula);
gerenciador.Registrar(carlos);
gerenciador.Registrar(julia);
gerenciador.Registrar(matheus);
#endregion

// Soma total das bonificações
Console.WriteLine("Total de Bonificação = "+ gerenciador.TotalDeBonificacao);

}


// Sistema interno de autenticação de login
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("789654789");
    ingrid.Nome = "Ingrid Teixeira";
    ingrid.Usuario = "IngridTeixeira";
    ingrid.Senha = "159951";

    GerenteDeContas jorge = new GerenteDeContas("987987987");
    jorge.Nome = "Jorge Campos";
    jorge.Usuario = "JorgeCampos";
    jorge.Senha = "987123";

    ParceiroComercial fabricio = new ParceiroComercial();
    fabricio.Usuario = "FabricioSantos";
    fabricio.Senha = "123789";


    sistema.Logar(ingrid,"IngridTeixeira", "159951");
    sistema.Logar(jorge, "JorgeCampos", "987123");
    sistema.Logar(fabricio, "FabricioSantos", "123789");
}

Diretor paula = new Diretor("321456987");
paula.Nome = "paula guimarães";

Console.WriteLine(paula);