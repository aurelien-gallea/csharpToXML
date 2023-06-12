using System.IO;
using System.Xml.Serialization;
public class Donnees
{
    public string? Nom { get; set; }
    public string? Age { get; set; }
    
}

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("quel est votre prénom ? ");
        var name = Console.ReadLine();
        Console.Write("quel est votre âge ? ");
        var age = Console.ReadLine();
        Console.WriteLine($"Bonjour {name}, vous avez {age} ans !");

        // Création d'un objet avec les données à envoyer
        Donnees donnees = new Donnees
        {
            Nom = name,
            Age = age
        };

        // Création du sérialiseur XML
        XmlSerializer serializer = new XmlSerializer(typeof(Donnees));

        // Création d'un flux pour écrire dans le fichier XML
        using (StreamWriter writer = new StreamWriter(@"C:\Users\galle\OneDrive\Documents\formation web\csharp\csharpToXML\test\Donnees.xml"))
        {
            // Sérialisation des données dans le fichier XML
            serializer.Serialize(writer, donnees);
        }

        Console.WriteLine("Données envoyées avec succès vers le fichier XML.");
    }
}
