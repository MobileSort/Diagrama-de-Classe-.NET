using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Diagrama_de_Classe.Classes;

public class FileSorter

{

    private IndexTable table;
    private Device connectedDevice;
    
    public FileSorter(Device deviceToConnect)
    {
        table = new IndexTable(ConnectedDevice);
        connectedDevice = deviceToConnect;
    }
    
    public Device ConnectedDevice
    {
        get { return connectedDevice; }
        set { connectedDevice = value; }
    }
    

    public bool MoveFiles(string filepath, string to)
    {
        IndexTable table = new(connectedDevice);
        return table.MoveFile(filepath,to);
    }

    public void RemoveFiles(string[] filesToRemove)
    {
        
        
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

