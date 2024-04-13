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
    

    //TODO maybe change the parameters to use LocalDirectory
    /// <param name="filesToMovePath">Array with the full path of the files you wish to move.</param>
    /// <param name="destination">The directory witch the files will move to.</param>
    public List<bool> MoveFilesToDirectory(string[] filesToMovePath, string destination)
    {
        List<bool> results = [];
        foreach (var filePath in filesToMovePath)
        {
            string[] filePathSplit = filePath.Split("/");
            string filePathTo = destination + filePathSplit[^1];
            results.Add(table.MoveFile(filePath,filePathTo));
        }
        return results;
    }

    public List<bool> RemoveFiles(string[] filesToRemovePath)
    {
        List<bool> results = [];
        foreach (var filePath in filesToRemovePath)
        {
            results.Add(table.RemoveFile(filePath));
        }
        return results; 
    }

    public void OrganizeFiles()
    {
        //TODO use Organize class
    }

    public void SearchFiles(string searchTerm)
    {
        //TODO Use Search class
        
    }
}

