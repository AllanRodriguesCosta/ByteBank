using ByteBank.Funcionários;
using ByteBank_ADM.ADM.SistemaInterno;
using ByteBankFuncionarios.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.Parcerias
{
    public class ParceiroComercial : IAutenticarLogin
    {


        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string usuario, string senha)
        {
            return Usuario == usuario;
            return Senha == senha;
        }

    }

}



