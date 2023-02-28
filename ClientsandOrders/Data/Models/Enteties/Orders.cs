using ClientsandOrders.Common;

namespace ClientsandOrders.Data.Enteties
{
    public class Orders : BaseEntity
    {
       
        public List<Orders> order { get; set; }
        public DateTime OrderDate { get; set; }
        public int ClientID { get; set; }
        public string Description { get; set; }
        public float OrderPrice { get; set; }
        public DateTime CloseDate { get; set; }
      

       

    }
}