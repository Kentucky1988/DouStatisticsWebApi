using DataAnalysis.Models;
using DouStatistics.DAL;

namespace DataAnalysis.Infrastructure
{
   public static class Mapper
    {
        public static KeyWordDto KeyWords_To_KeyWordDto(KeyWords keyWord)
        {
            var keyWordDto = new KeyWordDto
            {
                Id = keyWord.Id,
                KeyWord = keyWord.KeyWord,
                IsCategory = keyWord.IsCategory ?? false
            };

            return keyWordDto;
        }

        public static KeyWords KeyWordDto_To_KeyWords(KeyWordDto keyWordDto)
        {
            var keyWords = new KeyWords
            {
                Id = keyWordDto.Id,
                KeyWord = keyWordDto.KeyWord,
                IsCategory = keyWordDto.IsCategory
            };

            return keyWords;
        }
    }
}
