using System.ComponentModel.DataAnnotations;
namespace Cliente_Neumaticos.Models
    
{
    
    public class Cliente
    {
        //se agregan validaciones con data annotations 
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display (Name ="Nombre del cliente")]
        public string nombre { get; set; }

        [Required]
        [MaxLength(11)]
        public string RFC { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Calle")]
        public string D_calle { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Numero de domicilio")]
        public string D_numero_hogar { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Colonia")]
        public string D_colonia { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Estado")]
        public string D_estado { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Codigo postal")]
        public string cp { get; set; }

    }
}
