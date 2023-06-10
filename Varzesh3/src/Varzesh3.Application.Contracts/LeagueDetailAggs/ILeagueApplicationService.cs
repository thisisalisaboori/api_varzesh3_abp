using System.Collections.Generic;
using System.Threading.Tasks;
using Varzesh3.Application.Contracts.LeagueHistory;
using Volo.Abp.Application.Services;

namespace Varzesh3.Application.Contracts.LeagueDetailAggs
{
    public interface ILeagueApplicationService:IReadOnlyAppService<LeagueDetailDto,int>
    {
        Task<List<LeagueDetailDto>> GetLeagueResult(int id);
        Task<List<LeagueDetailDto>> GetLeagueResult(int varzesh3Id,string period);        
    }
}