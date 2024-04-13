using System;
using System.IO;
using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class FileSorterTest
{
    public void TestOrganize()
    {
        FileSorter test = new(new Device(1,DeviceTypes.Phone));
        string path = Environment.CurrentDirectory + "/../../../DataSource/Phone1/Storage/";
        string[] files = [path+"NewDirectory1/NewFile1.txt", path+"NewDirectory1/file2.txt"];

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
        
        //MoveFiles
        // string to = path + "NewDirectory1/";
        //
        // List<bool> results = test.MoveFilesToDirectory(files,to);
        //     
        // foreach (var result in results)
        // {
        //     Console.WriteLine(result);
        
        //DeleteFiles
        // List<bool> results = test.RemoveFiles(files);
        // foreach (var result in results)
        // {
        //     Console.WriteLine(result);
        // }
    }
}