namespace Proyecto.Models;

public class Weapon(string nation, int year, double caliberMm, double weightKg)
{
    // Propiedades de la clase Weapon
    public string Nation { get; set; } = nation;
    public int Year { get; set; } = year;
    public double CaliberMm { get; set; } = caliberMm;
    public double WeightKg { get; set; } = weightKg;
    public bool InProduction { get; set; }
}