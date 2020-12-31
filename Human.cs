// 1. Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
// 2. Add an additional private field for health (int), and a public property to access or "get" health
// 3. Add a constructor method that takes a string to initialize Name and that will initialize
    // Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
// 4. Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
// 5. Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. 
    // The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
    // This method should return the remaining health of the target object.

using System;
namespace OOPBasics
{
    class Human
{
    // Fields/Attributes for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    // 2. add a public "getter" property to access health
    public int Health
    {
        get
        {
            return health;
        }
    }
    // 3. add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            // this is implied in C#.  It is shown here but is not necessary.
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;

        }
    // 4. add a constructor to assign custom values to all fields
        // see Program.cs humans that have been created
    
    // 5. Build Attack method
    public void Attack(Human target)
    {
        Console.WriteLine($"{Name} attacked {target.Name} with a magnitude of {Strength}!");
        target.TakeDamage(Strength);
        // add IsDead to TakeDamage to determine if the target has survived
        if(target.IsDead)
        {
            Console.WriteLine($"{Name} has defeated {target.Name}");
        }
        target.PrintInfo();
    }

    // 6. Build a take damage method
    public int TakeDamage(int dmg)
    {
        health -= dmg;
        return health;
    }

    // 7. method to determine if the target is dead
    public bool IsDead
    {
        get
        {
            return health <=0;
        }
    }

    // 8. add Print method so we don't need to Console.WriteLine for each individual human in Program.cs
    public void PrintInfo()
    {
        Console.WriteLine("###################");
        Console.WriteLine($"Name: {Name}\n Strength: {Strength}\n Intelligence: {Intelligence}\n Dexterity: {Dexterity}\n Health: {health}\n");
        Console.WriteLine("###################");
    }
}
}