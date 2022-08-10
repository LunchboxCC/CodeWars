// See https://aka.ms/new-console-template for more information
using CodeWars.Level;

Console.WriteLine(CountTriples("oohhpppppklllra"));
Console.WriteLine(ZipStrings("ahoj", "helloway"));
Console.WriteLine(ZipStrings("knightly", "nix"));
Console.WriteLine(ZipStrings("same", "face"));

static int CountTriples(string s)
{
    int triples = 0;

    for (int i = 2; i < s.Length; i++)
    {
        if (s[i - 2] == s[i - 1] && s[i - 1] == s[i])
            triples++;
    }

    return triples;
}

static string ZipStrings(string s1, string s2)
{
    int n = s1.Length < s2.Length ? s1.Length : s2.Length;
    string result = "";

    for (int i = 0; i < n; i++) 
    {
        result += string.Concat(s1[i], s2[i]);
    }

    result += s1.Length > s2.Length ? s1.Substring(n) : s2.Substring(n);
    return result;
}

public partial class Program { }