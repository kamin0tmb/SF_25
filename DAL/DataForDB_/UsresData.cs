using SF_25.DAL.Entitys;

namespace SF_25.DAL.DataForDB_
{
    public class UsresData
    {
        public UserEntity User1 = new UserEntity { FirstName = "Андрей", LastName = "Попов", Email = "andreq@mail.ru", Phone = "+7(999)232-55-85" };
        public UserEntity User2 = new UserEntity { FirstName = "Василий", LastName = "Егоров", Email = "vasil@mail.ru", Phone = "+7(989)113-52-25" };
        public UserEntity User3 = new UserEntity { FirstName = "Сергей", LastName = "Николаев", Email = "sergey@ya.ru", Phone = "+7(989)362-78-83" };
        public UserEntity User4 = new UserEntity { FirstName = "Светлана", LastName = "Мурашкина", Email = "cveta@mail.ru", Phone = "+7(979)421-57-81" };
        public UserEntity User5 = new UserEntity { FirstName = "Юрий", LastName = "Никонов", Email = "yura@ya.ru", Phone = "+7(999)477-12-43" };
        public UserEntity User6 = new UserEntity { FirstName = "Марина", LastName = "Рогова", Email = "marina@mail.ru", Phone = "+7(979)211-14-85" };
        public UserEntity User7 = new UserEntity { FirstName = "Татьяна", LastName = "Григорьева", Email = "tanj@ya.ru", Phone = "+7(999)521-89-98" };
        public UserEntity User8 = new UserEntity { FirstName = "Георгий", LastName = "Шмелёв", Email = "goga@ya.ru", Phone = "+7(989)852-96-74" };
        public UserEntity User9 = new UserEntity { FirstName = "Вячеслав", LastName = "Майоров", Email = "slsva@mail.ru", Phone = "+7(999)789-23-54" };
        public UserEntity User10 = new UserEntity { FirstName = "Роман", LastName = "Козицин", Email = "roma@ya.ru", Phone = "+7(999)526-91-73" };

        public void Record(AppContext db)
        {
            db.AddRange(User1, User2, User3, User4, User5, User6, User7, User8, User9, User10);
            db.SaveChanges();
        }
    }
}
