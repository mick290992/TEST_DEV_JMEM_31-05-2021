

using System.ComponentModel.DataAnnotations;

namespace Front_Control.Models
{
    public class PersonaFisica
    {
        private int IdPersonaFisica;
        [Required]
        private string Nombre;
        [Required]
        private string ApellidoPaterno;
        [Required]
        private string ApellidoMaterno;
        [Required]
        private string RFC;
        [Required]
        private string FechaNacimiento;
        [Required]
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
