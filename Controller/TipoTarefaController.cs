using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class TipoTarefaController
    {
        public void AdicionarTipoTarefa(string descricao)
        {
            using (var db = new OrganizacaoContext())
            {
                var TipoTarefa = new TipoTarefa {Nome = descricao};
                db.TipoTarefa.Add(TipoTarefa);

                db.SaveChanges();
            }
        }

        public List<TipoTarefa> MostrarTipoTarefa()
        {
            List<TipoTarefa> listaTT = new List<TipoTarefa>();

            using (var db = new OrganizacaoContext())
            {

                var queryTipoTarefa = from Tipos in db.TipoTarefa select Tipos;

                foreach (var Tipos in queryTipoTarefa)
                {
                    listaTT.Add(Tipos);
                }

                return listaTT;
            }
   
        }

        public void EliminarTipoTarefa(TipoTarefa TT)
        {
            using (var db = new OrganizacaoContext())
            {
                var TarefasComOTipoDeTarefa = from tarefas in db.Tarefas
                                     where tarefas.TipoTarefa.Id == TT.Id
                                     select tarefas;

                foreach (var tarefa in TarefasComOTipoDeTarefa)
                {
                    db.Tarefas.Remove(tarefa);
                }

                var tipoTarefaDb = db.TipoTarefa.Find(TT.Id);
                if (tipoTarefaDb != null)
                {
                    db.TipoTarefa.Remove(tipoTarefaDb);
                }
                db.SaveChanges();
            }
        }

        public void EditarTipoTarefa(TipoTarefa TT,string descricao)
        {
            using (var db = new OrganizacaoContext())
            {
                var tipoTarefaDb = db.TipoTarefa.Find(TT.Id);
                if (tipoTarefaDb != null)
                {
                    tipoTarefaDb.Nome = descricao;
                    db.SaveChanges();
                }
            }
        }
    }
}
