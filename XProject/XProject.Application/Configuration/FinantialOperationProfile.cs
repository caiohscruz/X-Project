using AutoMapper;
using XProject.Application.ViewModels;
using XProject.Domain.Entitities;

namespace XProject.Application.Configuration
{
    public class FinantialOperationProfile : Profile
    {
        public FinantialOperationProfile()
        {
            CreateMap<FinantialOperationViewModel, FinantialOperation>()
                .ConstructUsing((viewModel, context) =>
                    new FinantialOperation(viewModel.Name, viewModel.Value));     
            
            CreateMap<FinantialOperation, FinantialOperationViewModel>();
        }
    }
}
