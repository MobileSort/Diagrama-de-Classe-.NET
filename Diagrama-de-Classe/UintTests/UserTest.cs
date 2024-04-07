using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class UserTest
{
    public void Test()
    {
        List<Tag> ListTag = [new Tag("Fotos", "#4287f5"), new Tag("Videos", "#f54242"), new Tag("Documentos", "#45f542")];
        
        List<Ordering> ListOrd = [new Ordering(ListTag,[],"OrdTest")];
        
        User user0 = new(1, ListTag, ListOrd
            // , ["3","Tag"]
            
        );
        
        Console.WriteLine($"IDUser: {user0.Id}");

        foreach (var ord in user0.Ord)
        {
            Console.WriteLine($"NameExt: {ord.Name}");
            
            foreach (var tag in ord.Tags)
            {
                Console.WriteLine($"NameTag: {tag.Name}, ColorTag: {tag.Color}");
         
            }
            
        }
        

        // foreach (var Favorites in user0.Fav)
        // {
        //  Console.Write($"{Favorites}");
        //  
        // }
        
    }
    
}

