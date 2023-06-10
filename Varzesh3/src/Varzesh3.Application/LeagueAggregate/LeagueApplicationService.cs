using System.Diagnostics.Metrics;
using Varzesh3.Application.Contracts.LeagueDetailAggs;
using Varzesh3.Application.Contracts.LeagueHistory;
using Varzesh3.Application.Contracts.LeagueHistoryAggs;
using Varzesh3.Domain.LeagueAggregate;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Linq;

namespace Varzesh3.Application.LeagueAggregate
{
    public class LeagueApplicationService:ReadOnlyAppService<LeagueHistory,LeagueHistoryDto,int>,
    ILeagueHistoryApplicationService
    {
     private readonly IReadOnlyRepository<LeagueHistory,int> repository;

     public LeagueApplicationService(IReadOnlyRepository<LeagueHistory,int> repository)
     :base(repository)
     {
        this.repository=repository;
     }


     public async Task<List<LeagueHistoryDto>>  GetAllLeagueByCountry(int countryId){
        var query= await this.repository.GetQueryableAsync();
        var result= query.Where(x=>x.CountryId  == countryId)
        .Select(x=>new LeagueHistoryDto() {Id =x.Id ,Period =x.Period , 
                 Country = new Contracts.CountryAggs.CountryDto() {Id =x.Country.Id ,LeageTitle = x.Country.LeageTitle ,Varzesh3Id=x.Country.Varzesh3Id } }) 
        .ToList();
        return result;
     }
         
    }
}