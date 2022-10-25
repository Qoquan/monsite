using System.Reflection;
using System.Runtime.InteropServices;
using Cabinet_Veto.Classes;
namespace Cabinet_Veto.Classes;

abstract public class Animaux
{

    public string? Nom { get; set; }
    public DateOnly datedenassance { get; set; }
    public float Poid { get; set; }
    public float Taille { get; set; }
    public string Sexe { get; set; }
    public string couleur { get; set; }
    public bool Vaccine { get; set; } = false;
    public bool sterililsé { get; set; } = false;
    public bool EstPuce { get; set; } = false;
    public bool EstTatoué { get; set; } = false;
    int dureeVie;
    public bool Euthanasié { get; set; } = false;

    public Dictionary<string, double> soinsdoné = new Dictionary<string, double>();

    public string numeropuce { get; set; }

    public string numeroVaccin { get; set; }
    public virtual void Crie()
    {
          Console.WriteLine($"{this.Nom}");
    }


}

public class chien : Animaux
{
    public string Race { get; set; }
    public int dureeVie { get; set; } = 13;

    public override void Crie()
    {
        Console.WriteLine($"{this.Nom} fait WouffWouff");
    }
    
}

public class Chat : Animaux
{
public string longGriffe;
    public bool EstPuce { get; set; }
    public  bool EstTatoué { get; set; }
    public int dureeVie { get; set; } = 18;


    public override  void Crie()
    {
        Console.WriteLine($"{this.Nom} fait Miauwww");
    }
}
  public class Oiseau : Animaux
{
    public string raceoiseau;
    public int dureeVie { get; set; } = 50;

    public override  void Crie()
    {
        Console.WriteLine($"{this.Nom}  fait Pioupiou");
    }   
    
}

public class Rongeur : Animaux
{
    public string? raceRonguer;
    public int dureeVie { get; set; } = 10;

    public override void Crie()
    {
        Console.WriteLine($"{this.Nom}  fait snifsniff");
    }
}

public class reptile : Animaux
{
    public string? sorteReptile;
    public int dureeVie { get; set; } = 15;

    public override void Crie()
    {
        Console.WriteLine($"{this.Nom} fait GEERRRRR");
    }
}
public class autre : Animaux
{
    public string raceAutre;
    public int dureeVie { get; set; } = 15;

    public override void Crie()
    {
        Console.WriteLine($"{this.Nom} fait GEERRRRR");
    }
}
