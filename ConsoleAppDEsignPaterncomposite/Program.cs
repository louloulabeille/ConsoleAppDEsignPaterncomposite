using System;
using Element.Metier;

namespace ConsoleAppDesignPaterncomposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Repertoire mere = new Repertoire("Mere", "C:\\");
            Fichier fichier1 = new Fichier("test",".txt");
            mere.Add(fichier1);
            Repertoire filsRep = new Repertoire("Fils");
            mere.Add(filsRep);
            Raccourcie raccourcie1 = new Raccourcie("racoucieFils", filsRep);
            filsRep.Add(raccourcie1);
            

            Console.WriteLine(filsRep.Chemin());
        }
    }
}
