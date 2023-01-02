using System.Collections;
using System.IO;
using System;
using static System.Console;

int i = 0;

do
{
    WriteLine("Quelle Exercice voulez vous faire ?\nExercice 1 : Plus Grand Nombre\nExercice 2 : Pass or Fail\nExercice 3 : Find the Good Number\nExercice 4 : Table de Multiplication\nExercice 5 : Produit jusqu'a 1000\nExercice 6 : Tableau qui se fait tout seul\nExercice 7 : Tableau qui se Remplit grace a vous\nExercice 8 : Tableau de Couleur\nExercice 9 : Tableau a Virgule \nExercice 10 : Tableau de 20 Chiffre return 1er divisible par 3 et 5\nExercice 11 : Jour de la Semaine \nExercice 12 : Nbr jour vécu\nExercice 13 :Timer Min et Sec\nExercice 14 :Temperature \nExercice 15 : Taille Pied/Pouce\nExercice 16 :\nExercice 17 :\nExercice 18 :\nExercice 19 :\nExercice 20 :\n21 : Quitter");
    
    i = Convert.ToInt32(ReadLine());


    switch (i)
        {
        case (1):
            Clear();
            Exercice1();

            break;
        case (2):
            Clear();
            Exercice2();

            break;
        case (3):
            Clear();
            Exercice3();

            break;
        case (4):
            Clear();
            Exercice4();

            break;
        case (5):
            Clear();
            Exercice5();
            break;
        case (6):
            Clear();
            Exercice6();
            break;
        case (7):
            Clear();
            Exercice7();
            break;

        case (8):
            Clear();
            Exercice8();
            break;

        case (9):
            Clear();
            Exercice9();
            break;

        case (10):
            Clear();
            Exercice10();
            break;

        case (11):
            Clear();
            Exercice11();
            break;

        case (12):
            Clear();
            Exercice12();
            break;

        case (13):
            Clear();
            Exercice13();
            break;

        case (14):
            Clear();
            Exercice14();
            break;

        case (15):
            Clear();
            Exercice15();
            break;

        case (16):
            Clear();
            WriteLine("Exercice n°" + i);
            break;

        case (17):
            Clear();
            WriteLine("Exercice n°" + i);
            break;

        case (18):
            Clear();
            WriteLine("Exercice n°" + i);
            break;

        case (19):
            Clear();
            WriteLine("Exercice n°" + i);
            break;

        case (20):
            Clear();
            WriteLine("Exercice n°" + i);
            break;
    }
    } while (i < 21);


// Base Algo
void Exercice1()
{
    int Number1;
    int Number2;

    WriteLine("Donner 2 Chiffres");

    Number1 = Convert.ToInt32(ReadLine());

    Number2 = Convert.ToInt32(ReadLine());

    if (Number1 > Number2)
    {
        WriteLine(Number1 + " est le plus grand Chiffre (1er chiffre)\n");

    }
    else
    {
        WriteLine(Number2 + " est le plus grand Chiffre (2nd chiffre)\n");

    }

}

void Exercice2()
{
    int Number1;

    WriteLine("Quelle Note avez vous eux ? ( sur 100 ) ");

    Number1 = Convert.ToInt32(ReadLine());

    if (Number1 >= 60)
    {
        WriteLine("Pass");

    }
    else
    {
        WriteLine("Fail");

    }

}

void Exercice3()
{
    int Number1;
    Random aleatoire = new Random();
    int entierUnChiffre = aleatoire.Next(101); //Génère un entier compris entre 0 et 100

    WriteLine("Trouver le bon numéro (sur 100)");

    do
    {
        Number1 = Convert.ToInt32(ReadLine());
        if (Number1 != entierUnChiffre)
        {
            WriteLine("Incorrect\n");
        }
        else
        {
            WriteLine("Correct!\n");
        }



    } while (Number1 != entierUnChiffre);
}

void Exercice4()
{
    int Number1;
    int Résultat;

    WriteLine("Table de Multiplication de quelle chiffre ? \n");
    Number1 = Convert.ToInt32(ReadLine());
     
        for(int i = 0; i < 13; i++)
        {
            Résultat = Number1 * i;
            WriteLine(Number1 + " x " + i + " = " + Résultat);
        }
            
            WriteLine('\n');

}

void Exercice5()
{
    int Number1;
    int Résultat;

    WriteLine("Objectif 1000 (ou plus) ! \nVeuillez entrer les 2 Nombre de départs");
    Number1 = Convert.ToInt32(ReadLine());
    Résultat = Convert.ToInt32(ReadLine());
    Résultat *= Number1;
    WriteLine(Résultat + "\n");


    do
    {
        WriteLine("Ajouter un Nombre !");

        Number1 = Convert.ToInt32(ReadLine());
        Résultat *= Number1;
        WriteLine(Résultat + "\n");



    } while (Résultat < 1000);
}

//Loop Array

void Exercice6()
{
    int[] Tableau = new int[10];

    WriteLine("Tableau se remplisant seul ");

    for (int i = 1; i < 11; i++)
    {
        Tableau[i - 1] = i;
        WriteLine(Tableau[i -1 ]);

    }
}

