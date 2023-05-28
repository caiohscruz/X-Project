using System.ComponentModel.DataAnnotations;

namespace XProject.Application.ViewModels
{
    public class FinantialOperationViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "The Value field must be a positive number.")]
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
