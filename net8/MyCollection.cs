namespace net8;

public interface IMyCollection<T>
{
    void AddItem(T item);
    Task<T> GetItemAsync(int number);
    Task<bool> RemoveItemAsync(T item);
}

public class MyCollection<T> : IMyCollection<T>
{
    private List<T> items;
    
    
    public void AddItem(T item)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetItemAsync(int number)
    {
        if (number < 0)
            throw new ArgumentOutOfRangeException(nameof(number),
                "Number must be greater than or equal to 0");
     

        if (items == null) throw new InvalidOperationException("Collection is not initialized");
        return await Task.FromResult(items[number]);
    }

    public Task<bool> RemoveItemAsync(T item)
    {
        throw new NotImplementedException();
    }
}


enum MyEnum
{
    Value1,
    Value2,
    Value3
}

