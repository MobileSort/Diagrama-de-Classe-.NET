using System.Numerics;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.Classes;

public class User
    (
        int id,
        List<Tag> tags,
        List<Ordering> orderings = null,
        List<SearchFiles> searches = null
        // TODO 
        // add orderings
        // add Last Searches
        // add Favorite Directories
    )
{
    public List<SearchFiles> Searches
    {
        get => searches;
        set => searches = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Ordering> Orderings
    {
        get => orderings;
        set => orderings = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public List<Tag> Tags
    {
        get => tags;
        set => tags = value;
    }

    // public List<string> Fav
    // {
    //     get { return fav;}
    //     set { fav = value;}
    //     
    // }
    
}

