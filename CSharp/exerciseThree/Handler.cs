using System;
//using System.Collection.Generic;
//using System.Ling;
//using System.Text;
namespace exerciseThree{
	public class Handler{
		public static double getSalary(Employer e){
			double salary=245.0;
			if(e.getLevel()==2){
				salary+=100;	
			}
			if(e.getIsLeader()==true){
				salary+=245*.15;
			}
			return salary;
		}
		public static bool workMoreTime(Employer e,int amount){
			if(e.getExperience()*11>amount){
				return true;
			}
			return false;
		}
		public static void printEmployer(Employer e){
			Console.WriteLine("Name: "+e.getName());
			Console.WriteLine("Level: "+e.getLevel());
			Console.WriteLine("Experience: "+e.getExperience());
			Console.WriteLine("Leader: "+e.getIsLeader());
		}
		public static void compareMonts(Employer e){
			Console.WriteLine("Enter monts to compare: ");
			int montsToCompare=int.Parse(Console.ReadLine());
			if(workMoreTime(e,montsToCompare)==true){
				Console.WriteLine("employer work more the  "+montsToCompare+ "monts");
			}else{
				Console.WriteLine("employer work menos the "+montsToCompare+" monts");
			}
		}
		public static void Main(String []args){

			Employer e=new Employer();
			Console.WriteLine("Enter fields for employer\nName: ");
			e.setName(Console.ReadLine());
			Console.WriteLine("Level: ");
			e.setLevel(int.Parse(Console.ReadLine()));
			Console.WriteLine("Experience: ");
			e.setExperience(int.Parse(Console.ReadLine()));
			Console.WriteLine("Is Leader?: (yes/no)");
			if(Console.ReadLine()=="yes"){
				e.setIsLeader(true);
			}else{
				e.setIsLeader(false);
			}
			printEmployer(e);
			Console.WriteLine("his salary is : "+getSalary(e));
			compareMonts(e);
			Console.ReadKey();
		}
	}
}
