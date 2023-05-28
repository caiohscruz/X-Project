using XProject.Domain.Entitities;
using XProject.Domain.Enums;

namespace XProject.Application.Interfaces
{
    public interface IAppPageService
    {
        Task<IEnumerable<AppPage>> GetAll();
        Task<bool> CheckVisibility(AppPageEnum appPage);
        Task ChangeVisibility(string id);
    }
}
