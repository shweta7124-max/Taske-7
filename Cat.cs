using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The cat says: Meow!");
    }
}