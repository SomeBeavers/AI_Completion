namespace CoreLibe.Paritals;

public partial class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    //public DateTime CreatedAt { get; set; }
    //public bool IsActive { get; set; }
    partial void UpdateItem(Item newItem);
    
    
}