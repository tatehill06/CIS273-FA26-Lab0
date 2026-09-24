namespace Prayer;

public class Program
{
    static void Main(string[] args)
    {
        Prayer p = new Prayer();
        p.Title = "Title";
        p.ScriptureReferences.Add(new ScriptureReference() {Book="Matthew", 
        Chapter = 1, 
        StartVerse = 1, EndVerse = 3 });

        System.Console.WriteLine(p);
    }
}

