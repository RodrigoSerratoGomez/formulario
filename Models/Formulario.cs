using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace formulario.Models
{
    public class Formulario
    {
        [Display(Name = "Primer Nombre", Prompt = "Ingresar Primer Nombre")]
        public string? Nombre {get; set;}

        [Display(Name = "Apellidos", Prompt = "Ingresar Ambos Apellidos")]
        public string? Apellido {get; set;}

        [Display(Name = "Título Profesional", Prompt = "Ingre el Título de su Trabajo")]
        public string? Titulo {get; set;}

        [Display(Name = "Nivel Educativo")]
        public string? Nivel {get; set;}

        [Display(Name = "Sexo")]
        public string? Sexo {get; set;}

        [Display(Name = "Años de Experiencia")]
        public string? Experiencia {get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public string? Fecha {get; set;}
    }
}