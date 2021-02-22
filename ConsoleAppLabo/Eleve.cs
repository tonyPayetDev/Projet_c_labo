using ConsoleAppLabo;
using System;
using System.Collections.Generic;

public class Eleve
{
	private string m_name;
	List<Note> liste_notes = new List<Note>();

	public string Name
	{
		get { return m_name; }
		set { m_name = value; }
	}

	private ushort m_age;
	public ushort Age
	{
		get { return m_age; }
		set { m_age = value; }
	}
		

    public List<int> notes { get; private set; }


	public Eleve(string name, ushort age)
	{
		this.m_age = age;
		this.m_name = name;
		Console.WriteLine("Nouvelle personne créée. Cette personne s'appelle " + name + " et a " + age + " an(s).");
	}



    internal void addNote(ushort v, Eleve eleve, string matiere)
    {
		this.m_name = eleve.m_name;
		Note note = new Note(matiere, v);
		liste_notes.Add(note);

		//	notes.Add(v);

	}
	internal List<Note> getNote()
	{
		return liste_notes;
	}

	~Eleve()
	{
		Console.WriteLine("Objet détruit.");
	}

	public void SayHi()
	{
		Console.WriteLine("Bonjour ! Je m'appelle " + this.m_name + " et j'ai " + this.m_age + " ans.");
	}
}