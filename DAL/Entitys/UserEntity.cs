using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL.Entitys
{
    public class UserEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Почта.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Телефон.
        /// </summary>
        public  string Phone { get; set; }

        // Навигационное свойство
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        
    }
}
