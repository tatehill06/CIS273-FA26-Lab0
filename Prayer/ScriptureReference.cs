using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace Prayer;

public class ScriptureReference
{
    public string Book {get;set;} = "";

    public int Chapter { get; set; }

    public int StartVerse { get; set; }

    public int EndVerse { get; set; }

    public override string ToString()
    {
        //if StartVerse == EndVerse;
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
    
}
