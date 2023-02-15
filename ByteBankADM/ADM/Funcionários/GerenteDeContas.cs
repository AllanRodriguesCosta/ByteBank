using ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankFuncionarios.SistemaInterno;

namespace ByteBank_ADM.ADM.Funcionários
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

    }
}
