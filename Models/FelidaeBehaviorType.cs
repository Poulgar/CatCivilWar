using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models;

public enum FelidaeBehaviorType 
{
    // Tipos de comportamiento de felinos
    [Display(Name = "Capacidad de vuelo desarrollada")]
    CanFly, 
    [Display(Name = "Capacidad de escalado vertical desarrollada")]
    CanIgnoreVerticalObstacles,
    [Display(Name = "Capacidad de hablar taka taka desarrollada")]
    CanSpeakChinese,
    [Display(Name = "Capacidad de regenerar extremidades perdidas desarrollada")]
    CanRegenerate,
    [Display(Name = "Ninguna capacidad desarrollada")]
    NoCan
}