using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class LoginController
    {
        public bool Login(string username, string password)
        {
            using (var db = new OrganizacaoContext())
            {
                var queryLoginUtilizador = from utilizador in db.Utilizadores
                                           where utilizador.Username == username && utilizador.Password == password
                                           select utilizador;

                if(queryLoginUtilizador.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
