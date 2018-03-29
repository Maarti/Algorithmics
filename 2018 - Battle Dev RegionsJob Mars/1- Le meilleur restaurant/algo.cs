using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******
 * Read input from Console
 * Use Console.WriteLine to output your result.
 * Use:
 *       Utils.LocalPrint( variable); 
 * to display simple variables in a dedicated area.
 * 
 * Use:
 *      
		Utils.LocalPrintArray( collection)
 * to display collections in a dedicated area.
 * ***/

namespace CSharpContestProject
{
	class Program
	{
		static void Main(string[] args)
		{   string line;
		    Console.ReadLine(); // dont care
		    float best=-1f;
			while ((line = Console.ReadLine()) != null) {
				string[] notes = line.Split(' ');
				float note = (Int32.Parse(notes[0]) + Int32.Parse(notes[1]) + Int32.Parse(notes[2]))/3f;
				if(note>best)
				    best = note;
			}

			Console.Write(Math.Ceiling(best) );
		}
	}
}