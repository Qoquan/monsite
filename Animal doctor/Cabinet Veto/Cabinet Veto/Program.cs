using System.ComponentModel.Design;
using System.Threading.Channels;
using Cabinet_Veto.Classes;
Proprio proprio1 = new Proprio();

Cabinet cabinet = new Cabinet();

int choix1;
int choixSoins;
string urgence;


    
Console.WriteLine($"Bonjour Bienvenue dans le Cabinet vététinaire '{cabinet.Nom}'");
Console.WriteLine("Etes-vous un nouveau client ?");
string newClient = Console.ReadLine();
if (newClient == "oui")// creer un nouveau client et demande ses caracteristique
{
    Console.Clear();

    Console.WriteLine("Quel est votre nom ");
    proprio1.Nom = Console.ReadLine();
    Cabinet.proprios.Add(proprio1);
    Console.WriteLine();
    Console.WriteLine("quel est votre date de naissance ? ");
    proprio1.birthdate = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("dans quel rue habiter vous ? ");
    proprio1.Rue = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("a quel numero ? ");
    proprio1.Numero = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("dans quelle ville ? ");
    proprio1.ville = (Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("quel est le cade postal ? ");
    proprio1.CodePostal = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
}
else if (newClient == "non")//si le client existe le recherche dans la liste du cabinet
{
    Console.WriteLine("Quel est votre nom? ");
    int pChoixproprio = choixproprio();
}

int premChoix;//premier possibliter de choix
do{
    Console.WriteLine("En quoi peut on vous aider ? ");
    Console.WriteLine("1 :Venez vous pour un rajouter un animal  ");
    Console.WriteLine("2 :Venez vous pour un un soins ");
    Console.WriteLine("3 :Voulez vous consulté la fiche d'un animal ");
    Console.WriteLine("4 :Changer vos coordonnées");
    Console.WriteLine("0 :Voulez-vous partir ");

    premChoix = Int32.Parse(Console.ReadLine());
    switch (premChoix)
     {
         case 1://permet de rajouter un animal selon son espece
             Console.Clear();
             Console.WriteLine("quel sorte d'animal avez vous");
             Console.WriteLine("1 : Chien");
             Console.WriteLine("2 : Chat");
             Console.WriteLine("3 : Oiseau");
             Console.WriteLine("4 : Rongeur");
             Console.WriteLine("5 : Reptile");
             Console.WriteLine("6 : Autre");

             choix1 = Int32.Parse(Console.ReadLine());
             switch (choix1)
             {
                 case 1:
                     //chien
                     Console.Clear();
                     
                     Console.WriteLine("Quel est le nom du chien");
                     chien newChien = new chien();
                     newChien.Nom = Console.ReadLine();
                     proprio1.animauxPossedé.Add(newChien);

                     Console.WriteLine("quel est sa date de naissance ? ");
                     newChien.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il ? ");
                     newChien.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newChien.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newChien.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est son pelage ? ");
                     newChien.couleur = (Console.ReadLine());

                     Console.WriteLine("De quel race est-il ");
                     newChien.Race = Console.ReadLine();

                     Console.Clear();
                     
                     newChien.Crie();

                     break;

                 case 2:
                     //Chat
                     Console.Clear();

                     Console.WriteLine("Quel est le nom du chat");
                     Chat newChat = new Chat();
                     newChat.Nom = Console.ReadLine();
                     proprio1.animauxPossedé.Add(newChat);

                     Console.WriteLine("quel est sa date de naissance ? ");
                     newChat.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il ? ");
                     newChat.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newChat.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newChat.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est son pelage ? ");
                     newChat.couleur = (Console.ReadLine());

                     Console.Clear();

                     newChat.Crie();

                     break;
                 case 3:
                     //oiseau
                     Console.Clear();

                     Console.WriteLine("Quel est le nom de l'oiseau");
                     Oiseau newOiseau = new Oiseau();
                     newOiseau.Nom = Console.ReadLine();
                     proprio1.animauxPossedé.Add(newOiseau);
                     Console.WriteLine("quel race s'agit-il ? ");
                     newOiseau.raceoiseau = (Console.ReadLine());
                     Console.WriteLine("quel est sa date de naissance ? ");
                     newOiseau.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il (en gramme) ? ");
                     newOiseau.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newOiseau.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newOiseau.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est ses plumes ? ");
                     newOiseau.couleur = (Console.ReadLine());

                     Console.Clear();

                     newOiseau.Crie();
                     
                     break;
                 
                 case 4:
                     Console.Clear();

                     Console.WriteLine("Quel est le nom du rongeur");
                     Rongeur newRongeur = new Rongeur
                     {
                         Nom = Console.ReadLine()
                     };
                     proprio1.animauxPossedé.Add(newRongeur);
                     Console.WriteLine("quel race s'agit-il ? ");
                     newRongeur.raceRonguer = (Console.ReadLine());
                     Console.WriteLine("quel est sa date de naissance ? ");
                     newRongeur.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il ? ");
                     newRongeur.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newRongeur.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newRongeur.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est son pelage ? ");
                     newRongeur.couleur = (Console.ReadLine());
                     
                     Console.Clear();

                     newRongeur.Crie();
                     break;
                 
                 case 5:
                     Console.Clear();

                     Console.WriteLine("Quel est le nom de l'animal");
                     reptile newReptile = new reptile
                     {
                         Nom = Console.ReadLine()
                     };
                     proprio1.animauxPossedé.Add(newReptile);
                     Console.WriteLine("quel race s'agit-il ? ");
                     newReptile.sorteReptile = (Console.ReadLine());
                     Console.WriteLine("quel est sa date de naissance  ? ");
                     newReptile.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il ? ");
                     newReptile.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newReptile.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newReptile.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est ses ecailles  ? ");
                     newReptile.couleur = (Console.ReadLine());
                     
                     Console.Clear();

                     newReptile.Crie();
                     break;
                 
                 case 6:
                     Console.Clear();

                     Console.WriteLine("Quel est le nom de l'animal");
                     autre newaAutre = new autre();
                     newaAutre.Nom = Console.ReadLine();
                     proprio1.animauxPossedé.Add(newaAutre);
                     Console.WriteLine("quel est sa date de naissance ? ");
                     newaAutre.raceAutre = (Console.ReadLine());
                     Console.WriteLine("quel age a t il ? ");
                     newaAutre.datedenassance = DateOnly.Parse(Console.ReadLine());
                     Console.WriteLine("combien pese t'il ? ");
                     newaAutre.Poid = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("combien mesure t'il ? ");
                     newaAutre.Taille = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("est-ce un mâle(M) ou une Femelle (F) ? ");
                     newaAutre.Sexe = (Console.ReadLine().ToUpper());
                     Console.WriteLine("De quel couleur est son pelage, ses plumes, ecailles  ? ");
                     newaAutre.couleur = (Console.ReadLine());
                     
                     Console.Clear();

                     newaAutre.Crie();
                     break;
                 default:
                     break;
             }

             break;
         
         case 2: // choisi un animal dans  la liste du proprietaire
             Console.Clear();

             EstMalade();
             
            Console.WriteLine("pour quel animal venez vous?  ");
             int AnimalChoice = choixanimal();
             if (proprio1.animauxPossedé[AnimalChoice].Euthanasié==true)//tient en compte le risque qu l'animal soi mort
             {
                 Console.WriteLine($"{proprio1.animauxPossedé[AnimalChoice].Nom} est mort paix a son ame ");
             }
             else
             {
                 Console.WriteLine("est- ce une urgence : O / N ");
                 urgence = Console.ReadLine().ToUpper();
                 Console.WriteLine("quel soins a t il besoin ?: ");
                 Console.WriteLine("1 : Stérilisation ");
                 Console.WriteLine("2 : Vaccin ");
                 Console.WriteLine("3 : Fracture  ");
                 Console.WriteLine("4 : soins ");
                 Console.WriteLine("5 : puce  ");
                 Console.WriteLine("6 : tatouage ");
                 Console.WriteLine("8 : Faire piquer ");     
                 
                 Console.Clear();

                 choixSoins = Int32.Parse(Console.ReadLine());
                 
                 
                 switch (choixSoins)
                 {
                     case 1:
                         if (proprio1.animauxPossedé[AnimalChoice].Sexe == "F")
                         {

                             if (urgence == "O")
                             {
                                 cabinet.sterilisationFemele();
                                 
                                 cabinet.Facturer(cabinet.coutSterilfemel, cabinet.coutUrgence,0);
                                 
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("sterilisation en urgence",
                                     cabinet.Facturer(cabinet.coutSterilfemel, cabinet.coutUrgence,0));

                             }
                             else
                             {
                                 cabinet.sterilisationFemele();
                                 
                                 cabinet.Facturer(cabinet.coutSterilfemel,0,0);
                                 
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("sterilisation ",
                                     cabinet.Facturer(cabinet.coutSterilfemel,0,0));
                             }
                         }
                         else if (proprio1.animauxPossedé[AnimalChoice].Sexe == "M")

                         {
                             if (urgence == "O")
                             {
                                 cabinet.sterilisationMale();
                                 cabinet.Facturer(cabinet.coutSterilMal, cabinet.coutUrgence,0);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("sterilisation en urgence",
                                     cabinet.Facturer(cabinet.coutSterilMal, cabinet.coutUrgence,0));

                             }
                             else
                             {
                                 cabinet.sterilisationMale();
                                 cabinet.Facturer(cabinet.coutSterilMal, 0,0);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("sterilisation ",
                                     cabinet.Facturer(cabinet.coutSterilMal, 0,0));

                             }
                         }

                         break;


                     case 2:

                         
                         proprio1.animauxPossedé[AnimalChoice].numeroVaccin=Cabinet.Vaccinination();
                         Console.WriteLine("l'animal est bien vacciné");
                         cabinet.Facturer(cabinet.coutVaccin, 0,0);
                         proprio1.animauxPossedé[AnimalChoice].Vaccine = true;
                         proprio1.animauxPossedé[AnimalChoice].soinsdoné
                             .Add("vaccination ", cabinet.Facturer(cabinet.coutVaccin, 0,0));

                         break;

                     case 3:
                         if (urgence == "O")
                         {
                             Console.WriteLine("l'animal doit il rester au cabinet : O / N?");
                             string rester = Console.ReadLine().ToUpper();
                             if (rester == "O")
                             {
                                 cabinet.longueDuree();
                                 cabinet.Fracture();
                                 cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,cabinet.coutLongueDuree);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("reduction de fracture en urgence ",
                                     cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,cabinet.coutLongueDuree));
                             }
                             else
                             {
                                 cabinet.Fracture();
                                 cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,0);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("reduction de fracture en urgence ",
                                     cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,0));
                             }
                             cabinet.Fracture();
                             cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,0);
                             proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("reduction de fracture en urgence ",
                                 cabinet.Facturer(cabinet.coutFracture, cabinet.coutUrgence,0));

                         }
                         else 
                         {
                             Console.WriteLine("l'animal doit il rester au cabinet : O / N?");
                             string rester = Console.ReadLine().ToUpper();
                             if (rester == "O")
                             {
                                 cabinet.longueDuree();
                                 cabinet.Fracture();
                                 cabinet.Facturer(cabinet.coutFracture, 0,cabinet.coutLongueDuree);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("reduction de fracture ",
                                     cabinet.Facturer(cabinet.coutFracture, 0,cabinet.coutLongueDuree));
                             }
                             else
                             {
                                 cabinet.Fracture();
                                 cabinet.Facturer(cabinet.coutFracture, 0,0);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("reduction de fracture ",
                                     cabinet.Facturer(cabinet.coutFracture, 0,0));
                             }
                             
                         }
                         

                         break;

                     case 4:
                         if (urgence == "oui")
                         {
                            Console.WriteLine("l'animal doit il rester au cabinet : O / N?");
                             string rester = Console.ReadLine().ToUpper();
                             if (rester == "O")
                             {
                                 cabinet.longueDuree();
                                 cabinet.soins();
                                 cabinet.Facturer(cabinet.coutsSoins, cabinet.coutUrgence,cabinet.coutLongueDuree);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("soins en urgence ", 
                                     cabinet.Facturer(cabinet.coutsSoins, cabinet.coutUrgence,cabinet.coutLongueDuree));
                             }
                             else
                             {
                                 cabinet.soins();
                                 cabinet.Facturer(cabinet.coutsSoins, cabinet.coutUrgence,0);
                                 proprio1.animauxPossedé[AnimalChoice].soinsdoné.Add("soins en urgence ",
                                     cabinet.Facturer(cabinet.coutsSoins, cabinet.coutUrgence,0));  
                             }
                             
                         }
                         else
                         {
                             if (urgence == "oui")
                             {
                                 Console.WriteLine("l'animal doit il rester au cabinet : O / N?");
                                 string rester = Console.ReadLine().ToUpper();
                                 if (rester == "O")
                                 {
                                     cabinet.longueDuree();
                                     cabinet.soins();
                                     cabinet.Facturer(cabinet.coutsSoins, 0, cabinet.coutLongueDuree);
                                     proprio1.animauxPossedé[AnimalChoice].soinsdoné
                                         .Add("soins ",
                                             cabinet.Facturer(cabinet.coutsSoins, 0, cabinet.coutLongueDuree));
                                 }
                                 else
                                 {
                                     cabinet.soins();
                                     cabinet.Facturer(cabinet.coutsSoins, 0, 0);
                                     proprio1.animauxPossedé[AnimalChoice].soinsdoné
                                         .Add("soins ", cabinet.Facturer(cabinet.coutsSoins, 0, 0));
                                 }

                             }
                         }

                         break;
                     case 5:
                         proprio1.animauxPossedé[AnimalChoice].numeropuce=Cabinet.puce();
                         cabinet.Facturer(cabinet.coutPucage, 0,0);
                         proprio1.animauxPossedé[AnimalChoice].EstPuce = true;
                         Console.WriteLine("l'animal a bien été pucé");
                         proprio1.animauxPossedé[AnimalChoice].soinsdoné
                             .Add("puçage ", cabinet.Facturer(cabinet.coutPucage, 0,0));


                         break;

                     case 6:
                         cabinet.tatouage();
                         cabinet.Facturer(cabinet.coutTatouage, 0,0);
                         proprio1.animauxPossedé[AnimalChoice].EstTatoué = true;
                         proprio1.animauxPossedé[AnimalChoice].soinsdoné
                             .Add("tatouage ", cabinet.Facturer(cabinet.coutTatouage, 0,0));

                         break;

                      case 8:
                         Console.WriteLine(
                             $"les soufrances de {proprio1.animauxPossedé[AnimalChoice].Nom} ont été abregée ");
                         cabinet.Facturer(cabinet.coutEuthanasie, 0,0);
                         proprio1.animauxPossedé[AnimalChoice].soinsdoné
                             .Add("euthanasie ", cabinet.Facturer(cabinet.coutEuthanasie, 0,0));
                         proprio1.animauxPossedé[AnimalChoice].Euthanasié = true;

                         break;
                 }
             }
             break;
         case 3: // consulter la fiche
             Console.Clear();

             Console.WriteLine("pour quel animal voulez-vous la fiche ?  ");
             int AnimalChoix = choixanimal();
             DateTime localDate = DateTime.Now;
             int age = localDate.Year - proprio1.animauxPossedé[AnimalChoix].datedenassance.Year;
             Console.Clear();
             Console.WriteLine($"Nom : {proprio1.animauxPossedé[AnimalChoix].Nom}");
             Console.WriteLine($"date ne naissance :  {proprio1.animauxPossedé[AnimalChoix].datedenassance} ==== age : {age} ans ");
             Console.WriteLine($"Sexe : {proprio1.animauxPossedé[AnimalChoix].Sexe}");
             Console.WriteLine($"Taille : {proprio1.animauxPossedé[AnimalChoix].Taille} cm");
             Console.WriteLine($"Poid  :  {proprio1.animauxPossedé[AnimalChoix].Poid} gr");
             Console.WriteLine($"Vaccin  : {proprio1.animauxPossedé[AnimalChoix].Vaccine}");
             Console.WriteLine($"numero du vaccin  : {proprio1.animauxPossedé[AnimalChoix].numeroVaccin}");
             Console.WriteLine($"Sterilisation  : {proprio1.animauxPossedé[AnimalChoix].sterililsé}");
             Console.WriteLine($"Puce :{proprio1.animauxPossedé[AnimalChoix].EstPuce} ");
             Console.WriteLine($"numero de la Puce :{proprio1.animauxPossedé[AnimalChoix].numeropuce} ");


             for (int j = 0; j < proprio1.animauxPossedé[AnimalChoix].soinsdoné.Count;j++)
             {
                 Console.WriteLine($"{j+1} :  {proprio1.animauxPossedé[j].soinsdoné} ");

             }
             break;
         case 4://changer les coordonée proprio
             Console.Clear();
             Console.WriteLine("Quel est votre nom ");
             proprio1.Nom = Console.ReadLine();
             Cabinet.proprios.Add(proprio1);
             Console.WriteLine();
             Console.WriteLine("quel est votre date de naissance ? ");
             proprio1.birthdate = DateOnly.Parse(Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("dans quel rue habiter vous ? ");
             proprio1.Rue = Console.ReadLine();
             Console.WriteLine();
             Console.WriteLine("a quel numero ? ");
             proprio1.Numero = Int32.Parse(Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("dans quelle ville ? ");
             proprio1.ville = (Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("quel est le cade postal ? ");
             proprio1.CodePostal = Int32.Parse(Console.ReadLine());
             Console.WriteLine();
             break;
         case 0:
             Console.WriteLine($"Merci de votre visite mr {proprio1.Nom} ");
             break;         
}
} while (premChoix != 0);


int choixanimal()
{
    for (int i = 0; i < proprio1.animauxPossedé.Count; i++)
    {
       
        Console.WriteLine($"{i} :  {proprio1.animauxPossedé[i].Nom} ");
    }
    return int.Parse(Console.ReadLine());
}
int choixproprio()
{
    for (int i = 0; i < Cabinet.proprios.Count; i++)
    {
       
        Console.WriteLine($"{i} :  {Cabinet.proprios[i].Nom} ");
    }
    return int.Parse(Console.ReadLine());
}
 void EstMalade()
{
    // choix aleatoire d' un animal qui est malade ou se casse une patte
    List<string> Maladie = new List<string>();
    Maladie.Add( "une fracture");
    Maladie.Add( "de la diarhee");
    Maladie.Add( "un rhume");
    Maladie.Add( "une blessure");
    Maladie.Add( "une blessure mortelle");
    Maladie.Add("est sain");
    Random rnd1 = new Random();
    //choix aleatoire de la maladie
    int mal1 = rnd1.Next(1,Maladie.Count);
    //choix de l'animal
    int animalmalade = rnd1.Next(0,proprio1.animauxPossedé.Count);

    Console.WriteLine($"{proprio1.animauxPossedé[animalmalade].Nom} ");
    Console.WriteLine($"a {Maladie[mal1]} ! ");
}
 
    


  