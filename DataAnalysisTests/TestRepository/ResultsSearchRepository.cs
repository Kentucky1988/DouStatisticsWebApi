using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            list.Add(new ResultsSearch { Id = 1, KeyWordId = 1, Amount = 32, Date = DateTime.Now});
            list.Add(new ResultsSearch { Id = 2, KeyWordId = 2, Amount = 0, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 3, KeyWordId = 3, Amount = 469, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 4, KeyWordId = 4, Amount = 477, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 5, KeyWordId = 5, Amount = 168, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 6, KeyWordId = 6, Amount = 526, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 7, KeyWordId = 7, Amount = 526, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 8, KeyWordId = 8, Amount = 10, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 9, KeyWordId = 9, Amount = 0, Date = DateTime.Now });
            list.Add(new ResultsSearch { Id = 10, KeyWordId = 10, Amount = 3, Date = DateTime.Now });

            return list;
        }

        public void Update(ResultsSearch model)
        {
            throw new NotImplementedException();
        }
    }
}
