namespace CoreLibe.Inheritance;

public class ActionBase : IActionBase
{
    public virtual bool InvokeAction(IEnumerable<object> parameters)
    {
        int t = 
            0;
        foreach (object parameter in parameters) { }
        return false;
    }
}