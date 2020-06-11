using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Application.Models.Models;
using Esmart.Domain.Models.Aggregates;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.Models.Profiles
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {
            CreateMap<OrganisationSubscriptionApplicationModel, OrganisationSubscriptionAggregate>().ReverseMap();
            CreateMap<OrganisationCycleApplicationModel, OrganisationCycleAggregate>().ReverseMap();
            CreateMap<OrganisationDomainModel, OrganisationAggregate>().ReverseMap();

        }
    }
}
