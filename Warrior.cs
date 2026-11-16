using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public class Warrior : ICombatant
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Warrior(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with {AttackPower} power!");
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} is defending!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health: {Health}");
    }
}