/*
 * Created by SharpDevelop.
 * User: Anna
 * Date: 03.05.2022
 * Time: 10:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnis_Konsole
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine( "===========Zeugnis==========");
				
			Console.Write("Namen : ");
			string name;
			name = Console.ReadLine();
			
			Console.Write("Datum : ");
			string datum;
			datum = Console.ReadLine();
			
			Console.WriteLine("============================");
			
			Console.WriteLine();
			Console.WriteLine("Noten : ");
			
			int Zähler = 0; 
			
			Console.WriteLine();
			int Mathe; 
			Console.Write("Mathe (LK) : " );
			Mathe = Convert.ToInt32(Console.ReadLine());
			if (Mathe < 5) 
				 Zähler = Zähler + 1; 
			
			Console.Write("Deutsch    : ");
			int Deutsch; 
			Deutsch = Convert.ToInt32(Console.ReadLine());
			if (Deutsch < 5) 
				Zähler = Zähler + 1; 
			
			Console.Write("Bio (LK)   : ");
			int Bio; 
			Bio = Convert.ToInt32(Console.ReadLine());
			if (Bio < 5 ) 
				Zähler = Zähler + 1;
			
			Console.Write("Englisch   : "); 
			int Englisch; 
			Englisch = Convert.ToInt32(Console.ReadLine());
			if (Englisch < 5)
				Zähler = Zähler + 1;
			 
			Console.Write("Physik     : "); 
			int Physik;
			Physik = Convert.ToInt32(Console.ReadLine());
			if (Physik < 5) 
				Zähler = Zähler + 1; 
			
			Console.Write("Chemie     : "); 
			int Chemie; 
			Chemie = Convert.ToInt32(Console.ReadLine());
			if (Chemie < 5)
				Zähler = Zähler + 1; 
			
			Console.Write("Politik    : "); 
			int Politik; 
			Politik = Convert.ToInt32(Console.ReadLine()); 
			if (Politik < 5)
				Zähler = Zähler + 1; 
			
			Console.Write("Geschichte : "); 
			int Geschichte; 
			Geschichte = Convert.ToInt32(Console.ReadLine());
			if (Geschichte < 5) 
				Zähler = Zähler + 1; 
			
			Console.WriteLine(); 
			Console.Write("Notendurchschnitt : ");
			double Ergebnis;
			Ergebnis = (2*Mathe+2*Bio+Deutsch+Englisch+Physik+Chemie+Geschichte+Politik)/10;
			Ergebnis = (17-Ergebnis)/3;
			Console.WriteLine( Math.Round(Ergebnis, 1));
			Console.WriteLine("============================");
				
			Console.WriteLine();
			Console.Write("Fehltage eintragen : ");
			int Fehltage;
			Fehltage = Convert.ToInt32(Console.ReadLine());
			if (Fehltage < 29) 
				if ( Zähler < 2)
					Console.WriteLine("Der Schüler wird versetzt.");
					else 
					Console.WriteLine("Der Schüler wird nicht versetzt.");
			else 
					Console.WriteLine("Der Schüler wird nicht versetzt.");
			
			Console.WriteLine();
			Console.WriteLine(name);
			Console.WriteLine(datum);
			Console.WriteLine(Mathe); 
			Console.WriteLine(Deutsch);
			Console.WriteLine(Bio);
			Console.WriteLine(Englisch); 
			Console.WriteLine(Physik); 
			Console.WriteLine(Chemie);
			Console.WriteLine(Politik);
			Console.WriteLine(Geschichte);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}