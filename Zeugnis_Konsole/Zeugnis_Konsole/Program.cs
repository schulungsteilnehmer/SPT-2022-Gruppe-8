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
			Console.WriteLine("Namen eingeben:");
			string name;
			name = Console.ReadLine();
			
			Console.WriteLine();
			Console.WriteLine("Datum angeben:");
			string datum;
			datum = Console.ReadLine();
			
			Console.WriteLine();
			Console.WriteLine("Noten eingeben");
			
			Console.WriteLine();
			Console.WriteLine("Mathe LK");
			int Mathe; 
			Mathe = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Deutsch");
			int Deutsch; 
			Deutsch = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Bio LK");
			int Bio; 
			Bio = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Englisch"); 
			int Englisch; 
			Englisch = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine(); 
			Console.WriteLine("Physik"); 
			int Physik;
			Physik = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine(); 
			Console.WriteLine("Chemie"); 
			int Chemie; 
			Chemie = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Politik"); 
			int Politik; 
			Politik = Convert.ToInt32(Console.ReadLine()); 
			
			Console.WriteLine(); 
			Console.WriteLine("Geschichte"); 
			int Geschichte; 
			Geschichte = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine(); 
			Console.WriteLine("Notendurchschnitt");
			double Ergebnis;
			Ergebnis = (2*Mathe+2*Bio+Deutsch+Englisch+Physik+Chemie+Geschichte+Politik)/10;
			Ergebnis = (17-Ergebnis)/3;
			Console.WriteLine(Ergebnis);
			
			Console.WriteLine();
			Console.WriteLine("Unentschuldigte Fehltage eintragen:");
			int Fehltage;
			Fehltage = Convert.ToInt32(Console.ReadLine());
			if (Fehltage > 29) && if ( 
				Console.WriteLine("Der Schüler wird nicht versetzt.");
			if (
			
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