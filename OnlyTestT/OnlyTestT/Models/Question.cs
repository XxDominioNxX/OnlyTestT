using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyTestT.Models
{
    public class Question
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// open - открытый с вводом текста,
        /// single - один ответ,
        /// multiple - два ответа
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Список ответов
        /// </summary>
        public List<Answer> answers { get; set; }

        /// <summary>
        /// Обязательный или нет вопрос
        /// </summary>
        public bool required { get; set; }
    }
}
