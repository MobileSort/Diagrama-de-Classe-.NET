using System.Runtime.InteropServices.JavaScript;
using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class Ordering
    (
        List<Tag> tags, //puxa arquivo Tag.cs
        string name
        //add parametro diretorio Caua
            
    )
{

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

