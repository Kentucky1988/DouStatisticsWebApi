﻿using System.Collections.Generic;
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

        ///<summary>
        /// Получить все записи из таблицы
        ///</summary>
        public List<ResultsSearch> GetAll()
        {
            return _dB.GetAll();
        }
    }
}