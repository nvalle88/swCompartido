namespace bd.swcompartido.entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ItemViatico
    {
        [Key]
        public int IdItemViatico { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo de vi�tico:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descipcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

       
    }
}
