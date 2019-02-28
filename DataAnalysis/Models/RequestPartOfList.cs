using System;

namespace DataAnalysis.Models
{
    public class RequestPartOfList
    {
        /// <summary>
        /// Сколько елементов пропустить
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Сколько елементов вернуть
        /// </summary>
        public int ReturnLength { get; set; }

        /// <summary>
        /// Отфильтровать, дата с
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Отфильтровать, дата по
        /// </summary>
        public DateTime DateTo { get; set; }
    }
}
