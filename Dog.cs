using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The dog says: Woof!");
    }
}