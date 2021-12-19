using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kaiak2.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

        [MaxLength(40)]
        public string Nome { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

       
        public DateTime Data_Nascimento { get; set; }

        [MaxLength(12)]
        public string Telefone { get; set; }
    }
}
