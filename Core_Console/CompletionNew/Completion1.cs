using System.Runtime.InteropServices;

namespace Core_Console.CompletionNew;

public class Completion1<T>: CompletionBase<T>
{
    public void Test()
    {
        int aaa = 0, bbb = 0, ccc = 0;
        var x = (aaa, bbb, ccc);
    }

    public void Test2()
    {
        var x = new Account()
        {
            
        }
    }
}

public class CompletionBase<T>
{
    public void Foo(string id)
    {
        if (id.StartsWith("x"))
        {
            Console.WriteLine("ID starts with 'x'");
            
        }
        else
        {
            Console.WriteLine("ID does not start with 'x'");
        }
    }
}