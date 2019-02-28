using System;
using System.Collections.Generic;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysisTests.TestRepository
{
    class ResultsSearchRepository<T> : IRepository<ResultsSearch> where T : ResultsSearch
    {
        public void Create(ResultsSearch model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ResultsSearch model)
        {
            throw new NotImplementedException();
        }

        public ResultsSearch Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResultsSearch> GetAll()
        {
            List<ResultsSearch> list = new List<ResultsSearch>();
            list.Add(new ResultsSearch { Id = 1, KeyWordId = 1, Amount = 32, Date = new DateTime(2019, 1, 1)});
            list.Add(new ResultsSearch { Id = 2, KeyWordId = 2, Amount = 0, Date = new DateTime(2019, 1, 2) });
            list.Add(new ResultsSearch { Id = 3, KeyWordId = 3, Amount = 469, Date = new DateTime(2019, 1, 3) });
            list.Add(new ResultsSearch { Id = 4, KeyWordId = 4, Amount = 477, Date = new DateTime(2019, 1, 4) });
            list.Add(new ResultsSearch { Id = 5, KeyWordId = 5, Amount = 168, Date = new DateTime(2019, 1, 5) });
            list.Add(new ResultsSearch { Id = 6, KeyWordId = 6, Amount = 526, Date = new DateTime(2019, 1, 6) });
            list.Add(new ResultsSearch { Id = 7, KeyWordId = 7, Amount = 526, Date = new DateTime(2019, 1, 7) });
            list.Add(new ResultsSearch { Id = 8, KeyWordId = 8, Amount = 10, Date = new DateTime(2019, 1, 8) });
            list.Add(new ResultsSearch { Id = 9, KeyWordId = 9, Amount = 0, Date = new DateTime(2019, 1, 9) });
            list.Add(new ResultsSearch { Id = 10, KeyWordId = 10, Amount = 3, Date = new DateTime(2019, 1, 10) });

            return list;
        }

        public void Update(ResultsSearch model)
        {
            throw new NotImplementedException();
        }
    }
}
