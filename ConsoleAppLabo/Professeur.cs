using System;
using System.Collections.Generic;

namespace ConsoleAppLabo
{
    internal class Professeur
    {
        private string m_name;
        int total;
        int totalMoyenneGeneral;
        private int totalNote;

        public Professeur(string v)
        {
            this.m_name = v;
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        internal void ajouterNote(ushort v, Eleve eleve,string m)
        {
            eleve.addNote(v,eleve,m);
            
        }

        internal void moyenneNote(Eleve eleve)
        {

            foreach (Note note in eleve.getNote())
            {
                total += note.Notes;
                Console.WriteLine("\n\n note " + note.Notes);
            }

            Console.WriteLine("\n\n moyenne note eleve " + total / eleve.getNote().Count);
            total = 0;

        }

        internal void moyenneNoteParMatiere(Eleve eleve, string v)
        {

            foreach (Note note in eleve.getNote())
            {
                if (v == note.Matiere)
                {
                  //  Console.WriteLine("\n\n note matiere  en " +note.Matiere + note.Notes);
                    totalNote += 1;
                    total += note.Notes;
                }
            }

            Console.WriteLine("\n\n moyenne note eleve par matiere  " + total/ totalNote);
            total = 0;
        }

    }

 
        
    
}