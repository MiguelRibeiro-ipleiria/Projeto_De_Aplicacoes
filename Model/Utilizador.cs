using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iTasks
{
    public enum NivelExperiencia
    {
        Junior,
        Senior
    }

    public enum Departamento
    {
        IT,
        Marketing,
        Administracao
    }

    public class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }
    public class Gestor : Utilizador
    {
        public Departamento Departamento { get; set; }
        public bool GereUtilizadores { get; set; }



    }

    public class Programador : Utilizador
    {
        public NivelExperiencia NivelExperiencia { get; set; }
        public Gestor Gestor { get; set; }

    }
    
}
