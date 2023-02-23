using SF_25.DAL.Entitys;
using System;

namespace SF_25.DAL.DataForDB_
{
    public class OrderData
    {
        public OrderEntity Order1 = new OrderEntity { BookId = 1, UserId = 1, Date_of_issue = new DateTime(2021, 01, 10), Return_date = new DateTime(2021, 01, 20), Flag_return = true };
        public OrderEntity Order2 = new OrderEntity { BookId = 2, UserId = 10, Date_of_issue = new DateTime(2021, 01, 11), Return_date = new DateTime(2021, 01, 21), Flag_return = true };
        public OrderEntity Order3 = new OrderEntity { BookId = 3, UserId = 2, Date_of_issue = new DateTime(2021, 01, 11), Return_date = new DateTime(2021, 01, 21), Flag_return = true };
        public OrderEntity Order4 = new OrderEntity { BookId = 11, UserId = 9, Date_of_issue = new DateTime(2021, 01, 14), Return_date = new DateTime(2021, 01, 24), Flag_return = true };
        public OrderEntity Order5 = new OrderEntity { BookId = 5, UserId = 5, Date_of_issue = new DateTime(2021, 01, 15), Return_date = new DateTime(2021, 01, 25), Flag_return = true };
        public OrderEntity Order6 = new OrderEntity { BookId = 6, UserId = 4, Date_of_issue = new DateTime(2021, 01, 16), Return_date = new DateTime(2021, 01, 26), Flag_return = true };
        public OrderEntity Order7 = new OrderEntity { BookId = 7, UserId = 3, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public OrderEntity Order8 = new OrderEntity { BookId = 8, UserId = 1, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public OrderEntity Order9 = new OrderEntity { BookId = 9, UserId = 2, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public OrderEntity Order10 = new OrderEntity { BookId = 10, UserId = 6, Date_of_issue = new DateTime(2021, 01, 20), Return_date = new DateTime(2021, 01, 30), Flag_return = false };
        public OrderEntity Order11 = new OrderEntity { BookId = 4, UserId = 7, Date_of_issue = new DateTime(2021, 01, 22), Return_date = new DateTime(2021, 02, 01), Flag_return = true };
        public OrderEntity Order12 = new OrderEntity { BookId = 8, UserId = 8, Date_of_issue = new DateTime(2021, 01, 24), Return_date = new DateTime(2021, 02, 03), Flag_return = true };
        public OrderEntity Order13 = new OrderEntity { BookId = 15, UserId = 1, Date_of_issue = new DateTime(2021, 01, 28), Return_date = new DateTime(2021, 02, 07), Flag_return = true };
        public OrderEntity Order14 = new OrderEntity { BookId = 25, UserId = 2, Date_of_issue = new DateTime(2021, 01, 30), Return_date = new DateTime(2021, 02, 09), Flag_return = true };
        public OrderEntity Order15 = new OrderEntity { BookId = 1, UserId = 5, Date_of_issue = new DateTime(2021, 02, 05), Return_date = new DateTime(2021, 02, 15), Flag_return = true };
        public OrderEntity Order16 = new OrderEntity { BookId = 5, UserId = 3, Date_of_issue = new DateTime(2021, 02, 08), Return_date = new DateTime(2021, 02, 18), Flag_return = true };
        public OrderEntity Order17 = new OrderEntity { BookId = 10, UserId = 1, Date_of_issue = new DateTime(2021, 02, 15), Return_date = new DateTime(2021, 02, 25), Flag_return = true };
        public OrderEntity Order18 = new OrderEntity { BookId = 15, UserId = 6, Date_of_issue = new DateTime(2021, 02, 20), Return_date = new DateTime(2021, 03, 02), Flag_return = true };
        public OrderEntity Order19 = new OrderEntity { BookId = 20, UserId = 9, Date_of_issue = new DateTime(2021, 03, 05), Return_date = new DateTime(2021, 03, 15), Flag_return = true };
        public OrderEntity Order20 = new OrderEntity { BookId = 25, UserId = 1, Date_of_issue = new DateTime(2021, 03, 05), Return_date = new DateTime(2021, 03, 15), Flag_return = true };
        public OrderEntity Order21 = new OrderEntity { BookId = 2, UserId = 3, Date_of_issue = new DateTime(2021, 03, 12), Return_date = new DateTime(2021, 03, 22), Flag_return = true };
        public OrderEntity Order22 = new OrderEntity { BookId = 6, UserId = 2, Date_of_issue = new DateTime(2021, 03, 20), Return_date = new DateTime(2021, 03, 30), Flag_return = true };
        public OrderEntity Order23 = new OrderEntity { BookId = 11, UserId = 1, Date_of_issue = new DateTime(2021, 04, 03), Return_date = new DateTime(2021, 04, 13), Flag_return = true };
        public OrderEntity Order24 = new OrderEntity { BookId = 16, UserId = 10, Date_of_issue = new DateTime(2021, 04, 14), Return_date = new DateTime(2021, 04, 24), Flag_return = true };
        public OrderEntity Order25 = new OrderEntity { BookId = 21, UserId = 8, Date_of_issue = new DateTime(2021, 04, 22), Return_date = new DateTime(2021, 05, 02), Flag_return = true };
        public OrderEntity Order26 = new OrderEntity { BookId = 24, UserId = 1, Date_of_issue = new DateTime(2021, 04, 29), Return_date = new DateTime(2021, 05, 09), Flag_return = true };
        public OrderEntity Order27 = new OrderEntity { BookId = 23, UserId = 5, Date_of_issue = new DateTime(2021, 05, 08), Return_date = new DateTime(2021, 05, 18), Flag_return = true };
        public OrderEntity Order28 = new OrderEntity { BookId = 18, UserId = 7, Date_of_issue = new DateTime(2021, 05, 10), Return_date = new DateTime(2021, 05, 20), Flag_return = true };
        public OrderEntity Order29 = new OrderEntity { BookId = 13, UserId = 3, Date_of_issue = new DateTime(2021, 05, 24), Return_date = new DateTime(2021, 05, 04), Flag_return = true };
        public OrderEntity Order30 = new OrderEntity { BookId = 8, UserId = 2, Date_of_issue = new DateTime(2021, 06, 01), Return_date = new DateTime(2021, 06, 11), Flag_return = true };
        public OrderEntity Order31 = new OrderEntity { BookId = 14, UserId = 6, Date_of_issue = new DateTime(2021, 06, 07), Return_date = new DateTime(2021, 06, 07), Flag_return = true };
        public OrderEntity Order32 = new OrderEntity { BookId = 19, UserId = 4, Date_of_issue = new DateTime(2021, 06, 17), Return_date = new DateTime(2021, 06, 27), Flag_return = true };
        public OrderEntity Order33 = new OrderEntity { BookId = 4, UserId = 1, Date_of_issue = new DateTime(2021, 06, 20), Return_date = new DateTime(2021, 06, 30), Flag_return = true };
        public OrderEntity Order34 = new OrderEntity { BookId = 25, UserId = 2, Date_of_issue = new DateTime(2021, 07, 19), Return_date = new DateTime(2021, 07, 29), Flag_return = true };
        public OrderEntity Order35 = new OrderEntity { BookId = 3, UserId = 5, Date_of_issue = new DateTime(2021, 07, 28), Return_date = new DateTime(2021, 08, 09), Flag_return = true };
        public OrderEntity Order36 = new OrderEntity { BookId = 2, UserId = 10, Date_of_issue = new DateTime(2021, 08, 03), Return_date = new DateTime(2021, 08, 13), Flag_return = true };
        public OrderEntity Order37 = new OrderEntity { BookId = 12, UserId = 7, Date_of_issue = new DateTime(2021, 08, 10), Return_date = new DateTime(2021, 08, 20), Flag_return = true };
        public OrderEntity Order38 = new OrderEntity { BookId = 13, UserId = 4, Date_of_issue = new DateTime(2021, 08, 20), Return_date = new DateTime(2021, 08, 30), Flag_return = true };
        public OrderEntity Order39 = new OrderEntity { BookId = 3, UserId = 9, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = true };
        public OrderEntity Order40 = new OrderEntity { BookId = 17, UserId = 1, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public OrderEntity Order41 = new OrderEntity { BookId = 22, UserId = 2, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public OrderEntity Order42 = new OrderEntity { BookId = 23, UserId = 8, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public OrderEntity Order43 = new OrderEntity { BookId = 3, UserId = 3, Date_of_issue = new DateTime(2021, 09, 07), Return_date = new DateTime(2021, 09, 17), Flag_return = false };
        public OrderEntity Order44 = new OrderEntity { BookId = 24, UserId = 5, Date_of_issue = new DateTime(2021, 09, 10), Return_date = new DateTime(2021, 09, 20), Flag_return = false };
        public OrderEntity Order45 = new OrderEntity { BookId = 4, UserId = 2, Date_of_issue = new DateTime(2021, 09, 15), Return_date = new DateTime(2021, 09, 25), Flag_return = false };

        public void Record(AppContext db)
        {
            db.AddRange(Order1, Order2, Order3, Order4, Order5, Order6, Order7, Order8, Order9, Order10,
                        Order11, Order12, Order13, Order14, Order15, Order16, Order17, Order18, Order19, Order20,
                        Order21, Order22, Order23, Order24, Order25, Order26, Order27, Order28, Order29, Order30,
                        Order31, Order32, Order33, Order34, Order35, Order36, Order37, Order38, Order39, Order40,
                        Order41, Order42, Order43, Order44, Order45);
            db.SaveChanges();
        }
    }
}
