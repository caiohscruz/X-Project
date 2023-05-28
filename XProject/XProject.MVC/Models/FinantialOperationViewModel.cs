using XProject.Application.DTOs;
using XProject.Domain.Entitities;

namespace XProject.MVC.Models
{
    public class FinantialOperationViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
