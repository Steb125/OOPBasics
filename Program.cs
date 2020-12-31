using System;
using OOPBasics;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create a human with custom attributes
            Human Sean = new Human("Sean", 25, 30, 20, 125);
            Sean.PrintInfo();
            // Create second human with custom attributes
            Human Aneisha = new Human("Aneisha", 20, 25, 30, 150);
            Aneisha.PrintInfo();
            // Aneisha attacks Sean
            // Aneisha.Attack(Sean);
            // Aneisha attacks Sean until he is defeated
            while(!Sean.IsDead)
            {
                Aneisha.Attack(Sean);
            }

        }
    }
}
