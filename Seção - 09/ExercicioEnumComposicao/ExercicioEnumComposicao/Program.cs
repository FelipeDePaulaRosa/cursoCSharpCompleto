using ExercicioEnumComposicao.Entities;
using ExercicioEnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client Client = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Order Order = new Order ( DateTime.Now, OrderStatus.Processing, Client);
            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine(txt);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product Product = new Product(name, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem OrderItem = new OrderItem(quantity, price, Product);
                Order.AddItem(OrderItem);
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(Order);



        }
    }
}
