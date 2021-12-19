using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kaiak2.Models
{
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }
        [MaxLength(40)]
        public string Nome { get; set; }
        [MaxLength(40)]
        public string Sobrenome { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Telefone { get; set; }
    }
}
