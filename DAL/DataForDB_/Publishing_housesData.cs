using SF_25.DAL.Entitys;

namespace SF_25.DAL.DataForDB_
{
    public class Publishing_housesData
    {
        public Publishing_houseEntity Publishing_house1 = new Publishing_houseEntity { Name = "Эксмо" };
        public Publishing_houseEntity Publishing_house2 = new Publishing_houseEntity { Name = "Просвещение" };
        public Publishing_houseEntity Publishing_house3 = new Publishing_houseEntity { Name = "Азбука" };
        public Publishing_houseEntity Publishing_house4 = new Publishing_houseEntity { Name = "Дрофа" };
        public Publishing_houseEntity Publishing_house5 = new Publishing_houseEntity { Name = "Алтапресс" };
        public Publishing_houseEntity Publishing_house6 = new Publishing_houseEntity { Name = "Самокат" };

        public void Record(AppContext db)
        {            
            db.Publishing_houses.AddRange(Publishing_house1, Publishing_house2, Publishing_house3, Publishing_house4,
                                          Publishing_house5, Publishing_house6);
            db.SaveChanges();
        }
    }
}
