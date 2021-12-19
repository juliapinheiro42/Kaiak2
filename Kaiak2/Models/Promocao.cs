using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kaiak2.Models
{
    public class Promocao
    {
        [Key]
        public int Id_Promo { get; set; }

        [MaxLength(40)]
        public string Nome_Promo { get; set; }

        [MaxLength(15)]
        public string Valor_Promo { get; set; }
    }
}
