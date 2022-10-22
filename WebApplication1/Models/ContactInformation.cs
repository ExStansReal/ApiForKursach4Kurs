namespace WebApplication1.Models
{
    public class ContactInformation
    {
        public int Id { get; set; }
        public string Link_to_VK { get; set; }
        public string Link_to_Telegram { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ContactInformation(string link_to_VK, string link_to_Telegram, string phone, string email)
        {
            Link_to_VK = link_to_VK;
            Link_to_Telegram = link_to_Telegram;
            Phone = phone;
            Email = email;
        }
        public ContactInformation()
        {

        }
    }
}
