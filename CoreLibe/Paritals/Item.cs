namespace CoreLibe.Paritals;

public partial class Item
{
    public void DisplayItem()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
    }
}