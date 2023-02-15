
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.Funcionários
{
    // Não é possível criar objetos a partir de uma classe abstrata (bstract class)
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public override string ToString()
        {
            return $"Nome: {Nome}. \n" +
                   $"Cpf: {Cpf}. \n" +
                   $"Salario: {Salario}.";
        }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            Cpf = cpf;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();



    }
}
