using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platzi_asp_net_core.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        /*[Required(ErrorMessage = "El nombre del curso es requerido")]
        [StringLength(5)]
        public override string Nombre { get; set; }
        [Display(Prompt = "Direccion correspondencia", Name="Addre" )]
        [Required(ErrorMessage= "Se requiere incluir una direccion")]
        [MinLength(10, ErrorMessage="La longitud minima de la direccion es 10")]
        public string Dirección { get; set; }*/
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Evaluación> Evaluaciones { get; set; }
    }
}