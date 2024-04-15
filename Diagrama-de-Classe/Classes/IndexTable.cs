using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.Classes;

public class IndexTable(
    Device device
)
{
    public Device Device
    {
        get { return device; }
        set { device = value; }
    }

    public LocalDirectory GetDirectory(string path)
    {
        LocalDirectory directory = new("","");

        switch (device.Type)
        {
            //TODO maybe change all this i dont think is needed
            case DeviceTypes.Pc:
                throw new System.NotImplementedException();
            case DeviceTypes.Phone:
                return ReadDirectory(path);
                break;
        }

        return directory;
    }

    public bool MoveFile(string filePath, string to)
    {
        if (!File.Exists(filePath))
        {
            return false;
        }

        if (File.Exists(to))	
            File.Delete(to);

        
        File.Move(filePath, to);

        if (File.Exists(filePath))
        {
            return false;
        }
        else
        {
            return true;
        }			
    }

    public bool RemoveFile(string file)
    {
        if (!File.Exists(file))
        {
            return false;
        }
        File.Delete(file);
        if (File.Exists(file))
        {
            return false;
        }
        else
        {
            return true;
        }	
    }
    private LocalDirectory ReadDirectory(string path)
    {
        string[] directories = Directory.GetDirectories(path);
        List<LocalDirectory> localDirectories = new();
        foreach (var directoryName in directories)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(directoryName);
            LocalDirectory dir = new(directoryName, dirinfo.Name);
            localDirectories.Add(dir);
        }
        string[] files = Directory.GetFiles(path);
        List<LocalFile> localFiles = [];
        foreach (var file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            LocalFile dir = new(fileInfo.FullName, fileInfo.Name, fileInfo.Extension);
            localFiles.Add(dir);
        }
        
        string name = path.Split("/")[^1];
        LocalDirectory directory = new(path, name, localDirectories, localFiles);

        return directory;
    }
}