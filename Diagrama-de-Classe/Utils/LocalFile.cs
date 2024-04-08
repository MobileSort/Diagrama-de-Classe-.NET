using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class LocalFile(
    string path,
    string name,
    string extention,
    List<Tag>? tags = null
)
{
    public string Path
    {
        get {return path;}
        set {path = value;}
    }

    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public string Extention
    {
        get {return extention;}
        set {extention = value;}
    }

    public List<Tag>? Tags
    {
        get {return tags;}
        set {tags = value;}
    }
}