using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Restaurant
    {
        public List<IMenu> MenuList { get; private set; } = new List<IMenu>();
        public List<Order> OrderList { get; private set; } = new List<Order>();
        public void AddMenu(IMenu item)
        {
            MenuList.Add(item);
        }
        public void ShowMenu()
        {
            Console.WriteLine("МЕНЮ РЕСТОРАНУ");
            int i = 1;
            foreach (var el in MenuList)
            {
                Console.WriteLine($"{i}. {el.GetInfo()}");
                i++;
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public Order CreateOrder(int id, int table, bool discountCard, OrderStatus status)
        {
            Order order = new Order(id, table, discountCard, status);
            OrderList.Add(order);
            return order;
        }

        public Order? FindOrderById(int id)
        {
            return OrderList.FirstOrDefault(i => i.Id == id);
        }
        public void ShowOrders()
        {
            Console.WriteLine("\nУСІ ЗАМОВЛЕННЯ");
            foreach (var el in OrderList)
            {
                el.PrintOrder();
            }
        }
    }
}
