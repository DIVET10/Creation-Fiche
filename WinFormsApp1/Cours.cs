using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cours
    {
        private int numCour;
        private string code;
        private string titre;

        public Cours(int numCour, string code, string titre)
        {
            this.NumCour = numCour;
            this.Code = code;
            this.Titre = titre;
        }

        public Cours(string code, string titre)
        {
            this.NumCour = numCour;
            this.Code = code;
            this.Titre = titre;
        }

        public int NumCour { get => numCour; set => numCour = value; }
        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
    }
}
