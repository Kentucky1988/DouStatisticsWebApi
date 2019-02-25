using System.Collections.Generic;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysis.DTO
{
    public class SearchKeywordsDTO
    {
        private readonly IRepository<KeyWords> _dB;

        public SearchKeywordsDTO(IRepository<KeyWords> repository)
        {
            _dB = repository;
        }

        //todo: добавить GetAll WorkingServiceDTO и LogExceptionDTO

        ///<summary>
        /// Получить список ключевых слов 
        ///</summary>
        public List<KeyWords> GetAll()
        {
            return _dB.GetAll();
        }
    }
}
