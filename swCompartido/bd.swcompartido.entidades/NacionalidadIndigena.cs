namespace bd.swcompartido.entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class NacionalidadIndigena
    {
        [Key]
        public int IdNacionalidadIndigena { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Nacionalidad  ind�gena:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Etnia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEtnia { get; set; }
        public virtual Etnia Etnia { get; set; }
    }
}
