using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using DataAnalysisTests.TestRepository;
using DouStatistics.DAL;
using DouStatistics.DAL.Repository;

namespace DataAnalysis.DTO.Tests
{
    [TestClass()]
    public class SearchResultDTOTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var searchKeywordsDTO = new SearchResultDTO(new ResultsSearchRepository<ResultsSearch>());
            var keywords = searchKeywordsDTO.GetAll();

            Console.WriteLine(keywords.Count);
            Assert.AreEqual(keywords.Count, 10);
        }

        [TestMethod()]
        public void GetAllTest1()
        {
            var searchKeywordsDTO = new SearchResultDTO(new ResultsSearchRepository<ResultsSearch>());
            var keywords = searchKeywordsDTO.GetAll().Where(c => c.KeyWordId == 7);

            Assert.AreEqual(keywords.Count(), 1);
        }

        [TestMethod()]
        public void GetAllTest2()
        {
            var searchKeywordsDTO = new SearchResultDTO(new GenericRepository<ResultsSearch>());
            var keywords = searchKeywordsDTO.GetAll();
            var element = keywords.Where(c => c.KeyWordId == 7);

            Console.WriteLine(element.Count());
            Assert.IsTrue(element.Any());
        }
    }
}