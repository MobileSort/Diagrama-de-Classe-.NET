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

    public List<LocalDirectory> GetDirectory(string path)
    {
        List<LocalDirectory> directories = [];

        switch (device.Type)
        {
            //TODO maybe change all this i dont think is needed
            case DeviceTypes.Pc:
                throw new System.NotImplementedException();
            case DeviceTypes.Phone:
                return ReadDirectory(path);
                break;
        }

        return directories;
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
    private List<LocalDirectory> ReadDirectory(string path)
    {
        List<LocalDirectory> localDirectories = new();
        string[] directories = Directory.GetDirectories(path);
        foreach (var directory in directories)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(directory);
            LocalDirectory dir = new(directory, dirinfo.Name, new List<Tag>());
            localDirectories.Add(dir);
        }

        return localDirectories;
    }
}