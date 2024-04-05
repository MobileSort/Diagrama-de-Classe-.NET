using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.UintTests;

public class DeviceTest
{
    public void Start()
    {
        Device dev = new()
        {
            id = 1,
        };
        Console.WriteLine(dev.id);
    }
}