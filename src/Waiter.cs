using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter //se crea la clase waiter
{
    private string name; //se copia 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private ArrayList assignedTables = new ArrayList();
    public ArrayList AssignedTables
    {
        get { return assignedTables; }
    }

    public Waiter(string name)
    {
        Name = name;
    }

    public void AssignTable(Table table)
    {
        assignedTables.Add(table);
    }

    public string TakeOrder(Table table, Dish dish)
    {
        if (assignedTables.Contains(table))
        {
            table.AddOrder(dish);
            return "Platillo agregado con exito";
        }
        else
        {
            return "No es posible agregar el platillo a una mesa la cual no esta asignada";
        }
    }
}

