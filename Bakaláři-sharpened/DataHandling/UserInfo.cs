namespace Bakaláři_sharpened.DataHandling;

public class UserInfo
{
    private static string? username;
    private static string? password;
    private static string? url;

    public void GetInfo(string? param)
    {
        Console.WriteLine("Napište své uživatelské jméno: ");
        username = Console.ReadLine();
            
        Console.WriteLine("Napište své heslo: ");
        password = Console.ReadLine();
            
        Console.WriteLine("Napište adresu své školy, například \"ceskolipska.cz\" (Pokud je vstupní bod webové aplikace Bakalářů" +
                          " odlišný od formátu \"bakalari.skola.cz,\" nechte pole prázdné): ");
        url = Console.ReadLine();

        if (url == "")
        {
            Console.WriteLine("Vložte kompletní adresu vstupního bodu webové aplikace Bakalářů vaší školy" +
                              " (Například \"bakalari.school.cz\"): ");
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