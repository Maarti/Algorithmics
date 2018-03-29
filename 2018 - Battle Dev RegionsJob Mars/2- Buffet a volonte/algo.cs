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
		    int prix = Int32.Parse(Console.ReadLine());
		    int nbTables = Int32.Parse(Console.ReadLine());
		    float total=0f;
			while ((line = Console.ReadLine()) != null) {
				int nbPrsn = Int32.Parse(line);
				
				float reduc = 1f;
				if (nbPrsn>=10) reduc = 0.7f;
				else if (nbPrsn>=6) reduc = 0.8f;
				else if (nbPrsn>=4) reduc = 0.9f;
				
				total += (nbPrsn*prix)*reduc;
			}

			Console.Write(Math.Ceiling(total));
		}
	}
}