using System.Diagnostics;

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
    
    public void MoveFiles(string filepath, string to)
    {
        foreach (var movefile in IndexTable.MoveFile)
        {
            Console.WriteLine(MoveFiles());
        }
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