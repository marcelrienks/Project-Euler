using System;

namespace ProjectEuler {
	public class Program {
		static void Main() {
			while (true) {
				//Get the number of the problem to solve
				Console.WriteLine("Enter the number of the problem to solve?");

				//Validate input
				var input = Console.ReadLine();
				if (input != null && input.ToLower() == "exit") {
					break;
				}

				//Use Reflection to instantiate the problem specified
				var type = System.Reflection.Assembly.Load("ProjectEuler").GetType(string.Format("ProjectEuler.Problems.Problem{0}", input));
				if (type != null) {
					var problem = (IProblem)Activator.CreateInstance(type);

					//Solve the problem
					var solution = problem.Solve();
					Console.WriteLine();
					Console.WriteLine("Problem {0}:", input);
					Console.WriteLine(solution);
					Console.WriteLine();
					Console.WriteLine("-----------------------------");
					Console.WriteLine();

				} else {
					Console.WriteLine();
					Console.WriteLine("Could not find Problem {0}?", input);
					Console.ReadLine();
				}
			}
		}
	}
}
