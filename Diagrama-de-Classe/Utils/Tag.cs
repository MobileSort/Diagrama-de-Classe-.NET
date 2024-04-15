using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.Classes;

public class Tag
    (
        string name,
        string color,
        LocalDirectory associatedDirectory
    )
{
    public LocalDirectory AssociatedDirectory
    {
        get => associatedDirectory;
        set => associatedDirectory = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public string Color
    {
        get { return color;}
        set { color = value;}
        
    }
    
}