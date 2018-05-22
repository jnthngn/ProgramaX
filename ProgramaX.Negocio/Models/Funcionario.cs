using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaX.Negocio.Models
{
    public class Funcionario
    {
        public long id { get; set; }
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string confirmaSenha { get; set; }
        public string mail { get; set; }
        public string endereco { get; set; }
        public int permissao { get; set; }


    }
}
