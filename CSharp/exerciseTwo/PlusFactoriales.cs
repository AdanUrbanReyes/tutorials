using System;
namespace exerciseOne{
	class PlusFactoriales{
		public static int factorial(int n){
			if(n<2){
				return 1;
			}
			return n*factorial(n-1);
		}
		public static void Main(string []args){
			int a,i,tp,antr;//amount Numbers To Read; tp totalPlus; a auxiliary
			Console.WriteLine("Please enter amount numbers to insert");
			antr=int.Parse(Console.ReadLine());
			int []ne=new int[antr];//numbers entered
			for(i=0;i<antr;i++){
				Console.WriteLine("Please insert "+i+" number");
				ne[i]=int.Parse(Console.ReadLine());
			}
			for(tp=0,i=0;i<antr;i++){
				a=factorial(ne[i]);
				Console.WriteLine(""+ne[i]+" factorial = "+a);
				tp+=a;
			}
			Console.WriteLine("plus factorial = "+tp);
		}
	}
}
