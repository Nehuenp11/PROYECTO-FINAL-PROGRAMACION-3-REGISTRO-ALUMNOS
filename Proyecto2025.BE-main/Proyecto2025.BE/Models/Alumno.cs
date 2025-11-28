using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto2025.BE.Models
{
    [Table("P3_alumnos")]
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required]
        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Column("correo_electronico")]
        public string? CorreoElectronico { get; set; }

        [Column("matricula")]
        public string? Matricula { get; set; }
    }
}