using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 1 caractere");
                }
                _nome = value;
            }
        }
            
        public string Cpf { get; set; }
        public string Profissao { get; set; }
    }
}
