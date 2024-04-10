using System;
using System.IO;
using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class FileSorterTest
{
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

        FileSorter test = new(new Device(1,DeviceTypes.Phone));
        string path = Environment.CurrentDirectory + "/../../../DataSource/Phone1/Storage/";
        
        string file = path+"NewDirectory1/file.txt";
        string to = path + "NewDirectory2/file.txt";
        
        bool result = test.MoveFiles(file,to);
        
        Console.WriteLine(result);

    }
}