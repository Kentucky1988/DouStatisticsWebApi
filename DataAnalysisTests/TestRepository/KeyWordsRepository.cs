using System;
using System.Collections.Generic;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysisTests.TestRepository
{
    class KeyWordsRepository<T> : IRepository<KeyWords> where T : KeyWords
    {
        public void Create(KeyWords model)
        {
            throw new NotImplementedException();
        }

        public void Delete(KeyWords model)
        {
            throw new NotImplementedException();
        }

        public KeyWords Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<KeyWords> GetAll()
        {
            List<KeyWords> list = new List<KeyWords>();
            list.Add(new KeyWords { Id = 1, KeyWord = "ActionScript", IsCategory = false});
            list.Add(new KeyWords { Id = 2, KeyWord = "AppleScript", IsCategory = false });
            list.Add(new KeyWords { Id = 3, KeyWord = "BASIC", IsCategory = false });
            list.Add(new KeyWords { Id = 4, KeyWord = "C", IsCategory = false });
            list.Add(new KeyWords { Id = 5, KeyWord = "C++", IsCategory = false });
            list.Add(new KeyWords { Id = 6, KeyWord = "C#", IsCategory = false });
            list.Add(new KeyWords { Id = 7, KeyWord = ".NET", IsCategory = false });
            list.Add(new KeyWords { Id = 8, KeyWord = "Clojure", IsCategory = false });
            list.Add(new KeyWords { Id = 9, KeyWord = "COBOL", IsCategory = false });
            list.Add(new KeyWords { Id = 10, KeyWord = "ColdFusion", IsCategory = false });

            return list;
        }

        public void Update(KeyWords model)
        {
            throw new NotImplementedException();
        }
    }
}
