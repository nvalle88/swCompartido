namespace bd.swcompartido.entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EstadoCivil
    {
        [Key]
        public int IdEstadoCivil { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Estado c�vil:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

      
    }
}
