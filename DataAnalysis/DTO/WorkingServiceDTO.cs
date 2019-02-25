using System.Collections.Generic;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysis.DTO
{
    class WorkingServiceDTO
    {
        private readonly IRepository<WorkService> _dB;

        public WorkingServiceDTO(IRepository<WorkService> repository)
        {
            _dB = repository;
        }

        /// <summary>
        /// Получить записи работы службы
        /// </summary>
        public List<WorkService> GetAll()
        {
          return _dB.GetAll();
        }
    }
}
