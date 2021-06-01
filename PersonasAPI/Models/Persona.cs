using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasAPI.Models
{
    public class Persona
    {
        private int IdPersonaFisica;
        private string Nombre;
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private string RFC;
        private string FechaNacimiento;
        private int UsuarioAgrega;

        public int idPersonaFisica { get => IdPersonaFisica; set => IdPersonaFisica = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string apellidoPaterno { get => ApellidoPaterno; set => ApellidoPaterno = value; }
        public string apellidoMaterno { get => ApellidoMaterno; set => ApellidoMaterno = value; }
        public string rfc { get => RFC; set => RFC = value; }
        public string fechaNacimiento { get => FechaNacimiento; set => FechaNacimiento = value; }
        public int usuarioAgrega { get => UsuarioAgrega; set => UsuarioAgrega = value; }
    }
}
