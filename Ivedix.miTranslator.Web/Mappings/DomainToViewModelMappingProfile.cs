
using AutoMapper;
using Ivedix.miTranslator.Model;
using Ivedix.miTranslator.Web.ViewModels;
namespace Ivedix.miTranslator.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Key, KeyViewModel>();
        }
    }
}