using System.Numerics;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.Classes;

public class User
    (
        int id,
        string name,
        List<Tag> tags,
        List<Ordering> ord
        // List<string> fav   
        
    )
{
    public int Id
    {
        get { return id;}
        set { id = value;}
        
    }

    public string Name
    {
        get { return name;}
        set { name = value;}

    }
    
    public List<Tag> Tags
    {
        get { return tags;}
        set { tags = value;}
        
    }

    public List<Ordering> Ord
    {
        get { return ord; }
        set { ord = value; }
        
    }
    
    // public List<string> Fav
    // {
    //     get { return fav;}
    //     set { fav = value;}
    //     
    // }
    
}

