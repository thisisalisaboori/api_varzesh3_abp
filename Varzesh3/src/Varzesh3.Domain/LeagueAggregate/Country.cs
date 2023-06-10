using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Varzesh3.Domain.LeagueAggregate
{
    public class Country:Entity<int>
    {
        
        public string LeageTitle{get;set;}
        public int Varzesh3Id{get;set;}
        public virtual ICollection<LeagueHistory> LeagueHistories{get;set;}
    }
}