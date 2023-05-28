using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Domain.Entitities;

namespace XProject.Domain.Interfaces
{
    public interface IFinantialOperationRepository
    {
        public Task<List<FinantialOperation>> GetAll();
        public Task<FinantialOperation?> GetById(string id);
        public Task<FinantialOperation> Create(FinantialOperation operation);
        public Task<FinantialOperation> Update(FinantialOperation operation);
        public Task<FinantialOperation> Remove(FinantialOperation operation);
    }
}
