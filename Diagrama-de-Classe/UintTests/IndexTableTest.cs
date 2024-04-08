using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class IndexTableTest
{
    public void Start()
    {
        Device dev1 = new(1, DeviceTypes.Phone);
        IndexTable table = new(dev1);
        string path = Environment.CurrentDirectory + "/../../../DataSource/Phone1/Storage/";
        
        //READ
        //TODO put path on other place
        // List<LocalDirectory> directories = table.GetDirectory(path);
        // foreach (var directory in directories)
        // {
        //     Console.WriteLine(directory.Name);
        // }
        
        //Move
        // string file = path+"NewDirectory1/file.txt";
        // string to = path + "NewDirectory2/file.txt";
        // bool success = table.MoveFile(file, to);
        // Console.WriteLine(success);
        
        //Deletefile
        // string file = path+"NewDirectory2/file.txt";
        // bool successDelete = table.RemoveFile(file);
        // Console.WriteLine(successDelete);
    }
}