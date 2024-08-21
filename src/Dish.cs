using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;                //Atributo nombre
    public string Name
    {
        get { return name; }
        set { name = value ; }
    }

    private int price;                  //Atributo precio
    public int Price
    {
        get { return price; }
        set { price = value ; }
    }

    private bool isVegetarian;         //Atributo "vegetariano?"
    public bool IsVegetarian
    {
        get { return isVegetarian; }
        set { isVegetarian = value; }
    }

    public Dish(string name, int price, bool isVegetarian)          //Metodo Constructor
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = isVegetarian;
    }
}