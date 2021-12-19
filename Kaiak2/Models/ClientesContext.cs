using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaiak2.Models
{
    public class ClientesContext : DbContext
    {
        public ClientesContext()
        {

        }

        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {

        }
        public DbSet<Clientes> Cliente { get; set; }
    }
}
