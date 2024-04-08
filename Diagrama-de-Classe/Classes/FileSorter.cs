using System.Diagnostics;

namespace Diagrama_de_Classe.Classes;

public class FileSorter
    (
        Device connectedDevice
    )
{
    
    public Device ConnectedDevice
    {
        get { return connectedDevice; }
        set { connectedDevice = value; }
    }

    private static string filepath = @"C:\Projects\mobile_sort_\Diagrama-de-Classe\DataSource\Phone1\Midia\meuarquivo.txt";
    
    
    public void AddFiles(string[] filesToAdd)
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado
        bool resultAdd = true;
        
        if (resultAdd)
        {
            Console.WriteLine("Sucesso ao adicionar o arquivo no diretório.");
        }
        else
        {
            Console.WriteLine("Erro ao adicionar o aruqivo ao diretório");
        }
        
    }

    public void RemoveFiles(string[] filesToRemove)
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado
        bool resultAdd = true;

        if (resultAdd)
        {
            Console.WriteLine("Sucesso ao deletar o arquivo no diretório.");
        }
        else
        {
            Console.WriteLine("Erro ao deletar o aruqivo ao diretório");
        }
        
        File.Delete(filepath);
    }

    public void OrganizeFiles()
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado

    }

    public void SearchFiles(string searchTerm)
    {
        //TODO Chamar a tabela de indexação para chamar esse resultado
        
        
    }
    
    
}