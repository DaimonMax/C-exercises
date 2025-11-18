using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Restaurant restaurant = new Restaurant();

        restaurant.AddMenu(new Dish("Борщ", 120, "Перше"));
        restaurant.AddMenu(new Dish("Відбивна", 150, "Друге"));
        restaurant.AddMenu(new Dish("Рис", 70, "Гарнір"));
        restaurant.AddMenu(new Dish("Каша", 50, "Гарнір"));
        restaurant.AddMenu(new Drink("Кава", 60, 200, false));
        restaurant.AddMenu(new Drink("Сік апельсиновий", 70, 250, false));
        restaurant.AddMenu(new Drink("Мохіто", 130, 200, true));
        restaurant.AddMenu(new Drink("Піво", 80, 300, true));
        restaurant.AddMenu(new Drink("Вода", 40, 300, false));

        restaurant.ShowMenu();

        bool discount10percent = true;

        Order order1 = restaurant.CreateOrder(101, 1, discount10percent, OrderStatus.New);
        Console.WriteLine($"Створено нове замовлення для столика №1 (Дисконтна карта: {(order1.DiscountCard ? "Є" : "Немає")})");
        order1.AddItem(restaurant.MenuList[0]);
        order1.AddItem(restaurant.MenuList[5]);
        order1.AddItem(restaurant.MenuList[6]);
        Console.WriteLine($"Сума замовлення: {order1.GetPrice()} грн");

        Console.WriteLine($"\nСтатус замовлення: {order1.Status}");
        order1.ChangeStatus(OrderStatus.InProgress);

        Console.WriteLine("-----------------------------------------------------------");

        Order order2 = restaurant.CreateOrder(102, 2, discount10percent, OrderStatus.New);
        Console.WriteLine($"Створено нове замовлення для столика №2 (Дисконтна карта: {(order2.DiscountCard ? "Є" : "Немає")})");
        order2.AddItem(restaurant.MenuList[1]);
        order2.AddItem(restaurant.MenuList[2]);
        order2.AddItem(restaurant.MenuList[6]);
        Console.WriteLine($"Сума замовлення: {order2.GetPrice()} грн");

        Console.WriteLine($"\nСтатус замовлення: {order2.Status}");
        order2.ChangeStatus(OrderStatus.Ready);

        Console.WriteLine("-----------------------------------------------------------");

        Order order3 = restaurant.CreateOrder(103, 3, false, OrderStatus.New);
        Console.WriteLine($"Створено нове замовлення для столика №3 (Дисконтна карта: {(order3.DiscountCard ? "Є" : "Немає")})");
        order3.AddItem(restaurant.MenuList[3]);
        order3.AddItem(restaurant.MenuList[4]);
        order3.AddItem(restaurant.MenuList[5]);
        order3.RemoveItem("Каша");
        Console.WriteLine($"Сума замовлення: {order3.GetPrice()} грн");


        Console.WriteLine($"\nСтатус замовлення: {order3.Status}");
        order3.ChangeStatus(OrderStatus.Paid);


        Console.WriteLine("\nПошук замовлення ID 102:");
        var found = restaurant.FindOrderById(102);
        if (found != null) found.PrintOrder();

        restaurant.ShowOrders();
        Console.ReadKey();
    }
}