using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Allatok
{
    public string Species;
    public string Name;
    public int Age;
    public double Weight;

    public Allatok(string species, string name, int age, double weight)
    {
        Species = species;
        Name = name;
        Age = age;
        Weight = weight;


    }
    static void Allat(string species, string name, int age, double weight)
    {
        Console.WriteLine("He/She is a " + species);
        Console.WriteLine("His/Her name is " + name );
        Console.WriteLine(age + " Years old");
        Console.WriteLine(weight +"Kg" );
    }
    static void Main(string[] args)
    {
        Allat("Pig", "Babe", 5, 45.7);
    }
}









