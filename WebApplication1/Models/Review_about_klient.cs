namespace WebApplication1.Models
{
    public class Review_about_klient
    {
        public int Id { get; set; }
        public int Klient_id { get; set; }
        public int Personal_card_id { get; set; }
        public string Feedback_about_klient { get; set; }
        public double Rayting { get; set; }
    }
}
