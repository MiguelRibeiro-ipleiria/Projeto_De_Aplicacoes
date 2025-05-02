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
    public class Utilizadores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Utilizadores(int ID, string NOME, string USERNAME, string PASS)
        {
            Id = ID;
            Nome = NOME;
            Username = USERNAME;
            Password = PASS;
        }
    }
    public class Gestor : Utilizadores
    {
        public string Departamento { get; set; }
        public bool GereUtilizadores { get; set; }


        public Gestor(int ID, string NOME, string USERNAME, string PASS, string DEPARTAMENTO, bool GEREUTILIZADORES) : base(ID, NOME, USERNAME, PASS)
        {
            Departamento = DEPARTAMENTO;
            GereUtilizadores = GEREUTILIZADORES;
        }
    }

    public class Programador : Utilizadores
    {
        public Enum NivelExperiencia { get; set; }
        public int IdGestor { get; set; }


        public Programador(int ID, string NOME, string USERNAME, string PASS, Enum NIVELEXPERIENCIA, int IDGESTOR) : base(ID, NOME, USERNAME, PASS)
        {
            NivelExperiencia = NIVELEXPERIENCIA;
            IdGestor = IDGESTOR;
        }
    }
    
}
