namespace BaSHELLáři_csharp.DataHandling;

public class UserInfo
{
    private static string? username;
    private static string? password;
    private static string? url;

    public void GetInfo(string? param)
    {
        Console.WriteLine("Input your username: ");
        username = Console.ReadLine();
            
        Console.WriteLine("Input your Password: ");
        password = Console.ReadLine();
            
        Console.WriteLine("Input the school URL, for example \"ceskolipska.cz\" (If the Bakaláři web app entry point is different than " +
                          "\"bakalari.school.cz,\" leave blank): ");
        url = Console.ReadLine();

        if (url == "")
        {
            Console.WriteLine("Input the full URL of the Bakaláři web app (For example \"bakalari.school.cz\"): ");
            url = Console.ReadLine();
        }
    }

    public Dictionary<string, string> ReturnInfo(string[] spec)
    {
        Dictionary<string, string> userdata = new Dictionary<string, string>();
        if (spec.Contains("username"))
        {
            userdata.Add("username", username);
        }

        if (spec.Contains("password"))
        {
            userdata.Add("password", password);
        }
            
        if (spec.Contains("url"))
        {
            userdata.Add("url", url);
        }

        return userdata;
    }
}