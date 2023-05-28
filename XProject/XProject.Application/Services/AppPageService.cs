using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Application.Interfaces;
using XProject.Domain.Entitities;
using XProject.Domain.Enums;
using XProject.Domain.Interfaces;

namespace XProject.Application.Services
{
    public class AppPageService : IAppPageService
    {
        IAppPageRepository _appPageRepository;

        public AppPageService(IAppPageRepository appPageRepository)
        {
            _appPageRepository = appPageRepository;
        }


        public async Task<IEnumerable<AppPage>> GetAll()
        {
            return await _appPageRepository.GetAll();
        }
        

        async Task<bool> IAppPageService.CheckVisibility(AppPageEnum appPage)
        {
            var page = await _appPageRepository.GetByName(Enum.GetName(typeof(AppPageEnum), appPage));
            return page.IsVisible;
        }

        async Task IAppPageService.ChangeVisibility(string id)
        {
            var page = await _appPageRepository.GetById(id);
            page.IsVisible = !page.IsVisible;
            await _appPageRepository.Update(page);
        }
    }
}
