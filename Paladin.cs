using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public class Paladin : ICombatant, IHealer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Paladin(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with a holy sword!");
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} raises a holy shield!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health: {Health}");
    }

    public void Heal(int hp)
    {
        Health += hp;
        Console.WriteLine($"{Name} heals for {hp} HP. Health: {Health}");
    }
}