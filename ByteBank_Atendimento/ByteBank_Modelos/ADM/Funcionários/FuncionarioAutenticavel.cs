using ByteBank_ADM.ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.Funcionários
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticarLogin
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string usuario, string senha)
        {
            return Usuario == usuario;
            return Senha == senha;
        }
    }
}
