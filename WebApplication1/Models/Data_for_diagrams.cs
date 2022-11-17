using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportService.Models
{
    public class Data_for_diagrams
    {
        public DateTime date { get; set; }

        public int collichetovo { get; set; }
    }

    public class Data_for_diagrams_Type_Order
    {
        public int count_of_order { get; set; }
        public string type_of_order { get; set; }
    }
}
