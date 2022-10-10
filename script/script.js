/*let nom = "jean "
let nombre = 15
//prompt =input
//ecrit dans la console
console.log(nom+nombre)
//avertissement dans console(jaune)
console.warn(nom+nombre)
//averti d'une erreur(rouge)
console.error(nom+nombre)
//exo1 creer une alerte*/
alert("Bienvenue sur mon site")


// instituer une variable  "let"   "const" = constante
//une variable commence par lettre, _ , $ nbr pas dans les normes
//lower camel case monBeauVelo
/*let numbre = 15

alert(numbre)
alert(typeof numbre)
alert(Math.PI)/*constante de Pi a 15 decimal*/
//Constante ecrite toujours en majuscule et underscore
/*let result = 3+3+"3"
alert(result)*/

//= sert a instituer // == converit implicitement en string // === ne convertit pas

let maChaine = ("ma formation javascript");
//Retourner la position de « ma »
console.log(maChaine.indexOf("ma"));
//Indiquer l’indice de la lettre « p »
console.log(maChaine.indexOf("p"));
//Retrouver la lettre située à l’indice 21
console.log(maChaine.charAt(21));
//Remplacer « javascript » par « Java »
console.log(maChaine.replace("javascript","Java"));
//Découper la chaîne avec le délimiteur « » (espace)
console.log(maChaine.split(" "));
//Inverser la chaîne de caractères (+ difficile) :
maChaine = maChaine.split('')
maChaine.reverse()
console.log(maChaine.join(''))


let prix = prompt("quel est le prix httc?");
let quantite = prompt ("quel est la quantité?");
const TAUXTVA = 1.21;
let prixTTC= prix*quantite*TAUXTVA;
alert("le resultat est : " +prix*quantite*TAUXTVA)
alert("le resultat est : " +prixTTC) 



let today = getDay()
alert (today)