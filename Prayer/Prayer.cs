using System.Security.Cryptography.X509Certificates;

namespace Prayer;

public class Prayer : AuditableRecord
{
    public string Title { get; set; } = "";

    public string? Subtitle { get; set; } 

    public string Body { get; set; } = "";

    public List<ScriptureReference> ScriptureReferences {get;set;} = new();

    public Author? Author {get; set;}

    public List<Tag> Tags {get; set;}= new();

    public Uri? ImageUrl {get; set;}

    public override string ToString()
    {

        string result = $"{Title}";
        
        if (Subtitle != null)
        {
            result += Environment.NewLine + Subtitle;
        }

        if (Author != null)
        {
            result += Environment.NewLine + $"by {Author}"; 
        }

        if(ScriptureReferences.Count > 0)
        {
            result += Environment.NewLine + string.Join(", ", ScriptureReferences);
        }
        if(Tags.Count > 0)
        {
            result += Environment.NewLine + $"Tags: {string.Join(", ", Tags)}";
        }     

        return result;
    }
}
