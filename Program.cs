using System;
using System.Collections.Generic;

namespace BigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>
            {
                2,3,12,4,212,12,44
            };
            var numbers2Dim = new List<int[]>
            {
                new int[1]{2},
                new int[1]{3},
                new int[1]{4},
            };

            function1(numbers);
            function2(numbers);
            function3(numbers2Dim);
        }

		private static void function3(List<int[]> numbers2Dim) {
			foreach(var element in numbers2Dim)
            {
                foreach(var secondElement in element)
                {
                    System.Console.WriteLine(secondElement);
                }
            }
		}

		//O(1)
		private static void function1(List<int> numbers) {
			Console.WriteLine(numbers[0]);
		}
        // O(n)
		private static void function2(List<int> numbers) {
			foreach(var element in numbers)
            {
                System.Console.WriteLine(element);
            }
		}



    }
}
