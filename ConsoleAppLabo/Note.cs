using System.Collections.Generic;

namespace ConsoleAppLabo
{
    internal class Note
    {
        private string matiere;
        private int note;

        public Note(string matiere, int note)
        {
            this.matiere = matiere;
            this.note = note;
        }
        public string Matiere
        {
            get { return matiere; }
            set { matiere = value; }
        }
        public int Notes
        {
            get { return note; }
            set { note = value; }
        }

    }
}