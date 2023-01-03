﻿using System.Collections;
using System.IO;
using System;
using static System.Console;
using System.Reflection;

int i = 0;


do
{
    WriteLine("Quelle Exercice voulez vous faire ?\nExercice 1 : Tuture\nExercice 2 : Etudiant\nExercice 3 : Bank\nExercice 4 : Calculatrice\nExercice 5 : Rectangle\nExercice 6 : avion/oiseau\nExercice 7 : Animal/Chat/lion\nExercice 8 : des Aires et tout sa\n         9 : Quitter");

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
    }
} while (i < 9);

void Exercice1()
{


     string marque;
 string modele;
 int nbPortes;
 string couleur;


WriteLine("voici une marque,un modele, le nb de porte et sa couleur");

    marque = ReadLine();
    modele = ReadLine();
    nbPortes = Convert.ToInt32(ReadLine());
    couleur = ReadLine();


    Voiture tuture = new Voiture(marque,modele,nbPortes,couleur);
    
    tuture.Description(); 


}

void Exercice2()
{
    string marque;
    string modele;
    int nbPortes;


    WriteLine("voici un Eleve");


    marque = ReadLine();
    modele = ReadLine();
    nbPortes = Convert.ToInt32(ReadLine());

    Etudiant tutudiant = new Etudiant(marque, modele, nbPortes);

    tutudiant.Description();
}

void Exercice3()
{
    int i = 0;
    string modele;
    int nbPortes;

    WriteLine("Votre Compte Nom puis Solde");


    modele = ReadLine();
    nbPortes = Convert.ToInt32(ReadLine());

    CompteBancaire tutudiant = new CompteBancaire( modele, nbPortes);

    tutudiant.Description();

    do
    {
        WriteLine("Voulez vous (1)déposer ou (2)retirer?");

    i = Convert.ToInt32(ReadLine());


        switch (i)
        {
            case (1):
                tutudiant.Deposer();
                break;
            case (2):
                tutudiant.Retirer();
                break;
        }
    } while(i <3);

}

void Exercice4()
{
    int i = 0;
    int modele;
    int nbPortes;

    WriteLine("Votre calculatrice a puis b");


    modele = Convert.ToInt32(ReadLine());
    nbPortes = Convert.ToInt32(ReadLine());

    Calculatrice tutudiant = new Calculatrice(modele, nbPortes);

    do
    {
        WriteLine("Voulez vous (1)additionner ou (2)multiplier?");

        i = Convert.ToInt32(ReadLine());


        switch (i)
        {
            case (1):
                tutudiant.additionner();
                break;
            case (2):
                tutudiant.multiplier();
                break;
        }
    } while (i < 3);

}
void Exercice5()
{
    int i = 0;
    float modele;
    float nbPortes;

    WriteLine("Votre rectangle a puis b");


    modele = Convert.ToSingle(ReadLine());
    nbPortes = Convert.ToSingle(ReadLine());

    Rectangle tutudiant = new Rectangle(modele, nbPortes);

    do
    {
        WriteLine("Voulez vous savoir sont (1)air ou (2)perimetre?");

        i = Convert.ToInt32(ReadLine());


        switch (i)
        {
            case (1):
                tutudiant.aire();
                break;
            case (2):
                tutudiant.perimetre();
                break;
        }
    } while (i < 3);
}

//Classes : héritage et interface

void Exercice6()
{
    string nom;
    int nbmoteur;

    WriteLine("Votre oiseau/nbmoteur avion");

    nom = (ReadLine());
    nbmoteur = Convert.ToInt32(ReadLine());

    IVolant volant = new IVolant();
    Oiseau sosio = new Oiseau(nom);
    Avion avion = new Avion( nbmoteur, nom);

    volant.Voler();

    sosio.Description();

    avion.Description();


}

void Exercice7()
{
    string nom;
    float poids;

    WriteLine("Votre nom/poids lion");

    nom = (ReadLine());
    poids = Convert.ToSingle(ReadLine());

    IAnimal animal = new IAnimal();
    Chat chat = new Chat(nom);
    Lion lion = new Lion(poids, nom);

    animal.Crier();

    chat.Description();

    lion.Description();

}

void Exercice8()
{
    string couleur;
    float rayon;
    float largeur;
    float hauteur;

    WriteLine("Donner une Couleur/ un rayon / un largeur / une hauteur");

    couleur = (ReadLine());
    rayon = Convert.ToSingle(ReadLine());
    largeur = Convert.ToSingle(ReadLine());
    hauteur = Convert.ToSingle(ReadLine());

    Forme forme = new Forme(couleur);
    Cercle cercle = new Cercle(rayon, couleur);
    Rectangles rectangle = new Rectangles(largeur, hauteur, couleur);

    cercle.Description();

    rectangle.Description();
}

//Studies

