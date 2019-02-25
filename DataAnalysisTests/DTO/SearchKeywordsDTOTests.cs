using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using DataAnalysisTests.TestRepository;
using DouStatistics.DAL;
using DouStatistics.DAL.Repository;

namespace DataAnalysis.DTO.Tests
{
    [TestClass()]
    public class SearchKeywordsDTOTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var searchKeywordsDTO = new SearchKeywordsDTO(new KeyWordsRepository<KeyWords>());
            var keywords = searchKeywordsDTO.GetAll();

            Console.WriteLine(keywords.Count);
            Assert.AreEqual(keywords.Count, 10);
        }

        [TestMethod()]
        public void GetAllTest1()
        {
            var searchKeywordsDTO = new SearchKeywordsDTO(new KeyWordsRepository<KeyWords>());
            var keywords = searchKeywordsDTO.GetAll().Where(c => c.KeyWord == ".NET");

            Assert.AreEqual(keywords.Count(), 1);
        }

        [TestMethod()]
        public void GetAllTest2()
        {
            var searchKeywordsDTO = new SearchKeywordsDTO(new GenericRepository<KeyWords>());
            var keywords = searchKeywordsDTO.GetAll();
            var element = keywords.Where(c => c.KeyWord == ".NET");

            Console.WriteLine(element.Count());
            Assert.AreEqual(element.Count(), 2);
        }
    }
}