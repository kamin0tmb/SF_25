using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL.Entitys
{
    public class OrderEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Дата выдачи.
        /// </summary>
        public DateTime Date_of_issue { get; set; }
        /// <summary>
        /// Дата возврата.
        /// </summary>
        public DateTime Return_date { get; set; }
        /// <summary>
        /// Отметка о возврате.
        /// </summary>
        public bool Flag_return { get; set; }


        // Внешний ключ
        public int UserId { get; set; }
        // Навигационное свойство
        public UserEntity User { get; set; }

        // Внешний ключ
        public int BookId { get; set; }
        // Навигационное свойство
        public BookEntity Book { get; set; }
    }
}
