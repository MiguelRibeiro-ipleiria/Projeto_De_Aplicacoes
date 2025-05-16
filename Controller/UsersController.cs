using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                var gestor = new Gestor{Nome = nome, Username = username,Password = pass,Departamento = departamento,GereUtilizadores = gerirutilizadores};

                db.Utilizadores.Add(gestor);
                db.SaveChanges();
            }
        }

        public void AdicionarProgramador(string nome, string username, string pass, NivelExperiencia nivelexperiencia, Gestor IdDoGestor)
        {
            using (var db = new OrganizacaoContext())
            {
                var programador = new Programador{Nome = nome, Username = username, Password = pass, NivelExperiencia = nivelexperiencia,Gestor = IdDoGestor};

                db.Utilizadores.Add(programador);
                db.SaveChanges();
            }
        }

        public List<Programador> EnumararProgramadores() 
        {
            List<Programador> listaprogramadores = new List<Programador>();

            using (var db = new OrganizacaoContext())
            {
                var queryAllProgramadores = from programadores in db.Progamadores
                                            select programadores;
                queryAllProgramadores = queryAllProgramadores.Include(x => x.Gestor);
;

                foreach (var programador in queryAllProgramadores)
                {
                    listaprogramadores.Add(programador);
                }

                return listaprogramadores;
            }
        }

        // Enumera todos os Gestores
        public List<Gestor> EnumararGestores()
        {
            List<Gestor> listagestores = new List<Gestor>();

            using (var db = new OrganizacaoContext())
            {
                var queryAllCustomers = from gestores in db.Gestores
                                        select gestores;

                foreach (var gestor in queryAllCustomers)
                {
                    listagestores.Add(gestor);
                }

                return listagestores;
            }
        }
    }
}
