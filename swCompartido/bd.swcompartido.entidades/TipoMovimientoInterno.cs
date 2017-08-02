namespace bd.swcompartido.entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class TipoMovimientoInterno
    {
        [Key]
        public int IdTipoMovimientoInterno { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "tipo de movimiento interno:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

    }
}
