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
	    
	    static int nbRetourne = 0;
		static void Main(string[] args)		{  

		string line;
		int[] list = new int[6];
		int count=0;
			while ((line = Console.ReadLine()) != null) {
				list[count]=Int32.Parse(line);
				count++;
			}
			
			Test(list,0);
			Console.WriteLine(nbRetourne);
		}
		
		static void Test(int[] list, int nb){
            if (IsSorted(list)){
                if (nb < nbRetourne)
                    nbRetourne = nb;
            }else if (nb < nbRetourne - 1){
                for (int i = 0; i < list.Length; i++){
                    int[] newList = Retourner(list,i);
                    Test(newList, nb+1);
                }
            }
        }
		
		static int[] Retourner(int[] list, int index){
		    int[] newList = list.Clone();
		    int newIndex = 0;
		    for(int i=index;i>=0;i--){
		        newList[newIndex]=list[i];
		        newIndex++;
		    }
		}
		
		static bool IsSorted(int[] list){
			int nb=list[0];
			for(int i=1;i<list.Length;i++){
				if (list[i]<nb)
					return false;
				nb=list[i];
			}
		}
	}
}