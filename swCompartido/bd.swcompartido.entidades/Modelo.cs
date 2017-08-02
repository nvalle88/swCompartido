namespace bd.swcompartido.entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class Modelo
    {
        [Key]
        public int IdModelo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Modelo:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Marca:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdMarca { get; set; }
        public virtual Marca Marca { get; set; }


    }
}
