using System;

namespace ConsoleAppLabo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debut prog!");
            Eleve eleve = new Eleve("tony", 10);
            eleve.SayHi();
            Eleve eleve2 = new Eleve("test", 10);
            Eleve eleve3 = new Eleve("titi", 10);

            Professeur prof = new Professeur("Robert");
            Console.Out.Write(prof.Name);

            prof.ajouterNote(20, eleve, "anglais");
            prof.ajouterNote(4, eleve, "geo");
            prof.ajouterNote(20, eleve, "geo");

            prof.ajouterNote(10, eleve2, "geo");
            prof.ajouterNote(15, eleve2, "anglais");
            prof.ajouterNote(20, eleve2, "anglais");


            prof.ajouterNote(2, eleve3, "geo");
            prof.ajouterNote(2, eleve3, "geo");
            prof.ajouterNote(4, eleve3, "anglais");

            prof.moyenneNote(eleve);
            prof.moyenneNoteParMatiere(eleve, "geo");

            prof.moyenneNote(eleve2);
            prof.moyenneNote(eleve3);

          //  prof.moyenneGeneral();


        }
    }
}
