namespace WebApplication1.Models
{
    public class Klient
    {
        public int Id { get; set; }
        public int Contact_information_Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Permition { get; set; }
    }
}
