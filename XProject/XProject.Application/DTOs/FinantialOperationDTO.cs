using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProject.Application.DTOs
{
    public class FinantialOperationDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
