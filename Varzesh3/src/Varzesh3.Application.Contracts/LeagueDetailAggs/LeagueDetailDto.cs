using Varzesh3.Application.Contracts.LeagueHistory;
using Volo.Abp.Application.Dtos;

namespace Varzesh3.Application.Contracts.LeagueDetailAggs
{
    public class LeagueDetailDto:EntityDto<int>
    {
        public int LeagueId{get;set;}
        public  LeagueHistoryDto League{get;set;}
        public int Rank{get;set;}
        public string Team{get;set;}
        public int Play{get;set;}
        public int Win{get;set;}
        public int Eq{get;set;}
        public int Loss{get;set;}
        public int Av{get;set;}
        public int Point{get;set;}
    }
}