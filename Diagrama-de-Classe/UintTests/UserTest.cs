using Diagrama_de_Classe.Classes;
using Diagrama_de_Classe.Utils;

namespace Diagrama_de_Classe.UintTests;

public class UserTest
{
    public void Test()
    {
        
        Console.WriteLine("Insert you Name User");
        string UserName = Console.ReadLine();
        Console.Clear();
        List<Tag> ListTag = [new Tag("", "")];
        List<Ordering> ListOrd = [new Ordering(name: "", tags: [])];
        User idUser = new(1, UserName, ListTag, ListOrd);
        Console.WriteLine($"IDName: {idUser.Id}, {idUser.Name}" );

        int AddOrd = 1;
        while (true)
        {
            
            Console.WriteLine("Desaja continuar");
            AddOrd =int.Parse(Console.ReadLine());
            if (AddOrd != 1)
            {
                break;
            }
            
            Console.WriteLine("NameOrd:");
            string NameOrd = Console.ReadLine();
            Console.Clear();
            
            int Addtag = 1;
            List<Tag> tags = new();
            while (true)
            {
                Console.WriteLine("Desaja continuar");
                Addtag =int.Parse(Console.ReadLine());
                if (Addtag != 1)
                {
                    break;
                }
                Console.WriteLine("NameTag:");
                string NameTag = Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine(NameTag);
                Console.WriteLine("NameExt:");
                string NameExt = Console.ReadLine();
                Console.WriteLine(NameExt);
                Console.Clear();
                
                tags.Add(new Tag(NameTag,NameExt));
            }

            idUser.Ord.Add(new Ordering(name: NameOrd, tags:[]));

        }

        foreach (var ord in idUser.Ord) //TODO Nada depois dessa linha está funfando
        {
            
            foreach (var tag in ord.Tags)
            {
                Console.WriteLine(ord.Name);
                Console.WriteLine(tag.Name);
                Console.WriteLine(tag.Ext);
            }
            
        }
        
        //Console.WriteLine($"NameTag: {tag.Name}, ColorTag: {tag.Ext}");

        // foreach (var Favorites in user0.Fav)
        // {
        //  Console.Write($"{Favorites}");
        //  
        // }
        
    }
    
}

