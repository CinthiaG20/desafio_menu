using System.Collections;

namespace Ucu.Poo.Restaurant;

public class Order
{
    private ArrayList order = new ArrayList(); //atributo "lista de platillos"
    public double GetTotal() //metodo precio platillo
    {
        double subtotal = 0;
        foreach (Dish dish in order)
        {
            subtotal = subtotal + dish.Price;
        }

        return subtotal;
    }

    public int CountOrder()
    {
        return this.order.Count;
    }
    public void ClearOrder()
    {
        order.Clear();
    }
    public void AddDish(Dish dish)
    { 
        order.Add(dish);
    }
}