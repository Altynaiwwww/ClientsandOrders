
using ClientsandOrders.Common;
using ClientsandOrders.Data.Enteties;

namespace ClientsandOrders.Controllers
{
    public class Menu
    {
        public List<Clients> client = new List<Clients>();
        public List<Orders> orders = new List<Orders>();


        public void GetMenu() 
        {
           bool exit = false;

            while (!exit) 
            {
                Console.WriteLine("Выберите таблицу");
                Console.WriteLine("1.Clients");
                Console.WriteLine("2.Orders");
                Console.WriteLine("3.Exit");
                string tableChoice = Console.ReadLine();


                switch (tableChoice)
                {
                    case "1":
                }
            }
           
        }
    }
}
