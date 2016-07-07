using System;
using System.Collections.Generic;
namespace firstApplication{
	public class Listas{
		public static void Main(string []args){
			List <string> names=new List<string>();
			names.Add("Ayan");
			names.Add("Alejandra");
			names.Add("Alexa");
			names.Add("Abigail");
			Console.WriteLine(names[2]);
			Console.WriteLine("elements in list "+ names.Count);
			Console.WriteLine("Alexa index="+names.IndexOf("Alexa"));//return -1 if element not found
			Console.WriteLine("Adan index="+names.Contains("Adan"));//return -1 if element not found
			names.Sort();//order list
			Console.ReadKey();
		}
	}
}
