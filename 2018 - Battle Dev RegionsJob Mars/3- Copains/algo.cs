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
		    string[] mesNotesStr = Console.ReadLine().Split();
		    int[] mesNotes = {Int32.Parse(mesNotesStr[0]), Int32.Parse(mesNotesStr[1]) , Int32.Parse(mesNotesStr[2]), Int32.Parse(mesNotesStr[3]), Int32.Parse(mesNotesStr[4])};
		    int nbCop = Int32.Parse(Console.ReadLine());
		    int nbBestCop = Int32.Parse(Console.ReadLine());
		    List<Cop> lst = new List<Cop>();
			while ((line = Console.ReadLine()) != null) {
				string[] lesNotesStr = line.Split();
				Cop c = new Cop();
				lst.Add(c);
				c.n = new int[] { Int32.Parse(lesNotesStr[0]), Int32.Parse(lesNotesStr[1]), Int32.Parse(lesNotesStr[2]), Int32.Parse(lesNotesStr[3]),
				        Int32.Parse(lesNotesStr[4]), Int32.Parse(lesNotesStr[5]) };
				c.eval = Math.Abs(mesNotes[0]-c.n[0]) + Math.Abs(mesNotes[1]-c.n[1]) + Math.Abs(mesNotes[2]-c.n[2]) +
				        Math.Abs(mesNotes[3]-c.n[3]) + Math.Abs(mesNotes[4]-c.n[4]);
			}
            var sortedList = lst.OrderBy(c => c.eval).ToList();
		    float avg = 0f;
		    for(int i=0;i<nbBestCop;i++){
		        avg += (float)sortedList[i].n[5];
		    }
		    avg /= nbBestCop;
		    Console.WriteLine((int) avg);
		}
	}
	
	class Cop {
	    public int[] n;
	    public int eval=-1;
	}
}