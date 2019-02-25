using System.Collections.Generic;
using System.Linq;
using DataAnalysis.Infrastructure;
using DataAnalysis.Models;
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

        /// <summary>
        /// Получить список ключевых слов 
        /// </summary>
        /// <returns>Список ключевых слов</returns>
        public List<KeyWordDto> GetAll()
        {
            return _dB.GetAll()
                .Select( c => new KeyWordDto { Id = c.Id, KeyWord = c.KeyWord, IsCategory = c.IsCategory})
                .ToList();
        }
        
        public KeyWordDto Get(int id)
        {
            KeyWords keyWord = _dB.Get(id);
            KeyWordDto keyWordDto = Mapper.KeyWords_To_KeyWordDto(keyWord);

            return keyWordDto;
        }

        public void Add(KeyWordDto keyWords)
        {
            KeyWords keyWord = Mapper.KeyWordDto_To_KeyWords(keyWords);
            _dB.Create(keyWord);
        }

        public void Update(KeyWordDto keyWords)
        {
            KeyWords keyWord = Mapper.KeyWordDto_To_KeyWords(keyWords);
            _dB.Update(keyWord);
        }
    }
}
