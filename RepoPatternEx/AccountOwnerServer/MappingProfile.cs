using AutoMapper;
using Entities.Models;
using Entities.Models.DataTransferObjects;

namespace AccountOwnerServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>()
                .ForMember(dest =>
                dest.Id,
                opt => opt.MapFrom(src => src.OwnerId));

            CreateMap<Account, AccountDto>();
            CreateMap<OwnerForCreationDto, Owner>();
            CreateMap<OwnerForUpdateDto, Owner>();
            CreateMap<AccountForCreationDto, Account>();
            CreateMap<AccountForUpdateDto, Account>();
        }
    }
}
