using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Domain.Entitities;

namespace XProject.Domain.Interfaces
{
    public interface IAppPageRepository
    {
        public Task<List<AppPage>> GetAll();
        public Task<AppPage?> GetById(string id);
        public Task<AppPage?> GetByName(string name);

        public Task<AppPage> Create(AppPage view);
        public Task<AppPage> Update(AppPage view);
        public Task<AppPage> Remove(AppPage view);
    }
}
