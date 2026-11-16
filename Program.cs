using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

Console.WriteLine("=== Animal Sounds ===");

IAnimal dog = new Dog();
IAnimal cat = new Cat();

dog.MakeSound();
cat.MakeSound();

Console.WriteLine("\n=== Combat System ===");

ICombatant warrior = new Warrior("Aragorn", 100, 25);
ICombatant mage = new Mage("Merlin", 80, 35);

warrior.Attack();
warrior.Defend();
mage.Attack();
mage.Defend();

Console.WriteLine("\n=== Multiple Interfaces ===");

Paladin paladin = new Paladin("Arthur", 100, 30);

paladin.Attack();
paladin.Heal(20);

Console.WriteLine("\n=== Explicit Interface Implementation ===");

MultiFunctionDevice device = new MultiFunctionDevice();

IPrinter printer = device;
IScanner scanner = device;

printer.Start();
scanner.Start();