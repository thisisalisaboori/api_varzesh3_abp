using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Varzesh3.Application.Contracts.LeagueDetailAggs;
using Varzesh3.Domain.LeagueAggregate;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace Varzesh3.Application.LeagueDetailsAggregate
{
    public class LeagueDetailApplicationService:ReadOnlyAppService<LeagueDetail,LeagueDetailDto,int>,
    ILeagueApplicationService
    {
        private readonly IReadOnlyRepository<LeagueDetail,int> repository;

        public LeagueDetailApplicationService(IReadOnlyRepository<LeagueDetail,int> repository)
        :base(repository)
        {
            this.repository=repository;
        }


        public async Task<List<LeagueDetailDto>> GetLeagueResult(int id){
            var query= await  this.repository.GetQueryableAsync();
             var result=query.Where(x=>x.LeagueId == id).Select(x=>new LeagueDetailDto(){
                Av =x.Av, Eq=x.Eq, Id =x.Id,Loss =x.Loss, Play =x.Play,Point =x.Point,
                Rank =x.Rank,Team =x.Team,Win=x.Win,LeagueId =x.LeagueId
            } ).ToList();

            return result;
        }
        public async Task<List<LeagueDetailDto>> GetLeagueResult(int varzesh3Id,string period){
            var query= await  this.repository.GetQueryableAsync();
             var result=query.Where(x=>x.League.Period == period && x.League.Country.Varzesh3Id == varzesh3Id).Select(x=>new LeagueDetailDto(){
                Av =x.Av, Eq=x.Eq, Id =x.Id,Loss =x.Loss, Play =x.Play,Point =x.Point,
                Rank =x.Rank,Team =x.Team,Win=x.Win,LeagueId =x.LeagueId
            } ).ToList();

            return result;
        }     
    }
}