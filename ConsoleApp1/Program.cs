using System;
using System.Collections.Generic;
using System.Linq;

public class Flower
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int FreshnessLevel { get; set; }
    public double StemLength { get; set; }

    public Flower(string name, double price, int freshnessLevel, double stemLength)
    {
        Name = name;
        Price = price;
        FreshnessLevel = freshnessLevel;
        StemLength = stemLength;
    }

    public override string ToString()
    {
        return $"Квiтка: {Name}, Цiна: {Price}грн, Рiвень свiжостi: {FreshnessLevel}, Довжина стебла: {StemLength}см";
    }
}

public class Tape
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Tape(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Обгортка: {Name}, Цiна: {Price}грн";
    }
}

public class Bouquet
{
    private List<Flower> flowers;
    public Tape Tape { get; set; }

    public Bouquet()
    {
        flowers = new List<Flower>();
    }

    public void AddFlower(Flower flower)
    {
        flowers.Add(flower);
    }

    public double CalculateTotalCost()
    {
        double totalCost = flowers.Sum(flower => flower.Price);
        if (Tape != null)
        {
            totalCost += Tape.Price;
        }
        return totalCost;
    }

    public void DisplayFlowers()
    {
        Console.WriteLine("Квiти в букетi:");
        foreach (Flower flower in flowers)
        {
            Console.WriteLine(flower);
        }
        if (Tape != null)
        {
            Console.WriteLine(Tape);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Flower rose = new Flower("Rose", 80, 5, 10);
        Flower lily = new Flower("Lily", 100, 4, 12);
        Flower tulip = new Flower("Tulip", 50, 6, 8);
        Tape tape = new Tape("Прозора плiвка", 15);

        Bouquet bouquet = new Bouquet();
        bouquet.AddFlower(rose);
        bouquet.AddFlower(lily);
        bouquet.AddFlower(tulip);
        bouquet.Tape = tape;

        bouquet.DisplayFlowers();

        double totalCost = bouquet.CalculateTotalCost();
        Console.WriteLine($"Загальна вартiсть букета з обгорткою: {totalCost}грн");
    }
}