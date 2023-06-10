using Varzesh3.Application.Contracts.CountryAggs;
using Varzesh3.Domain.LeagueAggregate;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Varzesh3.Application.CountryAggregation
{
    public class CountryApplicationService:ReadOnlyAppService<Country,CountryDto,int>,ICountryApplicatonServicecs
    {
        private readonly IReadOnlyRepository<Country,int> repository;
        public CountryApplicationService(IReadOnlyRepository<Country,int> repository)
        :base(repository){
            this.repository =repository;
        }
    }
}