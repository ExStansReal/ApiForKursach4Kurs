namespace WebApplication1.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int Taken_order_Id { get; set; }
        public string Feedback_from_klient { get; set; }
        public string Feedback_from_employee { get; set; }

        public int Deleted { get; set; }
    }
}
