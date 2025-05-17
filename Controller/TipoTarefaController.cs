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
    }
}
