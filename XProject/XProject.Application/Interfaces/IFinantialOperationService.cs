using XProject.Application.DTOs;
using XProject.Domain.Entitities;
using XProject.Domain.Enums;

namespace XProject.Application.Interfaces
{
    public interface IFinantialOperationService
    {
        Task<List<FinantialOperation>> GetAll();
        Task Create(FinantialOperationDTO operation);
    }
}
