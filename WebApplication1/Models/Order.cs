namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Type_Order_Id { get; set; }
        public int Klient_Id { get; set; }
        public string Description { get; set; }
        public double Payment { get; set; }
    }
}