void Exercice7()
{
    int[] Tableau = new int[10];
    int Number1;

    WriteLine("Tableau se remplisant grace a vous ");

    for (int i = 1; i < 11; i++)
    {
        WriteLine("Chiffre n°" + i);
        Number1 = Convert.ToInt32(ReadLine());
        Tableau[i - 1] = Number1;

    }
    WriteLine("Résultat : ");

    for (int i = 1; i < 11; i++)
    {
        WriteLine(Tableau[i - 1]);
    }
    WriteLine('\n');

}
void Exercice8()
{
    string[] Tableau = new string[5];
    string? Couleur;
    

    WriteLine("Tableau de Couleur (5)");

    for (int i = 1; i < 6; i++)
    {
        WriteLine("Couleur n°" + i);


        Couleur = ReadLine();

        Couleur ??= "Oubli";

        Tableau[i - 1] = Couleur;

    }
    WriteLine("Résultat : ");

    for (int i = 1; i < 6; i++)
    {
        WriteLine(Tableau[i - 1]);
    }
    WriteLine('\n');

}

void Exercice9()
{
    Double[] Tableau = new Double[6];
    Double Résultat = 0;

    WriteLine("Tableau se remplisant seul des chiffre a virgule ");

    for (int i = 1; i < Tableau.Length; i++)
    {
        Tableau[i - 1] = i+0.5;
        WriteLine(Tableau[i - 1]);

    }
    WriteLine("Résultat : ");

    //do
    //{

    //}while()


    for (int i = 1; i < Tableau.Length; i++)
    {
        Résultat += Tableau[i - 1];

    }
    WriteLine(Résultat + '\n');

}

//EX 10 PRB
void Exercice10() 
{
    int[] Tableau = new int[20];
    int Résultats = 0;
    int Test = 0;
    int Test1 = 0;

    WriteLine("Tableau se remplisant seul de 0 a 20 ");

    for (int i = 1; i < Tableau.Length; i++)
    {
        Tableau[i - 1] = i;
        WriteLine(Tableau[i - 1]);

    }
    for (int i = 1; i < Tableau.Length; i++)
    {



        Test = Tableau[i] / 3;
        WriteLine(Test + '\n');

        Test1 = Tableau[i] / 5; 
        WriteLine(Test1 + '\n');

        //if (Tableau[i] / 3 && Tableau[i] / 5)

    }

    WriteLine(Résultats + '\n');


}

//Enum Constantes

void Exercice11()
{
    int Number1;

    WriteLine("Donner un Numéro pour le Chiffre de la Semaine (1 - 7)");

    
        Number1 = Convert.ToInt32(ReadLine());

    JourSemaine AujourdhuiB = (JourSemaine)Number1;

    WriteLine(AujourdhuiB);

}


void Exercice12()
{
    int Number1;
    int jourAns = 365;
    int Années;

    WriteLine("Donner votre année de naissance");


    Number1 = Convert.ToInt32(ReadLine());

    Années = DateTime.Now.Year;

    Années -= Number1;

    Années *= jourAns;

    WriteLine(Années);

}

void Exercice13()
{
    int MinuteTT = 60;
    int Minute;
    int Seconde;

    WriteLine("Donner un temps en min (1min 30sec)");


    Minute = Convert.ToInt32(ReadLine());
    Seconde = Convert.ToInt32(ReadLine());

    Minute *= MinuteTT;

    Minute += Seconde;

    WriteLine(Minute + '\n');

}

void Exercice14()
{
    int Temperature;
    string TEST = "";

    WriteLine("Donner une Temperature en C°");


    Temperature = Convert.ToInt32(ReadLine());

    //Saison Temp = (Saison)Temperature;

    //switch (i)
    //{
    //    case (1):
    //        Clear();
    //        Exercice1();

    //        break;
    //}


    if (Temperature >= 30)
    {
        TEST = "Chaud";
    }
    if (Temperature >= 21&& Temperature < 30)
    {
        TEST = "Tiede";
    }
    if (Temperature > 10 && Temperature <= 20)
    {
        TEST = "Tiede";
    }
    if (Temperature <= 10)
    {
        TEST = "Froid";
    }

    WriteLine(TEST + '\n');

}


void Exercice15()
{
    int PiedTT = 12;
    int Pied;
    int Pouce;

    WriteLine("Donner votre taille en Pied ( 5 Pied 7 Pouces)");


    Pied = Convert.ToInt32(ReadLine());
    Pouce = Convert.ToInt32(ReadLine());

    Pied *= PiedTT;

    Pied = Pied + Pouce;

    WriteLine(Pied-10 + "Pouces\n \n");

}



enum Saison
{
    Primtemps,
    Été,
    Automne,
    Hiver,

}

enum JourSemaine
{
    Lundi = 1,
    Mardi = 2,
    Mercredi = 3,
    Jeudi = 4,
    Vendredi = 5,
    Samedi = 6,
    Dimanche = 7,
}

