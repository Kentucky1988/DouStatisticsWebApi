using System.Collections.Generic;
using DouStatistics.DAL;
using DouStatistics.DAL.Interfaces;

namespace DataAnalysis.DTO
{
    class LogExceptionDTO
    {
        private readonly IRepository<LogException> _dB;

        public LogExceptionDTO(IRepository<LogException> repository)
        {
            _dB = repository;
        }

        /// <summary>
        /// Получить ошибки
        /// </summary>
        /// <returns>Список ошибок в базе</returns>
        public List<LogException> GetAlLogExceptions()
        {
            return _dB.GetAll();
        }

        /// <summary>
        /// Записать ошибку в базу
        /// </summary>
        /// <param name="exception">Ошибка</param>
        public void SaveError(LogException exception)
        {
            _dB.Create(exception);
        }
    }
}
