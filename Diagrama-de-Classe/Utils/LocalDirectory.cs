using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class LocalDirectory(string path, string name, List<LocalDirectory>? childDirectories = null, List<LocalFile>? childFiles = null)
{
    public string Path
    {
        get => path;
        set => path = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public List<LocalDirectory>? ChildDirectories
    {
        get => childDirectories;
        set => childDirectories = value;
    }

    public List<LocalFile>? ChildFiles
    {
        get => childFiles;
        set => childFiles = value;
    }
}