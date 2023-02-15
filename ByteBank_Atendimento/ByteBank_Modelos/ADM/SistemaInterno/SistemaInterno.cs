
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticarLogin funcionario, string usuario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(usuario, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou Senha incorreta!");
                return false;
            }
        }

    }
}
