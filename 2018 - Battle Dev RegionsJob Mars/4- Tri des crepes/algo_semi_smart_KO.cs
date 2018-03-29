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
	    
	    static int NextRetourne = -1;
		static void Main(string[] args)		{  

		    Utils.LocalPrint("start");
		    string line;
		int[] list = new int[6];
		int count=0;
			while ((line = Console.ReadLine()) != null) {
			    Utils.LocalPrint(line);
				if(count>6)
				    break;
				list[count]=Int32.Parse(line);
				count++;
			}
			Utils.LocalPrint("endWhileLine");

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
			int nbRetourne = 0;
			
			bool fini = false;
			
			while(!fini){
			    int next =    GetNextIndex(list,list.Length);
			    if(next==-10){
			        fini = true;
			    }else{
			        Retourner(list,NextRetourne);
			        nbRetourne++;
			    }
			    
			}
			Utils.LocalPrint("fini");
			
			Console.WriteLine(nbRetourne);
			
			
		}
		
		static void Retourner(int[] list, int index){
		    Utils.LocalPrint("retourne");
		    int[] newList = new int[index+1];
		    int newIndex = 0;
		    for(int i=index;i>=0;i--){
		        newList[newIndex]=list[i];
		        newIndex++;
		    }
		    
		    for(int i=0;i<=index;i++){
		        list[i]=newList[i];
		    }
		}
		
		
		static int GetNextIndex(int[] list, int size){
		    if(size<=1)
		        return -10;
		    
		    int max = -1;
		    int maxIndex = -1;
		    for(int i=0;i<size;i++){
		        if(list[i]>max){
		            max=list[i];
		            maxIndex = i;
		        }
		    }
		    if(maxIndex==size-1)
		        return GetNextIndex(list,size-1);
		    else{
		        if(maxIndex==0){
		            NextRetourne = size-1;
		            return maxIndex;
		        }else{
		            NextRetourne = maxIndex;
		            return maxIndex;
		        }
		    }
		        
		}
		
	}
}