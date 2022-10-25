using System.Security.AccessControl;
using System.Threading.Channels;

namespace Cabinet_Veto.Classes;

public class Cabinet
{
   public string Nom { get; set; } = "La plume Doréee";
   public int  Capacity { get; set; } = 5 ;
   public string Rue { get; set; } = "rue Jean Volders" ;
   public int Numero { get; set; } = 12 ;
   public string ville { get; set; } = "Braine l'Alleud";
   public int CodePostal { get; set; } = 1420 ;
   public static List<Proprio> proprios = new List<Proprio>();
 
   public double coutSterilMal = 50;
   public double coutSterilfemel = 75;
   public double coutFracture = 75;
   public double coutsSoins = 50;
   public double coutUrgence = 25;
   public double coutVaccin = 35;
   public double coutPucage = 50;
   public double coutTatouage = 75;
   public double coutEuthanasie = 100;
   public double coutLongueDuree ;
   public double totalfacture;

   public  void  sterilisationMale()
   {
      Console.WriteLine("l'animal est bien sterilisé");
   }

   public void  sterilisationFemele()
   {
      Console.WriteLine("l'animal est bien sterilisé");
   }

   public static string Vaccinination()
   {
      Random rnd = new Random();
      string numvaccin = rnd.Next(1000).ToString() +"-" +rnd.Next(1000).ToString()+"-"+ rnd.Next(1000).ToString();
      return numvaccin;
   }

   public void Fracture()
   {
      Console.WriteLine("la fracture de l'animal a bien été soignée");
   }

   public void soins()
   {
      Console.WriteLine("l'animal a bien été soignée");
   }

    public static string puce()
   {
      Random rnd = new Random();
      string numpuce = rnd.Next(1000).ToString() + "-" + rnd.Next(1000).ToString();
      return numpuce;

   }

   public void tatouage()
   {

      Console.WriteLine("l'animal a bien été tatoué");
   }

   public int longueDuree()
   {
      int nuite =10;
      Console.WriteLine("combien de nuit doit il rester? ");
      int duree = Int32.Parse(Console.ReadLine());
      Console.WriteLine("l'animal a bien été soignée");
      int coutLongueDuree = nuite * duree;
      return coutLongueDuree;
      return duree;
   }


   public double   Facturer(double cout1,double cout2,double cout3 )
   {
      double total = cout1 + cout2 ;
      Console.WriteLine($"Le montant facturé est de : {total} Euros");
      return total;
   }

}


