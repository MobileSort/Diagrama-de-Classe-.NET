using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public interface IOrganize
{
    LocalDirectory TargetDirectory { get; set; }

    List<Tag>? Tags { get; set; }

    List<string>? FileNames { get; set; }

    List<string>? Extensions { get; set; }
}