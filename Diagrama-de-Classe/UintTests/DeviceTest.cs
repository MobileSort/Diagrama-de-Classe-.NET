using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class DeviceTest
{
    public void Start()
    {
        Device d1 = new(1, DeviceTypes.Phone);
        Console.WriteLine("{0}", d1.Id);
    }
}