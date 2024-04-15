using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.Utils;

public class Ordering(
    LocalDirectory targetDirectory,
    List<Tag>? tags,
    List<string>? fileNames,
    List<string>? extensions)
    : IOrganize
{
    public LocalDirectory TargetDirectory { get; set; } = targetDirectory;
    public List<Tag>? Tags { get; set; } = tags;
    public List<string>? FileNames { get; set; } = fileNames;
    public List<string>? Extensions { get; set; } = extensions;
}