namespace CoreLibe;

public class SystemInfoPrinter
{
    public void PrintInfo()
    {
        Console.WriteLine("Operating System: " + Environment.OSVersion);
        Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
        Console.WriteLine("System Directory: " + Environment.SystemDirectory);
        Console.WriteLine("User Domain Name: " + Environment.UserDomainName);
        Console.WriteLine("User Name: " + Environment.UserName);
        Console.WriteLine("Machine Name: " + Environment.MachineName);
        Console.WriteLine("CommandLine: " + Environment.CommandLine);
    }
}