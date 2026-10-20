namespace Proyecto.Models;

public record FelidaeGenerics
{
    // Propiedades comunes de la clase Felidae
    public string Kingdom { get; set; } = "Animalia";
    public string Phylum { get; set; } = "Chordata";
    public string ClassCat { get; set; } = "Mammalia";
    public string Order { get; set; } = "Carnivora";
    public string SuperFamily { get; set; } = "Felidae";
}
public class Felidae(int poblation, string habitat, string allies)
{
    // Propiedades de la clase Felidae
    public int Id { get; set; } // Primary Key
    public int Poblation { get; set; } = poblation;
    public string Habitat { get; set; } = habitat;
    public string Allies { get; set; } = allies;

    // Relaciones con otras entidades
    public List<Weapon> Weapon { get; set; } = []; // Foreign Key con clase Weapon

    // Propiedades de enumeración
    public FelidaeFamilyType FelidaeFamilyType { get; set; }
    public FelidaeBehaviorType FelidaeBehaviorType { get; set; }
}