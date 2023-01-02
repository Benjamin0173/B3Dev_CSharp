using System.Collections;
using System.IO;
using System;

/*
//int test =  65;
//char unCaractere = 'q';
//int test2;
//test2 = 5;

//bool b1 = true;
//bool b2 = b1;
//b1 = false;

//ArrayList tab1 = new ArrayList();

//public class MaClasse
//{
//    //propieter
//    public string Id { get; set; }
//    public string MyName { get; set; }
    
//    //Contructeur
//    public MaClasse() 
//    {
        
//    }

//}
////instanciation
//MaClasse uneInstanceDeMaClasse = new MaClasse();
*/

Console.WriteLine("Hello, World!");

/*

Test C1 = new Test();

C1.boolean = true;

Test C2 = C1;

C1.boolean = false;

Console.WriteLine(C1.boolean);
Console.WriteLine(C2.boolean);

int i = 20;

bool b = i >= 20 ? true : false;

Console.WriteLine(b);

short s = 300;

byte y = (byte)s;

Console.WriteLine(y);



JourSemaine Aujourdhui = JourSemaine.Lundi;
JourSemaine AujourdhuiB = 0;

Console.WriteLine(Aujourdhui);
Console.WriteLine(AujourdhuiB);
Console.WriteLine(JourSemaine.Travail);
Console.WriteLine(JourSemaine.Weekend);
Console.WriteLine(JourSemaine.Semaine);
*/
int[,] TableauA = new int[1, 2];
int[,,] TableauB = new int[5, 2, 3];

// Expliquer la difference entre ces syntaxes

int[][] Tableau = new int[3][];
Tableau[0] = new int[] { 45, 2 };
Tableau[1] = new int[] { 34, 34, 4, 67 };

//Console.WriteLine(TableauA);

//For

for (int i = 0; i < Tableau[0].Length; i++)
{
    //Console.WriteLine(Tableau.Length);
    //Console.WriteLine(Tableau[0].Length);
    //Console.WriteLine(Tableau[1].Length);
    //Console.WriteLine(Tableau[i][0]);



    foreach (int j in Tableau[i])
    {
        Console.WriteLine(j);
    }
}


public class Test
{
    public bool boolean;
}

enum JourSemaine
{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche,
    Weekend = Dimanche + Samedi,
    Travail = Lundi + Mardi + Mercredi + Jeudi + Vendredi,
    Semaine = Travail + Weekend,


}


