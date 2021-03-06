using System.ComponentModel.DataAnnotations;

namespace TesteEf.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este Campo é Obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no maximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Este campo deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Invalida")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
