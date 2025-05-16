using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks.Controller
{
    class UsersController
    {
        public void AdicionarGestor(string nome, string username, string pass, Departamento departamento, bool gerirutilizadores)
        {
            using (var db = new OrganizacaoContext())
            {
                var gestor = new Gestor { Nome = nome, Username = username, Password = pass, Departamento = departamento, GereUtilizadores = gerirutilizadores};
                db.Utilizadores.Add(gestor);

                db.SaveChanges();
            }
        }

        public void AdicionarProgramador(string nome, string username, string pass, NivelExperiencia nivelexperiencia, Gestor IdDoGestor)
        {
            using (var db = new OrganizacaoContext())
            {
                var programador = new Programador { Nome = nome, Username = username, Password = pass, NivelExperiencia = nivelexperiencia, Gestor = IdDoGestor };
                db.Utilizadores.Add(programador);

                db.SaveChanges();
            }
        }
    }
}
