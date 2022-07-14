using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyTestT.Models
{
    public class Answer
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Текст ответа
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Код вопроса, для пользователя скрыт
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// Либо true, если вопрос выбран, либо false, если не выбран,
        /// либо null, когда анкета только пришла по сети
        /// Использовать при <see cref="Question.Type"/> single или multiple,
        /// иначе оставить null
        /// </summary>
        public bool? selected { get; set; }

        /// <summary>
        /// Текст ответа опрашиваемого.
        /// Использовать при <see cref="Question.Type"/> open,
        /// иначе оставить null
        /// </summary>
        public String typedText { get; set; }
    }
}
