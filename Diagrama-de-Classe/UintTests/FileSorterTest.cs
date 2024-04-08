using System;
using System.IO;

namespace Diagrama_de_Classe.UintTests;

public class FileSorterTest
{
    public void TestOrganize()
    {
        
        Console.WriteLine("Choose the action you want to do:");
        Console.WriteLine("");
        Console.WriteLine("1: Move Files");
        Console.WriteLine("2: Remove Files");
        Console.WriteLine("3: Organize Files");
        Console.WriteLine("4: Search Files");
        int op = Console.Read();
        Console.WriteLine("Chosen " + op + "option");

        switch (op)
        {
            case 1: 
                Console.WriteLine();
                break;    
            case 2: break;
        }
    }
}