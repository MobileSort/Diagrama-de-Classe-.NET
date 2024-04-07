using Diagrama_de_Classe.Classes;

namespace Diagrama_de_Classe.UintTests;

public class UserTest
{
    public void Test()
    {
        List<Tag> LT = [new Tag("Fotos", "#4287f5"), new Tag("Videos", "#f54242"), new Tag("Documentos", "#45f542")];
        User user0 = new(1, LT
            // , ["3","Tag"]
            );
        Console.WriteLine($"IDUser: {user0.Id}");
        foreach (var tag in user0.Tags)
        {
            Console.WriteLine($"NameTag: {tag.Name}, ColorTag: {tag.Color}");
         
        }    
        // foreach (var Favorites in user0.Fav)
        // {
        //  Console.Write($"{Favorites}");
        //  
        // }
        
    }
    
}

