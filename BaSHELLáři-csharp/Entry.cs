namespace BaSHELLáři_csharp;

using DataHandling;

public class Entry
{
    public static int Main()
    {
        var userdata = new UserInfo();
        userdata.GetInfo("");
        
        Console.WriteLine();
        Console.WriteLine(userdata.ReturnInfo);
        return 0;
    }
}