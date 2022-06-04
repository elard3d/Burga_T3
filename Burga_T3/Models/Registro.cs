using System;

namespace Burga_T3.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string NombreMascota { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public double Tamano { get; set; }
        public string DatosParticulares { get; set; }
        public string NombreDueno { get; set; }
        public string DireccionDueno { get; set;}
        
        public String Telefono { get; set; }

        public String Mail { get; set; }
    }
}