namespace BaSHELLáři_csharp.WebInteract;

public class Connection
{
    private static readonly HttpClient Client = new HttpClient();
    
    // This might be a bad practice, but I will keep it this way, FOR NOW. Plus, Microsoft
    // have stated that we shouldn't use SecureStrings for new code. tl;dr: im too lazy to think right now
    public string username;
    public string password;
    public string url;
    
    public static Dictionary<string, string> MakeConnection()
    {
        
        var response = new Dictionary<string, string>();
        return response;
    }
}