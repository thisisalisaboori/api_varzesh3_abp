using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Varzesh3.Domain.LeagueAggregate
{
    public class LeagueDetail:Entity<int>
    {
        [ForeignKey("League")]
        public int LeagueId{get;set;}
        public virtual LeagueHistory League{get;set;}
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