using Varzesh3.Application.Contracts.CountryAggs;
using Volo.Abp.Application.Dtos;

namespace Varzesh3.Application.Contracts.LeagueHistory
{
    public class LeagueHistoryDto:EntityDto<int>
    {
        public string Period{get;set;}
        public  CountryDto Country{get;set;}
    }
}