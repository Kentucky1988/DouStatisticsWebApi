using System;
using System.ComponentModel.DataAnnotations;

namespace DouStatisticsWebApi.Models
{
    public class RequestPartOfListModel
    {
        /// <summary>
        /// Сколько елементов пропустить
        /// </summary>
        [Required] public int Skip { get; set; }

        /// <summary>
        /// Сколько елементов вернуть
        /// </summary>
        [Required] public int ReturnLength { get; set; }

        /// <summary>
        /// Отфильтровать, дата с
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Отфильтровать, дата по
        /// </summary>
        public DateTime? DateTo { get; set; }
    }
}