namespace Cabinet_Veto.Classes;

public class Proprio
{
    public string Nom { get; set; }
    public string Rue { get; set; }
    public int Numero { get; set; }
    public string ville { get; set; }
    public int CodePostal { get; set; }
    public DateOnly birthdate { get; set; }
    
    public List<Animaux> animauxPossedé = new List<Animaux>();
    
}
