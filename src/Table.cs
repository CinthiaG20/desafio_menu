namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private Order order;
    public Order Order
    {
        get { return order; }
    }
    
    private int number;         //Atributo "Numero"

    public int Number           //Get Set del numero de mesa
    {
        get { return number; } set {
            
                number = value;
            
        }
    }
    
    private bool isOccupied;        //atributo "esta ocupado"
    public bool IsOccupied          //Get Set de "esta ocupado"
    {
        get { return isOccupied; } set {
            
            isOccupied = value;
            
        }
    }
    
    public Table (int number)                       //Metodo "Constructor mesa"
    {
        this.number = number;
        this.order = new Order();

    }
    public bool HasOrders()                         //Metodo "Si la mesa tiene ordenes"
    {
        return this.order.CountOrder() > 0;
    }

    public void Ocupy()                             //Metodo "Ocupar mesa"
    {
        this.isOccupied = true;
    }

    public void Free()                                  //Metodo "Vaciar mesa"
    {
        this.isOccupied = false;
        this.order.ClearOrder();
    }

    public void AddToOrder(Dish dish)                   //metodo "Agregar platillo al menu"
    {
        this.order.AddDish(dish);
    }
}