using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyTestT.Models
{
    public class Survey
    {
        /// <summary>
        /// Дата создания опроса. Для пользователя скрыто
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Дата создания опроса. Для пользователя скрыто
        /// </summary>
        public DateTime? createdAt { get; set; }

        /// <summary>
        /// Дата начала опроса. Для пользователя скрыто.
        /// Должно быть выставлено при начале опроса
        /// </summary>
        public DateTime? beginDate { get; set; }

        /// <summary>
        /// Дата окончания опроса. Для пользователя скрыто
        /// Должно быть выставлено при завершении опроса
        /// </summary>
        public DateTime? endDate { get; set; }

        /// <summary>
        /// Название опроса.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Описание опроса.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Список вопросов.
        /// </summary>
        public List<Question> Questions { get; set; }

        /// <summary>
        /// Описание опроса.
        /// </summary>
        //public string research { get; set; } 
        //public string position { get; set; }
    }
}
