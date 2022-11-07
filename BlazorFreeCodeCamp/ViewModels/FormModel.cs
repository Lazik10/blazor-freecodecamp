using System.ComponentModel.DataAnnotations;

namespace BlazorFreeCodeCamp.ViewModels
{
    public class FormModel
    {
        // 5) Use of data annotations attributes
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength (255)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
