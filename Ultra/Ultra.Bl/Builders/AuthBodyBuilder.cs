namespace Ultra.Bl.Builders;

public class AuthBodyBuilder
{
    private const string Code = "Code";

    private readonly IDictionary<string, object> data = new Dictionary<string, object>();

    private AuthBodyBuilder()
    {
    }

    public static AuthBodyBuilder Create()
        => new AuthBodyBuilder();

    public AuthBodyBuilder WithCode(string code)
    {
        data[Code] = code;
        return this;
    }

    public IDictionary<string, object> Build()
        => data;
}
