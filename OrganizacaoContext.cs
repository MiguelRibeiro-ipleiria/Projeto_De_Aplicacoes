using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace iTasks
{
    class OrganizacaoContext : DbContext
    {
        public DbSet<Utilizadores> Clientes { get; set; }
        public DbSet<Tarefa> Carro { get; set; }
    }
}
