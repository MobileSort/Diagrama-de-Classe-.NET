using System.Diagnostics;
using System.Runtime.CompilerServices;
using Diagrama_de_Classe.Utils;

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

    public LocalDirectory GetDirectory(string path)
    {
        return table.GetDirectory(path);
    }
    
    /// <param name="filesToMove">Array with the full path of the files you wish to move.</param>
    /// <param name="destination">The directory witch the files will move to.</param>
    public List<bool> MoveFilesToDirectory(List<LocalFile> filesToMove, LocalDirectory destination)
    {
        List<bool> results = [];
        foreach (var file in filesToMove)
        {
            var filePath = file.Path; 
            var filePathSplit = filePath.Split("/");
            var filePathTo = destination.Path + filePathSplit[^1];
            results.Add(table.MoveFile(filePath,filePathTo));
        }
        return results;
    }

    public List<bool> RemoveFiles(List<LocalFile> filesToRemove)
    {
        List<bool> results = [];
        foreach (var file in filesToRemove)
        {
            results.Add(table.RemoveFile(file.Path));
        }
        return results; 
    }

    public bool OrganizeFiles(Ordering ordering, LocalDirectory targetDirectory)
    {
        if (ordering.Tags == null && ordering.Extensions == null && ordering.FileNames == null)
        {
            return false;
        }
        SearchFiles search = new(targetDirectory ,ordering.Tags, ordering.FileNames, ordering.Extensions);
        List<LocalFile> filesToMove = SearchFilesInDirectory(search);
        if (filesToMove.Count == 0)
        {
            return true;
        }
        List<bool> results = MoveFilesToDirectory(filesToMove, ordering.TargetDirectory);
        return results.All((result) => result);
    }

    public List<LocalFile> SearchFilesInDirectory(SearchFiles search)
    {
        if (VerifyEmptyDirectory(search.TargetDirectory))
        {
            return [];
        }

        var files = search.TargetDirectory.ChildFiles; 
        if (search.Extensions != null)
        {
            files = (List<LocalFile>?)files!.Where(file => search.Extensions.Contains(file.Extention)).ToList();
        }
        if (search.FileNames != null)
        {
            files = (List<LocalFile>?)files!.Where(file => search.FileNames.Any((fileNameParam) =>
            {
                return file.Name.Contains(fileNameParam);
            })).ToList();
        }
        //TODO tags
        return files!;
    }

    private bool VerifyEmptyDirectory(LocalDirectory directory)
    {
        if (directory.ChildDirectories?.Count > 0 || directory.ChildFiles?.Count > 0)
        {
            return false;
        }

        directory = table.GetDirectory(directory.Path);
        if (directory.ChildDirectories?.Count == 0 && directory.ChildFiles?.Count == 0)
        {
            return true;
        }
        return true;
    }
}

