namespace SF_25.DAL
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\TEW_SQLEXPRESS;Database=EF_library_of_books;Trusted_Connection=True;Encrypt=false";
        //public static string MsSqlConnection => @"Server=.\SQLEXPRESS;Database=EF_library_of_books;Trusted_Connection=True;Encrypt=false";
    }
}
