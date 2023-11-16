namespace CoreLibe.Inheritance;

public interface IActionBase
{
    bool InvokeAction(IEnumerable<object> parameters);
}