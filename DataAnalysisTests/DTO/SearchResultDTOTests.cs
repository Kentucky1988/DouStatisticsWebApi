using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using DataAnalysis.Models;
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

        [TestMethod()]
        public void GetPartOfListTest()
        {
            var searchKeywordsDTO = new SearchResultDTO(new ResultsSearchRepository<ResultsSearch>());
            var model = new RequestPartOfList
            {
                Skip = 5,
                ReturnLength = 5,
                DateFrom = new DateTime(2019, 1, 2),
                DateTo = new DateTime(2019, 1, 9)
            };
            int lengthReturnList = 3;

            var list = searchKeywordsDTO.GetPartOfList(model);

            foreach (var record in list)
            {
                Console.WriteLine($"{record.Id} {record.KeyWordId} {record.Amount} {record.Date}");
            }
            
            Assert.AreEqual(list.Count, lengthReturnList);
        }

        [TestMethod()]
        public void GetPartOfListTest2()
        {
            var searchKeywordsDTO = new SearchResultDTO(new ResultsSearchRepository<ResultsSearch>());
            var model = new RequestPartOfList
            {
                Skip = 0,
                ReturnLength = 10,
                DateFrom = new DateTime(2019, 1, 1),
                DateTo = new DateTime(2019, 1, 9)
            };
            int lengthReturnList = 9;

            var list = searchKeywordsDTO.GetPartOfList(model);

            foreach (var record in list)
            {
                Console.WriteLine($"{record.Id} {record.KeyWordId} {record.Amount} {record.Date}");
            }

            Assert.AreEqual(list.Count, lengthReturnList);
        }
    }
}