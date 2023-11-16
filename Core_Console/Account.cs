namespace Core_Console;

internal class Account
{
    public string Name { get; set; } = "";
    public string Password { get; set; } = "";
    public string Email { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string Region { get; set; } = "";
    public string PostalCode { get; set; } = "";

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Password: {Password}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Postal Code: {PostalCode}");
    }
        
    public Account() { }
}