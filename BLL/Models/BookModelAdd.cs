using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.BLL.Models
{
    public class BookModelAdd
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year_of_publication { get; set; }
        public string Publishing_house { get; set; }
    }
}
