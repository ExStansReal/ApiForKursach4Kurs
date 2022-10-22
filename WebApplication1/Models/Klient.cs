namespace WebApplication1.Models
{
    public class Klient
    {
        public int Id { get; set; }
        public int Contact_information_Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Permition { get; set; }

        public  Klient(int contact_information_Id, string login, string password, int permition)
        {
            Contact_information_Id = contact_information_Id;
            Login = login;
            Password = password;
            Permition = permition;
        }

        public Klient()
        {

        }
    }
}
