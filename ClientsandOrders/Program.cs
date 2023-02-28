
using ClientsandOrders.Data.Enteties;
using ClientsandOrders.SqlServer;

Clients cv = new Clients();


//class Program
//{
//    static List<Clients> client = new List<Clients>();
//    static List<Orders> order = new List<Orders>();

//    static void Main(string[] args)
//    {
//        //    bool exit = false;
//        //    while (! exit)
//        //    while (! exit)
//        //    {
//        //        Console.WriteLine("Выберите таблицу");
//        //        Console.WriteLine("1. Clients");
//        //        Console.WriteLine("2. Orders");
//        //        Console.WriteLine("3. Выйти");
//        //        string tableChoice = Console.ReadLine();

//        //        switch(tableChoice)
        //        {

        //            case "1":
        //                ShowClientsTable();
        //                break;

        //            case "2":
        //                ShowOrdersTable();
        //                break;

        //            case "3":
        //                exit = true;
        //                break;

        //            default:
        //                Console.WriteLine("Неверный выбор.");
        //                break;
        //        }
        //    }
        //}

//        static void ShowClientsTable()
//        {
//            Clients clients = new Clients();
//            bool exit = false;
//            while (!exit)
//            {
//                Console.WriteLine("Таблица Clients");
//                Console.WriteLine("1. Добавить");
//                Console.WriteLine("2. Редактировать");
//                Console.WriteLine("3. Удалить");
//                Console.WriteLine("4. Показать заказы клиента");
//                Console.WriteLine("5. Вернуться к выбору таблицы");
//                Console.WriteLine("6. Выйти");
//                string clientChoice = Console.ReadLine();

//                switch (clientChoice)

//                {
//                    case "1":
//                        Console.Write("Введите имя: ");
//                        string firstName = Console.ReadLine();
//                        clients.FirstName = firstName;
//                        Console.Write("Введите фамилию: ");
//                        string secondName = Console.ReadLine();
//                        clients.SecondName = secondName;
//                        Console.Write("Введите номер телефона: ");
//                        string phoneNum = Console.ReadLine();
//                        clients.PhoneNum = phoneNum;
//                        int orderAmounts = 0;
//                        clients.OrderAmount = orderAmounts;
//                        DateTime date = DateTime.Now;
//                        clients.DateAdd = date;

//                        using (var db = new AppDBContext())
//                        {
//                            db.Client.Add(clients);
//                            db.SaveChanges();
//                        }


//                        break;
//                }
//            }
//        }
//    }
//}
//        //        case "2":
//        //            Console.Write("Введите ID клиента: ");
//        //            int clientId = int.Parse(Console.ReadLine());
//        //            Console.Write("Введите новое имя: ");
        //            string newName = Console.ReadLine();
        //            client[clientId].FirstName = newName;
        //            break;

        //        case "3":
        //            Console.Write("Введите ID клиента: ");
        //            int clientIdToDelete = int.Parse(Console.ReadLine());
        //            client.RemoveAt(clientIdToDelete);
        //            break;

        //        case "4":
        //            Console.Write("Введите ID клиента: ");
        //            int clientIdToShowOrders = int.Parse(Console.ReadLine());
        //            ShowclientOrders(clientIdToShowOrders);
        //            break;

        //        case "5":
        //            exit = true;
        //            break;

        //        case "6":
        //            Environment.Exit(0);
        //            break;

        //        default:
        //            Console.WriteLine("Неверный выбор.");
        //            break;
        //    }
        //}
    //};

    //private static void ShowclientOrders(int clientIdToShowOrders)
    //{
    //    throw new NotImplementedException();
    //}

    ////static void ShowOrdersTable()
    ////{
    //    bool exit = false;
    //    while (!exit)
    //    {
    //        Console.WriteLine("Таблица Orders");
    //        Console.WriteLine("1. Добавить");
    //        Console.WriteLine("2. Редактировать");
    //        Console.WriteLine("3. Удалить");
    //        Console.WriteLine("4. Показать клиента заказа");
    //        Console.WriteLine("5. Вернуться к выбору таблицы");
    //        Console.WriteLine("6. Выйти");
    //        string orderChoice = Console.ReadLine();

    //        //switch (orderChoice)
    //        //{
            //    case "1":
            //        Console.Write("Введите ID клиента: ");
            //        int clientId = int.Parse(Console.ReadLine());
            //        Console.Write("Введите сумму заказа: ");
            //        uint orderAmount = uint.Parse(Console.ReadLine());
            //        Console.Write("Введите дату заказа в формате dd/mm/yyyy: ");
            //        DateTime orderTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            //        order.Add(new Orders(Program.client[clientId], orderAmount, orderTime));
            //        break;


//                default:
//                    Console.WriteLine("Неверный выбор.");
//                    break;
//            }
//        }
//    }

//    static void ShowClientOrders(int clientId)
//    {
//        Console.WriteLine($"Заказы клиента {client[clientId].FirstName}" +
//            $" {client[clientId].SecondName}:");
//        foreach (var order in order)
//        {
//            //if (client.Clients== client[clientId])
//            //{
//            //    Console.WriteLine($"Сумма заказа: {client.OrderAmount}, Дата: {client.DateAdd}");
//            //}
//        }
//    }
//}


            ////    case "2":
            ////        Console.Write("Введите ID заказа: ");
            ////        int orderId = int.Parse(Console.ReadLine());
            ////        Console.Write("Введите новую сумму заказа: ");
            ////        uint newOrderAmount = uint.Parse(Console.ReadLine());
            ////        Console.Write("Введите новую дату заказа в формате dd/mm/yyyy: ");
            ////        DateTime newOrderTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            //        Program.client[orderId].OrderAmount = newOrderAmount;
            //        Program.client[orderId].DateAdd = newOrderTime;
            //        break;

            //    case "3":
            //        Console.Write("Введите ID заказа: ");
            //        int orderIdToDelete = int.Parse(Console.ReadLine());
            //        order.RemoveAt(orderIdToDelete);
            //        break;

            //    //case "4":
            //    //    Console.Write("Введите ID заказа: ");
            //    //    int orderIdToShowClient = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine($"Клиент:{client.FirstName} +{orderIdToShowClient}}" +
            //    //        $" {order[orderIdToShowClient].ClientID.SecondName}");
            //    //    break;

            //    case "5":
            //        exit = true;
            //        break;

            //    case "6":
            //        Environment.Exit(0);
            //        break;
