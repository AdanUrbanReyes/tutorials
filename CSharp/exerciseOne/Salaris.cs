using System;
namespace exerciseOne{
	public class Salaris{
		public static void Main(string []args){
			int i,ne;//ne number of employers; i iterator;
			double ps;//ps plus salaris
			Console.WriteLine("Enter number of employers");
			ne=int.Parse(Console.ReadLine());
			string []name=new string[ne];
			double []salary=new double[ne];
			for(i=0,ps=0;i<ne;i++){
				Console.WriteLine("Enter name for "+(i+1)+" employer");
				name[i]=Console.ReadLine();
				Console.WriteLine("Enter salary for "+(i+1)+ "employer");
				salary[i]=double.Parse(Console.ReadLine());
				ps+=salary[i];
			}
			Console.Write("average salaris = "+(ps/ne));
		}
	}
} 
