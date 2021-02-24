using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDesignPaterncomposite.Metier
{
    public abstract class Element
    {
        protected string _path;
        protected string _nom;

        public Element(string nom, string path)
        {
            _path = nom;
            _path = path;
        }

        public void Renommer(string nom)
        {
            _nom = nom;
        }

    }

    public class Repertoire : Element
    {
        private List<Element> _enfants = new List<Element>();

        public Repertoire(string nom, string path)
            : base(nom, path)
        {
        }

        public void Creer(Element elem)
        {
            _enfants.Add(elem);
        }

        public void Supprimer(Element elem)
        {
            _enfants.Remove(elem);
        }
    }

    public class Fichier : Element
    {
        private string _extension;

        public Fichier (string nom, string path,string extention)
            : base(nom,path) 
        {
            _extension = extention;
        }
    }

    public class Raccourcie : Element
    {
         
    }




}
