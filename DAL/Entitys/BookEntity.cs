using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL.Entitys
{
    public class BookEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }        
        /// <summary>
        /// Год издания.
        /// </summary>
        public int Year_of_publication { get; set; }

        // Внешний ключ
        public int Publishing_houseId { get; set; }
        // Навигационное свойство
        public Publishing_houseEntity Publishing_house { get; set; }

        // Внешний ключ
        public int AuthorId { get; set; }
        // Навигационное свойство
        public AuthorEntity Author { get; set; }

        // Внешний ключ
        public int GenreId { get; set; }
        // Навигационное свойство
        public GenreEntity Genre { get; set; }

        // Навигационное свойство
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
