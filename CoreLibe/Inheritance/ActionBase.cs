namespace CoreLibe.Inheritance;

public class ActionBase : IActionBase
{
    public virtual bool InvokeAction(IEnumerable<object> parameters)
    {
        // These is not correct here
        // typpo with multilpe typos
        int t = 
            0;
        foreach (object parameter in parameters) { }
        return false;
    }
}