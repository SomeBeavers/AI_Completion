namespace CoreLibe.Inheritance;

class DeleteAction : ActionBase
{
    public static int min = 0;
    public static int max = 100;

    public int Min { get; set; }

    public DeleteAction(int min
    
    , int max
    
    )
    {
        Min = min;
    }


    public override bool InvokeAction(IEnumerable<object> parameters)
    {
        
        // Add custom implementation here
        return base.InvokeAction(parameters);
    }
}