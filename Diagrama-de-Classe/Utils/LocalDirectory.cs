using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class LocalDirectory(string path, string name, List<Tag>? tags = null)
{
    public string Path
    {
        get { return path; }
        set { path = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Tag> Tags
    {
        get { return tags; }
        set { tags = value; }
    }
}