class Voiture
{
    public string marque;
    public string modele;
    public int nbPortes;
    public string couleur;

    public Voiture(string Marque, string Modele, int Nbportes, string Couleur) {

        marque = Marque;
        modele = Modele;
        nbPortes = Nbportes;
        couleur = Couleur;

    }


    public void Description()
    {
        WriteLine("La voiture est une " + marque + " " + modele + " avec " + nbPortes + " portes de couleur " + couleur + ".");
    }
}

class Etudiant
{
    public string prenom;
    public string nom;
    public int age;

    public Etudiant(string Marque, string Modele, int Nbportes)
    {

        prenom = Marque;
        nom = Modele;
        age = Nbportes;

    }
    public void Description()
    {
        WriteLine("Bonjour, je m'appelle " + prenom + " " + nom + " et j'ai " + age + " ans.");
    }
}

class CompteBancaire
{
    public string nomtitulaire;
    public float solde;

    public CompteBancaire(string Marque, float Nbportes)
    {

        nomtitulaire = Marque;
        solde = Nbportes;

    }

    public void Retirer()
    {
        int test;
        WriteLine("Retirer Combien?");


        test = Convert.ToInt32(ReadLine());

        solde -= test;

        if (solde <=0)
        {
            WriteLine("vous ne pouvez pas faire cette opération");

            solde += test;

        }


        WriteLine("Bonjour " + nomtitulaire + " , il vous reste " + solde + " sur votre compte. ");
        
    }

    public void Deposer()
    {

        int test;

        WriteLine("Deposer Combien?");


        test = Convert.ToInt32(ReadLine());

        solde += test;

        WriteLine("Bonjour " + nomtitulaire + " , il vous reste " + solde + " sur votre compte. ");
    }


    public void Description()
    {
        WriteLine("Bonjour " + nomtitulaire + " , il vous reste " + solde + " sur votre compte. ");
    }
}

class Calculatrice
{
    public int a;
    public int b;

    public Calculatrice(int Marque, int Nbportes)
    {

        a = Marque;
        b = Nbportes;

    }

    public void additionner()
    {
        int test;
        WriteLine("additionner");


        test = a + b;


        WriteLine(test);

    }

    public void multiplier()
    {
        int test;
        WriteLine("multiplier");


        test = a * b;


        WriteLine(test);
    }
}

class Rectangle
{
    public float a;
    public float b;

    public Rectangle(float Marque, float Nbportes)
    {

        a = Marque;
        b = Nbportes;

    }

    public void aire()
    {
        float test;
        WriteLine("Aire");


        test = a * b;


        WriteLine(test);

    }

    public void perimetre()
    {
        float test;
        WriteLine("Perimetre");


        test = (a + b)*2;


        WriteLine(test + "m²");
    }
}

//Classes : héritage et interface

class IVolant
{
    public void Voler()
    {
        WriteLine("Je suis en train de voler!");
    }
}

class Oiseau : IVolant
{
    public string Nom;

    public Oiseau(string Marque)
    {

        Nom = Marque;

    }

    public void Description()
    {
        WriteLine("Je suis un oiseau de nom" + Nom);
    }
}

class Avion : Oiseau
{
    public int a;


    public Avion(int nbMoteur, string Marque): base(Marque)
    {

        a = nbMoteur;

    }

    public void Description()
    {
        WriteLine("Je suis un avion avec " + a + " moteurs de nom " + this.Nom);
    }
}

//

class IAnimal
{
    public void Crier()
    {
        WriteLine("Roarr");
    }
}

class Chat : IAnimal
{
    public string Nom;

    public Chat(string Marque)
    {

        Nom = Marque;

    }

    public void Description()
    {
        WriteLine("Je suis un chat de nom " + Nom);
    }
}

class Lion : Chat
{
    public float a;


    public Lion(float poids, string Marque) : base(Marque)
    {

        a = poids;

    }

    public void Description()
    {
        WriteLine("Je suis un lion de " + a + " kg de nom " + this.Nom);
    }
}

//

class Forme
{
    public string Couleur;

    public Forme(string Marque)
    {
        Couleur = Marque;
    }
}

class Cercle : Forme
{
    public float rayon;
    public double pi = 3.14159265359;

    public Cercle(float Rayon, string Marque) : base(Marque)
    {

        rayon = Rayon;

    }

    public void Description()
    {
        float result;

        result = ((float)(pi * (rayon*rayon)));

        WriteLine("Le Rayon du cercle est : " + result);
    }
}

class Rectangles : Forme
{
    public float largeur;
    public float hauteur;



    public Rectangles(float Largeur,float Hauteur , string Marque) : base(Marque)
    {

        largeur = Largeur;
        hauteur = Hauteur;

    }

    public void Description()
    {
        float result;

        result = (hauteur * largeur);

        WriteLine("Le Rayon du Rectangle est : " + result);
    }
}