using System;

namespace WebApplication1.Models
{
    public class Taken_Order
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Personal_Card_Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
