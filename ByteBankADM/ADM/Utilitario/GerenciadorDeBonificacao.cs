using ByteBankFuncionarios.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.ADM.Funcionários;

namespace ByteBank_ADM.ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalDeBonificacao += funcionario.GetBonificacao();
        }
    }
}
