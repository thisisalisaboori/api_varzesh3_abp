using AutoMapper;
using Varzesh3.Application.Contracts.CountryAggs;
using Varzesh3.Application.Contracts.LeagueDetailAggs;
using Varzesh3.Application.Contracts.LeagueHistory;
using Varzesh3.Domain.LeagueAggregate;

namespace Varzesh3;

public class Varzesh3ApplicationAutoMapperProfile : Profile
{
    public Varzesh3ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
         this.CreateMap<Country,CountryDto>();
         this.CreateMap<LeagueHistory,LeagueHistoryDto>();
         this.CreateMap<LeagueDetail,LeagueDetailDto>();
    }
}
