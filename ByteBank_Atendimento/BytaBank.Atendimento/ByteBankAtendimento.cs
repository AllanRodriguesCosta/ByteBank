using ByteBank.Contas;
using ByteBank.Titular;
using ByteBank_Atendimento.ByteBank.Exceptions;


namespace ByteBank_Atendimento.BytaBank.Atendimento
{
#nullable disable
    internal class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
            new ContaCorrente (85, "123456789") {Saldo=100, Titular = new Cliente{Cpf="12345",Nome="Wilson José",Profissao="Empreiteiro" }},
            new ContaCorrente (25, "123456987") {Saldo=5660, Titular = new Cliente{Cpf="54321",Nome="Pedro Alexandre",Profissao="Músico" }},
            new ContaCorrente (85, "123456456") {Saldo=17, Titular = new Cliente{Cpf="51423",Nome="Denilson Pereira",Profissao="Contador" }},
            new ContaCorrente (58, "123456123") {Saldo=356, Titular = new Cliente{Cpf="35214",Nome="Jennifer Souza",Profissao="Operadora de Caixa" }}
};

        
        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("==================================");
                    Console.WriteLine("===        Atendimento         ===");
                    Console.WriteLine("=== 1 - Cadastrar Conta        ===");
                    Console.WriteLine("=== 2 - Listar Contas          ===");
                    Console.WriteLine("=== 3 - Remover Conta          ===");
                    Console.WriteLine("=== 4 - Ordenar Contas         ===");
                    Console.WriteLine("=== 5 - Pesquisar Conta        ===");
                    Console.WriteLine("=== 6 - Sair do Sistema        ===");
                    Console.WriteLine("==================================");
                    Console.Write("Digite a opção desejada: ");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {

                        throw new ByteBankException(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverContas();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;

                    }
                }
            }
            catch (ByteBankException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }

        }

     

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===    CADASTRO DE CONTAS     ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe os dados da conta ===");
            Console.WriteLine("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());
            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da conta [NOVA] : {conta.Conta}");

            Console.WriteLine("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe Profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===      LISTA DE CONTAS      ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine(".. Não há contas cadastradas! ...");
                Console.ReadLine();
                return;
            }
            foreach (ContaCorrente item in _listaDeContas)
            {
                //Console.WriteLine("===   Dados da Conta   ===");
                //Console.WriteLine("Número da Conta : " + item.Conta);
                //Console.WriteLine("Saldo da Conta : " + item.Saldo);
                //Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
                //Console.WriteLine("CPF do Titular : " + item.Titular.Cpf);
                //Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("\n\n");
                Console.ReadKey();
            }

        }

        private void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===      REMOVER CONTAS       ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Número da conta a ser removida: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;
            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("... Conta removida da lista! ...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("... Conta para remoção não encontrada ...");
                Console.ReadLine();
            }
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("... Lista de contas ordenada ...");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===      PESQUISAR CONTA      ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("Desejar pesquisar por (1) NÚMERO DA CONTA ou (2) CPF DO TITULAR ou " +
                "(3) N° DA AGÊNCIA: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da conta: ");
                        String _numeroConta = Console.ReadLine();
                        Console.WriteLine("\n");
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Informe o CPF da conta: ");
                        String _cpf = Console.ReadLine();
                        Console.WriteLine("\n");
                        ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe o N° da Agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                        ExibirListaDeContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }



        #region Funções da case 5 "Pesquisar Contas"
        ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}

            //return conta;

            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();

        }

        ContaCorrente ConsultaPorCPFTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}

            //return conta;

            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
                        from conta in _listaDeContas
                        where conta.Numero_Agencia == numeroAgencia
                        select conta).ToList();
            return consulta;
        }

        void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine(" ... A consulta não retornou dados ...");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        #endregion
    }
}
