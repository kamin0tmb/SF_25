using SF_25.DAL;

namespace SF_25.PLL
{
    public static class CreateDB
    {
        public static void Run()
        {
            using (var db = new AppContext())
            {
                db.DeletedDB();

                if (!db.Exists())
                {
                    db.CreatedDB();
                    var AddData = new AddDataInDB();
                    AddData.AddData(db);
                }
            }
        }
    }
}
