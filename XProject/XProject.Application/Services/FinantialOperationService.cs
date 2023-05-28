using AutoMapper;
using XProject.Application.Interfaces;
using XProject.Application.ViewModels;
using XProject.Domain.Entitities;
using XProject.Domain.Interfaces;

namespace XProject.Application.Services
{
    public class FinantialOperationService : IFinantialOperationService
    {
        IFinantialOperationRepository _finantialOperationRepository;
        private readonly IMapper _mapper;

        public FinantialOperationService(IFinantialOperationRepository finantialOperationRepository, IMapper mapper)
        {
            _finantialOperationRepository = finantialOperationRepository;
            _mapper = mapper;
        }

        public async Task Create(FinantialOperationViewModel operation)
        {
            await _finantialOperationRepository.Create(_mapper.Map<FinantialOperation>(operation));
        }

        public List<FinantialOperationViewModel> GetAll()
        {
            var operations = _finantialOperationRepository.GetAll();
            return _mapper.ProjectTo<FinantialOperationViewModel>(operations).ToList();
        }
    }
}
