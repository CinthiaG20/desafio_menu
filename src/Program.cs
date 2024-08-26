using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

public class Program
{
    static void Main()
    {
        Dish d1 = new Dish("Milanesa", 300, false);
        Menu m1 = new Menu();

        m1.AddDish(d1);

        Dish resultado = m1.GetDishByName("Milanesa");
        Table mesa = new Table(1);
        Console.WriteLine(mesa.Order.GetTotal());  
        mesa.AddToOrder(d1);
        Console.WriteLine(mesa.Order.GetTotal());  
        Console.WriteLine(mesa.HasOrders());  
    
    }
}
