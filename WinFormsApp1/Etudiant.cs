using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Etudiant
    {
        private int numEtudiant;
        private string nom;
        private string prenom;
        private List<Cours> courList = new List<Cours>();

        public Etudiant(int numEtudiant, string nom, string prenom)
        {
            this.numEtudiant = numEtudiant;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int NumEtudiant { get => numEtudiant; set => numEtudiant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal List<Cours> CourList { get => courList; set => courList = value; }


    }
}
