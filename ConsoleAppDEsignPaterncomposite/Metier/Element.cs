using System;
using System.Collections.Generic;
using System.Text;

namespace Element.Metier
{
    public abstract class Element
    {
        protected string _path;
        protected string _nom;

        public Element(string nom,string path)
        {
            _nom = nom;
            _path = path;
        }

        public Element(string nom)
        {
            _nom = nom;
        }

        public void Renommer(string nom)
        {
            _nom = nom;
        }

        public string Chemin()
        {
            return _path;
        }

        public void Deplacer(string path)
        {
            _path = path;
        }

    }

    public class Repertoire : Element
    {
        private List<Element> _enfants = new List<Element>();

        #region Constructeur
        public Repertoire(string nom, string path)
            : base(nom,path)
        {

        }
        public Repertoire(string nom) :base (nom) { }
        #endregion

        public void Add(Element elem)
        {
            string chemin = this._path.Contains(":\\") ? this._path + this._nom : "\\" + this._nom;
            elem.Deplacer(chemin);
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

        public Fichier (string nom,string extention)
            : base(nom) 
        {
            _extension = extention;
        }
    }

    public class Raccourcie : Element
    {
        private Element _cible;
        public Raccourcie(string nom, Element cible) 
            : base(nom)
        {
            _cible = cible;
        }
    }

}
