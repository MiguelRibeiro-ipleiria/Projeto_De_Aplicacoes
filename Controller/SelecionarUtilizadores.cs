using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class SelecionarUtilizadores
    {
        public void AdicionarGestor(string nome, string username, string pass, Departamento departamento, bool gerirutilizadores)
        {
            using (var db = new OrganizacaoContext())
            {
                var gestor = new Gestor { Nome = nome, Username = username, Password = pass, Departamento = departamento, GereUtilizadores = gerirutilizadores };
                db.Utilizadores.Add(gestor);

                db.SaveChanges();
            }
        }
    }
}
