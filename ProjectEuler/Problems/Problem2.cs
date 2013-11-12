﻿using System;

namespace ProjectEuler.Problems {
	public class Problem2 : IProblem {

		//Problem 1:
		//Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
		//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
		//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

		//Answer:
		//4613732
		public void Solve() {
			var valueOne = 1;
			var valueTwo = 2;
			var nextTerm = 0;
			var sumOfSequences = valueTwo;

			while (nextTerm < 4000000) {
				nextTerm = valueOne + valueTwo;
				valueOne = valueTwo;
				valueTwo = nextTerm;

				if ((nextTerm % 2) == 0) {
					sumOfSequences += nextTerm; 
				}
			}

			Console.WriteLine();
			Console.WriteLine("Problem 2:");
			Console.WriteLine("The sum of the even-valued terms in the Fibonacci sequence below 4000000 is {0}", sumOfSequences);
		}
	}
}
