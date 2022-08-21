namespace Bakaláři_sharpened;

using DataHandling;

public class Entry
{
    public static readonly string version = "pre-1.0";
    public static int Main()
    {
        Console.WriteLine("Vítejte v Bakaláři-sharpened. Používáte verzi " + version + "!");
        
        var userdata = new UserInfo(); 
        userdata.GetInfo("");
        
        Console.WriteLine();
        Console.WriteLine(userdata.ReturnInfo);
        return 0;
    }
}