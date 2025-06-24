using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void AdicionarProgramador(string nome, string username, string pass, NivelExperiencia nivelexperiencia, Gestor Gestor)
        {
            using (var db = new OrganizacaoContext())
            {
                var programador = new Programador{Nome = nome, Username = username, Password = pass, NivelExperiencia = nivelexperiencia,Gestor = Gestor };

                db.Utilizadores.Attach(Gestor);


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

        public void EliminarGestor(Gestor gestor)
        {
            using (var db = new OrganizacaoContext())
            {
                var ProgramadoresDoGestor = from programadores in db.Progamadores
                                            where programadores.Gestor.Id == gestor.Id
                                            select programadores;

                foreach (var programador in ProgramadoresDoGestor)
                {
                    int IdProgramador = programador.Id;

                    var TarefasDosProgramadores = from tarefas in db.Tarefas
                                                  where tarefas.Programador.Id == IdProgramador
                                                  select tarefas;

                    db.Tarefas.RemoveRange(TarefasDosProgramadores);
                    db.Progamadores.Remove(programador);
                }

                var gestorDb = db.Gestores.Find(gestor.Id);
                if (gestorDb != null)
                {
                    db.Utilizadores.Remove(gestorDb);
                }

                db.SaveChanges();
            }
        }

        public void EliminarProgramador(Programador programador)
        {
            using (var db = new OrganizacaoContext())
            {
                var TarefasDoProgramador = from tarefas in db.Tarefas
                                            where tarefas.Programador.Id == programador.Id
                                            select tarefas;

                foreach (var tarefa in TarefasDoProgramador)
                {
                    db.Tarefas.Remove(tarefa);
                }

                var programadorDb = db.Progamadores.Find(programador.Id);
                if (programadorDb != null)
                {
                    db.Utilizadores.Remove(programadorDb);
                }

                db.SaveChanges();
            }
        }
        public void EditarGestor(Gestor gestor, string nome, string username, string pass, Departamento departamento, bool gerirutilizadores)
        {
            using (var db = new OrganizacaoContext())
            {
                var gestordb = db.Gestores.Find(gestor.Id);
                if (gestordb != null)
                {
                    gestordb.Nome = nome;
                    gestordb.Username = username;
                    gestordb.Password = pass;
                    gestordb.Departamento = departamento;
                    gestordb.GereUtilizadores = gerirutilizadores;
                    db.SaveChanges();
                }
            }
        }

        public void EditarProgramador(Programador prog, string nome, string username, string pass, NivelExperiencia nivel, Gestor Gestor)
        {
            using (var db = new OrganizacaoContext())
            {
                var programador = db.Progamadores.Find(prog.Id);
                var gestorDb = db.Gestores.Find(Gestor.Id);
                if (programador != null)
                {
                    programador.Nome = nome;
                    programador.Username = username;
                    programador.Password = pass;
                    programador.NivelExperiencia = nivel;
                    programador.Gestor = gestorDb;
                    db.SaveChanges();
                }
            }
        }


    }
}
