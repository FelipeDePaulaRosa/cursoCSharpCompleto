using ExercicioEnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; } = new Client();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();
            //Console.WriteLine("ORDER SUMMARY:");
            Sb.AppendLine("Order moment: " + Moment);
            Sb.AppendLine("Order status: " + Status);
            Sb.AppendLine(Client.ToString());
            //Console.WriteLine("Order items");
            foreach(OrderItem i in Items)
            {
                Sb.AppendLine(i.ToString());
            }
            Sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            
            return Sb.ToString();

        }

    }
}
