using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kaiak2.Models
{
    public class Clientes
    {
        [Key]
        public int IdContatos { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime Nascimento { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

    }
}
