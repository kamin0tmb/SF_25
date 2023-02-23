using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL.Entitys
{
    public class GenreEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Название жанра.
        /// </summary>
        public string Name { get; set; }

        // Навигационное свойство
        public List<BookEntity> Books { get; set; } = new List<BookEntity>();
    }
}
