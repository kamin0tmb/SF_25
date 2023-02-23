using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL.Entitys
{
    public class AuthorEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Полное имя.
        /// </summary>
        public string Full_name { get; set; }

        // Навигационное свойство
        public List<BookEntity> Books { get; set; } = new List<BookEntity>();
    }
}
