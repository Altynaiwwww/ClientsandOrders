using ClientsandOrders.Common;

namespace ClientsandOrders.Data.Enteties
{
    public class Clients : BaseEntity
    {
        public List<Clients> client { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNum { get; set; }
        public int OrderAmount { get; set; }
        public DateTime DateAdd { get; set; }



    }
}
