using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
    public class ProductFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nmae Is Required ...!!!")]
        [MaxLength(50, ErrorMessage = "name max length is 50 char ...!!!")]
        [MinLength(5, ErrorMessage = "name min length is 5 char ...!!!")]

        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Code Is Required ...!!!")]
        [MaxLength(5, ErrorMessage = "Code max length is 5 char ...!!!")]
        [MinLength(2, ErrorMessage = "Code min length is 2 char ...!!!")]

        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Code Is Required ...!!!")]

        [Range(200, 2000)]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }



    }
}
