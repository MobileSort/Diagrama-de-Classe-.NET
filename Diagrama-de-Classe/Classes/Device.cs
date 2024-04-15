using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.Classes;

public class Device(
    int id,
    DeviceTypes type
)
{
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public DeviceTypes Type
    {
        get { return type; }
        set { type = value; }
    }
}