using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Varzesh3.Domain.LeagueAggregate
{
    public class LeagueHistory:AggregateRoot<int>
    {
        public string Period{get;set;}
        public virtual Country Country{get;set;}
        [ForeignKey("Country")]
        public int CountryId{get;set;}

        public virtual ICollection<LeagueDetail> Details{get;set;}
    }
}