using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.BLL.Models
{
    public class OrderModel
    {
        public DateTime Date_of_issue { get; set; }
        public DateTime Return_date { get; set; }
        public string Flag_return { get; set; }//да/нет (вернул/не вернул)
        public string User { get; set; }
        public string Book { get; set; }
        public string Author { get; set; }
    }
}
