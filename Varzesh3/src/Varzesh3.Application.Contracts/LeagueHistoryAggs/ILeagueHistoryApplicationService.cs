using System.Collections.Generic;
using System.Threading.Tasks;
using Varzesh3.Application.Contracts.LeagueHistory;
using Volo.Abp.Application.Services;

namespace Varzesh3.Application.Contracts.LeagueHistoryAggs
{
    public interface ILeagueHistoryApplicationService:IReadOnlyAppService<LeagueHistoryDto,int>
    {
       Task<List<LeagueHistoryDto>>  GetAllLeagueByCountry(int countryId);         
    }
}