using XProject.Application.ViewModels;
using XProject.Domain.Entitities;

namespace XProject.Application.Interfaces
{
    public interface IFinantialOperationService
    {
        List<FinantialOperationViewModel> GetAll();
        Task Create(FinantialOperationViewModel operation);
    }
}
