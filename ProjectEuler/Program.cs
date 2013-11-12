using System;

namespace ProjectEuler {
	public class Program {
		static void Main() {
			//Get the number of the problem to solve
			Console.WriteLine("Enter the number of the problem to solve?");
			var problemNumber = Console.ReadLine();

			//Use Reflection to instantiate the problem specified
			var type = System.Reflection.Assembly.Load("ProjectEuler").GetType(string.Format("ProjectEuler.Problems.Problem{0}", problemNumber));
			if (type != null) {
				var problem = (IProblem)Activator.CreateInstance(type);

				//Solve the problem
				problem.Solve();
				Console.ReadLine();

			} else {
				Console.WriteLine();
				Console.WriteLine("Could not find Problem {0}?", problemNumber);
				Console.ReadLine();
			}
		}
	}
}
