using System;
public class Element
{
    public int Value { get; set; }

    public Element(int value)
    {
        Value = value;
    }
}

public class OneDimensionalArray
{
    public Element[] Elements { get; set; }
    public OneDimensionalArray(int size)
    {
        Elements = new Element[size];
    }
    public void FillArray ()
    {
        Random random = new Random();
        for (int i = 0; i < Elements.Length; i++)
        {
            int value = random.Next(1, 100);
            Elements[i] = new Element(value);
        }
    }
    public void PrintArray()
    {
        foreach (Element element in Elements)
        {
            Console.Write(element.Value + " ");
        }
        Console.WriteLine();
    }
    public OneDimensionalArray AddArrays(OneDimensionalArray array)
    {
        if (Elements.Length != array.Elements.Length)
        {
            Console.WriteLine("Масиви повинні мати однакову довжину.");
            return null;
        }

        OneDimensionalArray resultArray = new OneDimensionalArray(Elements.Length);

        for (int i = 0; i < Elements.Length; i++)
        {
            int value = Elements[i].Value + array.Elements[i].Value;
            resultArray.Elements[i] = new Element(value);
        }

        return resultArray;
    }
    public OneDimensionalArray SubtractArrays(OneDimensionalArray array)
    {
        if (Elements.Length != array.Elements.Length)
        {
            Console.WriteLine("Масиви повинні мати однакову довжину.");
            return null;
        }
        OneDimensionalArray resultArray = new OneDimensionalArray(Elements.Length);

        for (int i = 0; i < Elements.Length; i++)
        {
            int value = Elements[i].Value - array.Elements[i].Value;
            resultArray.Elements[i] = new Element(value);
        }

        return resultArray;
    }
    public OneDimensionalArray MultiplyArrays(OneDimensionalArray array)
    {
        if (Elements.Length != array.Elements.Length)
        {
            Console.WriteLine("Масиви повинні мати однакову довжину.");
            return null;
        }

        OneDimensionalArray resultArray = new OneDimensionalArray(Elements.Length);

        for (int i = 0; i < Elements.Length; i++)
        {
            int value = Elements[i].Value * array.Elements[i].Value;
            resultArray.Elements[i] = new Element(value);
        }

        return resultArray;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        OneDimensionalArray array1 = new OneDimensionalArray(5);
        array1.FillArray();
        Console.WriteLine("Масив 1:");
        array1.PrintArray();

        OneDimensionalArray array2 = new OneDimensionalArray(5);
        array2.FillArray();
        Console.WriteLine("Масив 2:");
        array2.PrintArray();

        OneDimensionalArray sumArray = array1.AddArrays(array2);
        Console.WriteLine(" Сума :");
        sumArray.PrintArray();

        OneDimensionalArray diffArray = array1.SubtractArrays(array2);
        Console.WriteLine("Рiзниця:");
        diffArray.PrintArray();

        OneDimensionalArray mulArray = array1.MultiplyArrays(array2);
        Console.WriteLine("Множення:");
        mulArray.PrintArray();
    }
}