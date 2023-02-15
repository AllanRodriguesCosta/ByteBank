using ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.SistemaInterno
{
    public interface IAutenticarLogin
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public abstract bool Autenticar(string usuario, string senha);

    }
}
