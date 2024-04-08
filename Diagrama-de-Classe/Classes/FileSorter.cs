using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Diagrama_de_Classe.Classes;

public class FileSorter
    (
        Device connectedDevice
    )
{
    
    public Device ConnectedDevice
    {
        get { return connectedDevice; }
        set { connectedDevice = value; }
    }
    
    public IndexTable MoveFiles(string filepath, string to)
    {
        return MoveFiles("","");
    }

    public void RemoveFiles(string[] filesToRemove)
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado
        
    }

    public void OrganizeFiles()
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado

    }

    public void SearchFiles(string searchTerm)
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado
        
    }
}

