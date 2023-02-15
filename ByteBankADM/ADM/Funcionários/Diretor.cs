using ByteBank.Funcionários;
using ByteBankFuncionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.Funcionários
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
