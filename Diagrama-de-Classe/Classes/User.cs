using System.Numerics;

namespace Diagrama_de_Classe.Classes;

public class User
    (
        int id,
        List<Tag> tags
        // List<string> fav   
        
    )
{
    public int Id
    {
        get { return id;}
        set { id = value;}
        
    }

    public List<Tag> Tags
    {
        get { return tags;}
        set { tags = value;}
        
    }

    // public List<string> Fav
    // {
    //     get { return fav;}
    //     set { fav = value;}
    //     
    // }
    
}

