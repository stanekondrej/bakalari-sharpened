namespace BaSHELLáři_csharp.DataHandling;
public class Token
{
    protected string token;
    protected int length;
}

public class AccessToken : Token
{
    public new int length = 2556;
    
}

public class RefreshToken : Token
{
    public new int length = 3459;
}