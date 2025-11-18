using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Order
    {
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public bool DiscountCard { get; private set; }
        public OrderStatus Status { get; private set; }

        private List<IMenu> items = new List<IMenu>();
        public Order(int id, int table, bool discountCard, OrderStatus status)
        {
            Id = id;
            TableNumber = table;
            Status = status;
            DiscountCard = discountCard;
        }

        public void AddItem(IMenu item)
        {
            items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");
        }

        public void RemoveItem(string name)
        {
            var delete = items.FirstOrDefault(i => i.Name == name);
            if (delete != null)
            {
                items.Remove(delete);
                Console.WriteLine($"Видалено позицію: {name}");
            }
        }
        public decimal GetPrice()
        {
            decimal sum = items.Sum(i => i.Price);

            if (DiscountCard)
            {
                decimal discount = sum * 0.1m; 
                sum -= discount;
            }

            return sum;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Змінено статус: {Status}");
        }
        public void PrintOrder()
        {
            Console.WriteLine($"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {GetPrice()} грн");
        }
    }
}
