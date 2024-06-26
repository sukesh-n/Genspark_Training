﻿using PizzaStoreBLLLibrary;
using PizzaStoreModelLibrary;
using System;

namespace PizzaSellingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pizza Store");
            IMenuService menuService = new MenuService();
            OrderService orderService = new OrderService(menuService);
            IPaymentService paymentService = new PaymentService();
            IFeedbackService feedbackService = new FeedbackService();
            IReportService reportService = new ReportService();

            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Select Option:");
                Console.WriteLine("1. Place Order");
                Console.WriteLine("2. View Menu");
                Console.WriteLine("3. Process Payment");
                Console.WriteLine("4. Provide Feedback");
                Console.WriteLine("5. Generate Report");
                Console.WriteLine("6. View Orders");
                Console.WriteLine("7. Clear Orders");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        program.PlaceOrder(orderService);
                        break;
                    case 2:
                        
                        program.ViewMenu(menuService);
                        break;
                    case 3:
                        
                        program.ProcessPayment(paymentService);
                        break;
                    case 4:
                        
                        program.ProvideFeedback(feedbackService);
                        break;
                    case 5:
                        
                        program.GenerateReport(reportService);
                        break;
                    case 6:
                        program.ViewOrders(orderService);
                        break;
                    case 7:
                        program.ClearOrders(orderService);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        void PlaceOrder(OrderService orderService)
        {
            orderService.PlaceOrder();
        }

        void ViewMenu(IMenuService menuService)
        {
            menuService.GetMenu();
        }

        void ProcessPayment(IPaymentService paymentService)
        {
            paymentService.ProcessPayment(0);
        }

        void ProvideFeedback(IFeedbackService feedbackService)
        {
            Console.WriteLine("Enter feedback");
            string feedback = Console.ReadLine() ?? String.Empty;
            feedbackService.CollectFeedback(feedback);
        }

        void GenerateReport(IReportService reportService)
        {
            Console.WriteLine("Report");
            reportService.ChooseReport();
        }
        void ViewOrders(OrderService orderService)
        {
            orderService.ViewOrders();
        }
        void ClearOrders(OrderService orderService)
        {
            orderService.ClearOrders(); 
        }
    }
}
