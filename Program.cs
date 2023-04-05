using System;

namespace FarmManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Farm Management System");

            while (true)
            {
                Console.WriteLine("1. Add production data");
                Console.WriteLine("2. View production data");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProductionData();
                        break;

                    case 2:
                        ViewProductionData();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void AddProductionData()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter quantity produced: ");
            int quantityProduced = int.Parse(Console.ReadLine());

            Console.Write("Enter date of production (dd/mm/yyyy): ");
            DateTime dateOfProduction = DateTime.Parse(Console.ReadLine());

            

            Console.WriteLine("Production data added successfully.");
        }

        static void ViewProductionData()
        {
            

            Console.WriteLine("End of production data.");
        }
    }

    
}
