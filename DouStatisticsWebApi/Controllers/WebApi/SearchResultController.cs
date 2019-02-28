using System;
using System.Threading.Tasks;
using System.Web.Http;
using DataAnalysis.DTO;
using DataAnalysis.Models;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;
using DouStatistics.DAL.Repository;
using DouStatisticsWebApi.Models;

namespace DouStatisticsWebApi.Controllers.WebApi
{
    [Route("api/SearchResult")]
    public class SearchResultController : ApiController
    {
        private readonly IRepository<ResultsSearch> _repository;

        public SearchResultController()
        {
            _repository = new GenericRepository<ResultsSearch>();
        }

        [HttpGet]
        [Route("GetPartOfList")]
        public IHttpActionResult GetPartOfList(RequestPartOfListModel model)
        {
            var requestPartOfList = new RequestPartOfList
            {
                Skip = model.Skip,
                ReturnLength = model.ReturnLength,
                DateFrom = model.DateFrom ?? new DateTime(2019, 1, 1),
                DateTo = model.DateTo ?? DateTime.Now.AddDays(1)
            };

            var result = new SearchResultDTO(_repository).GetPartOfList(requestPartOfList);

            return Ok(result);
        }
    }
}
