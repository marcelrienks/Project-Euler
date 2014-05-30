
namespace ProjectEuler.Problems {
	public class Problem1 : IProblem {

		//Problem 1:
		//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
		//Find the sum of all the multiples of 3 or 5 below 1000.

		//Answer:
		//233168
		public string Solve() {
			var sumOfMultiples = 0;
			for (var ct = 0; ct < 1000; ct++) {
				if (ct % 3 == 0 || ct % 5 == 0) {
					sumOfMultiples += ct;
				}
			}

			return string.Format("The sum of all multiples of 3 or 5 below 1000 is {0}", sumOfMultiples);
		}
	}
}
