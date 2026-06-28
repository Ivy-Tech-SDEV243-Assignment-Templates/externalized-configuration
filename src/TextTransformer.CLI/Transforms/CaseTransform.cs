using System.Globalization;

public class CaseTransform
{
    private readonly CaseOption _option;

    public CaseTransform(CaseOption option)
    {
        _option = option;
    }

    public string Transform(string input)
    {
        return _option switch
        {
            CaseOption.None => input,
            CaseOption.Lower => input.ToLower(),
            CaseOption.Upper => input.ToUpper(),
            CaseOption.Title => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input),
            _ => throw new ArgumentException("Invalid case option."),
        };
    }
}