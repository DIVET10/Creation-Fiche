using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Notes
    {
        private int numEtudiant;
        private string numCours = "";
        private double note = 0;

        public Notes(int numEtudiant, string numCours, int note)
        {
            this.numEtudiant = numEtudiant;
            this.numCours = numCours;
            this.note = note;
        }

        public int NumEtudiant { get => numEtudiant; set => numEtudiant = value; }
        public  string NumCours { get => numCours; set => numCours = value; }
        public double Note { get => note; set => note = value; }
    }
}
