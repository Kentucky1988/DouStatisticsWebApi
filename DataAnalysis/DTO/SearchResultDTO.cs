using System.Collections.Generic;
using System.Linq;
using DataAnalysis.Models;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysis.DTO
{
    public class SearchResultDTO
    {
        private readonly IRepository<ResultsSearch> _dB;

        public SearchResultDTO(IRepository<ResultsSearch> repository)
        {
            _dB = repository;
        }

        //todo реализовать взможность отображения по 10-50 записей, не показывать все сразу для роботы службы, ошибках
        //todo добавить кеширование ключевых слов + добавлять в кеш только созданные слова, написать свой 

        ///<summary>
        /// Получить все записи из таблицы
        ///</summary>
        public List<ResultsSearch> GetAll()
        {
            return _dB.GetAll();
        }

        /// <summary>
        /// Вернуть часть списка
        /// </summary>
        public List<ResultsSearch> GetPartOfList(RequestPartOfList model)
        {
            var list = _dB.GetAll()
                          .Where(c => (c.Date >= model.DateFrom) && (c.Date <= model.DateTo))
                          .Skip(model.Skip)
                          .Take(model.ReturnLength)
                          .ToList();
            return list;
        }
    }
}
