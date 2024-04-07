using System.Runtime.InteropServices.JavaScript;
using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class Ordering
    (
        List<Tag> tags, //puxa arquivo Tag.cs
        List<string> ext,
        string name
        //add parametro diretorio Caua
            
    )
{
    public List<string> Ext
    {
        get { return ext; }
        set { ext = value; }

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

