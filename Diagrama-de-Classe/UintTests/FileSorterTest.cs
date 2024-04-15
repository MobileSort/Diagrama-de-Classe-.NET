using System;
using System.IO;
using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class FileSorterTest
{
    private static Device device1 = new(1, DeviceTypes.Phone);
    private static FileSorter test = new(device1);
    private static string path = Environment.CurrentDirectory + "/../../../DataSource/Phone1/Storage/";
    private static List<LocalFile> files =
    [
        new LocalFile(path + "NewDirectory2/NewFile1.txt", "NewFile1", "txt"),
        new LocalFile(path + "NewDirectory2/file2.txt", "file2", "txt")
    ];
    public void TestOrganize()
    {

        // Console.WriteLine("Choose the action you want to do:");
        // Console.WriteLine("");
        // Console.WriteLine("1: Move Files");
        // Console.WriteLine("2: Remove Files");
        // Console.WriteLine("3: Organize Files");
        // Console.WriteLine("4: Search Files");
        // int op = Console.Read();
        // Console.WriteLine("Chosen " + op + "option");
        //
        // switch (op)
        // {
        //     case 1: 
        //         Console.WriteLine();
        //         break;    
        //     case 2: break;
        // }

        Organize();
        
    }

    private void MoveFiles()
    {
        LocalDirectory to = new(path + "NewDirectory1/", "NewDirectory1");
        
        List<bool> results = test.MoveFilesToDirectory(files, to);
        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }        
    }
    private void DeleteFiles()
    {
        List<bool> results = test.RemoveFiles(files);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
    private void GetDirectory()
    {
        LocalDirectory directory = new IndexTable(device1).GetDirectory(path+"NewDirectory1");
        Console.WriteLine("Directories");
        foreach (var dir in directory.ChildDirectories)
        {
            Console.WriteLine(dir.Name);
        }
        Console.WriteLine("Files");
        foreach (var dir in directory.ChildFiles)
        {
            Console.WriteLine(dir.Name);
        }
    }

    private void Organize()
    {
        LocalDirectory directory = new IndexTable(device1).GetDirectory(path+"NewDirectory1");
        LocalDirectory directoryToPut = new IndexTable(device1).GetDirectory(path+"NewDirectory2");
        Ordering order = new(directoryToPut, [], ["NewFile"], [".txt"]);
        bool result = test.OrganizeFiles(order,directory);
        Console.WriteLine(result);
    }
}