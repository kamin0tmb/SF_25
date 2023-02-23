using SF_25.DAL.DataForDB_;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.DAL
{
    public class AddDataInDB
    {
        readonly AuthorsData AD = new AuthorsData();
        readonly GenresData GD = new GenresData();
        readonly Publishing_housesData PD = new Publishing_housesData();
        readonly BooksData BD = new BooksData();
        readonly UsresData UD = new UsresData();
        readonly OrderData OD = new OrderData();

        public void AddData(AppContext db)
        {        
            AD.Record(db);
            GD.Record(db);
            PD.Record(db);
            BD.Record(db);
            UD.Record(db);
            OD.Record(db);
        }
    }
}
