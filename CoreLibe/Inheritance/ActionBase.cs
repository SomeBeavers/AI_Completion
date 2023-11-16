namespace CoreLibe.Inheritance;

public class ActionBase : IActionBase
{
    public virtual bool InvokeAction(IEnumerable<object> parameters)
    {
        return false;
    }
}

class DeleteAction : ActionBase
{
    public override bool InvokeAction(IEnumerable<object> parameters)
    {
        // Add custom implementation here
        return base.InvokeAction(parameters);
    }
}