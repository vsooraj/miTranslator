
using AutoMapper;
using Ivedix.miTranslator.Model;
using Ivedix.miTranslator.Web.ViewModels;
namespace Ivedix.miTranslator.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<KeyFormViewModel, Key>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.KeyTitle))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.KeyDescription))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.KeyPrice))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.KeyCategory));
        }
    }
}