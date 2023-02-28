using ClientsandOrders.Data.Enteties;
using Microsoft.AspNetCore.Mvc.Formatters;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;

namespace ClientsandOrders.Controllers
{
    public static class OrdersHelperController
    {
        public static string GetStringFromConsole(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            return value;
        }

        public static Orders GetOrderModelFromConsole()
        {
            var order = new Orders();
            order.Description = GetStringFromConsole("");
            return order;
        }

        static void ShowClientsTable()
        {
            Clients clients = new Clients();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Таблица Clients");
                Console.WriteLine("1. Добавить");
                Console.WriteLine("2. Редактировать");
                Console.WriteLine("3. Удалить");
                Console.WriteLine("4. Показать заказы клиента");
                Console.WriteLine("5. Вернуться к выбору таблицы");
                Console.WriteLine("6. Выйти");
                string clientChoiceString = Console.ReadLine();
                int clientChoice = Int32.Parse(Console.ReadLine());

               

            }
        }    
    }
}
