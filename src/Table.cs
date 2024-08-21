namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;

    public int Number
    {
        get { return Number; } set {
            
                Number = value;
            
        }
    }
    private bool isOccupied;

    public bool IsOccupied
    {
        get { return isOccupied; } set {
            
            isOccupied = value;
            
        }
    }
    private ArrayList order = new ArrayList();

    public Table (int number)
    {
        this.number = number;
        
    }
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    public void Ocupy()
    {
        this.isOccupied = true;
    }

    public void Free()
    {
        this.isOccupied = false;
        this.order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        this.order.Add(dish);
    }
}