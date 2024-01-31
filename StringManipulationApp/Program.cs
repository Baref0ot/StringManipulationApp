using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulationApp {
    public class Program {
        public static void Main(string[] args) {
            List<string> inputList = new List<string>
            {
                "13173697-n",
                "98765432-x",
                "54321012-y",
                "99999999-z"
            };

            List<string> manipulatedList = ManipulateStrings(inputList);

            Console.WriteLine("Original List:");
            foreach (string item in inputList) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nManipulated List:");
            foreach (string item in manipulatedList) {
                Console.WriteLine(item);
            }
        }

        public static List<string> ManipulateStrings(List<string> inputList) {
            List<string> manipulatedList = new List<string>();

            foreach (string inputString in inputList) {
                // Split the input string by '-' character
                string[] parts = inputString.Split('-');

                if (parts.Length == 2) {
                    // Reconstruct the string with 'n' at the beginning
                    string manipulatedString = parts[1] + parts[0];

                    manipulatedList.Add(manipulatedString);
                }
                else {
                    Console.WriteLine($"Invalid input: {inputString}");
                }
            }

            return manipulatedList;
        }// end ManipulateStrings
    }
}
