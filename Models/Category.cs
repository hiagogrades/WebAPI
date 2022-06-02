using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter no mínimo 3 caracteres")]
        public string Title { get; set; }

    }
}