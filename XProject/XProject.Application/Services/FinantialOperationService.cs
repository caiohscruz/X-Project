using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Application.DTOs;
using XProject.Application.Interfaces;
using XProject.Domain.Entitities;
using XProject.Domain.Interfaces;

namespace XProject.Application.Services
{
    public class FinantialOperationService : IFinantialOperationService
    {
        IFinantialOperationRepository _finantialOperationRepository;

        public FinantialOperationService(IFinantialOperationRepository finantialOperationRepository)
        {
            _finantialOperationRepository = finantialOperationRepository;
        }

        public async Task Create(FinantialOperationDTO operation)
        {

            await _finantialOperationRepository.Create(new FinantialOperation(operation.Name, operation.Value));
        }

        public async Task<List<FinantialOperation>> GetAll()
        {
            return await _finantialOperationRepository.GetAll();
        }
    }
}
