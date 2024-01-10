using System;



namespace ConsoleApp44;
using System;

namespace ConsoleApp44
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Identified1ByAttribute : Attribute
    {
        public class Class
        {
            public object Property { get; }

            public Class(object? parameter)
            {
                Property = parameter is { } p ? p : new object();
            }
        }
    }
}

public class Identified1ByAttribute : Attribute
{
    public class Class(object? parameter)
    {
        public object Property { get; } = parameter is { } p ? p : new object();
    }

}