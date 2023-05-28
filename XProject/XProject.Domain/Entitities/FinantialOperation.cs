using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProject.Domain.Entitities
{
    /// <summary>
    /// A FinancialOperation represents a generic financial transaction
    /// </summary>
    public class FinantialOperation
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Name { get; }
        public double Value { get; }
        public DateTime CreatedAt { get; } = DateTime.Now;

        public FinantialOperation(string id, string name, double value, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Value = value;
            CreatedAt = createdAt;
        }

        public FinantialOperation(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
