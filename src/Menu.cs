namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    private void AddDish(object Dish)
    {
        if (Dish != null){
        this.dishes.Add(Dish);}
        else
        {
            Console.WriteLine("Ese plato no existe");
        }
    }

    private void RemoveDish(object Dish)
    {
        if (Dish != null)
        {
            this.dishes.Remove(Dish);
            }
        else
        {
            Console.WriteLine("Ese plato no existe");   
        }
        }

    private Dish GetDishByName(string nombre)
    {
        foreach (Dish VARIABLE in this.dishes)
        {
            if (VARIABLE.Name == nombre)
            {
                return VARIABLE;
            }
        }

        return null;
    }
    }
