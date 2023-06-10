using Volo.Abp.Application.Dtos;

namespace Varzesh3.Application.Contracts.CountryAggs
{
    public class CountryDto:EntityDto<int>
    {

        public string LeageTitle{get;set;}
        public int Varzesh3Id{get;set;}
    }
}