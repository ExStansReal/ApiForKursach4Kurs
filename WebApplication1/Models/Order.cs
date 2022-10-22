namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Type_Order_Id { get; set; }
        public int Klient_Id { get; set; }
        public string Description { get; set; }
        public int Payment { get; set; }

        //это чисто название чтобы выводить в списки, в БД этого нет!
        public string Name { get; set; }
    }
}
