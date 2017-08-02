namespace bd.swcompartido.entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class TipoTransporte
    {
        [Key]
        public int IdTipoTransporte { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo de transporte:")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        
    }
}
