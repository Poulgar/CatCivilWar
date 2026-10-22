namespace Proyecto.Models;

public class Weapon(int id, string nation, int year, double caliberMm, double weightKg)
{
    // Propiedades de la clase Weapon
    public int Id { get; set; } = id;
    public string Nation { get; set; } = nation;
    public int Year { get; set; } = year;
    public double CaliberMm { get; set; } = caliberMm;
    public double WeightKg { get; set; } = weightKg;
    public bool InProduction { get; set; }
}