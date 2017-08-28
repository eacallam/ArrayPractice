using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._28._17_ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            //Best Naming Practice: give it a plural name
            //DataType[] nameOfArray = { elements }; (array is indicated by the [])
            //Initialize the array (giving it a value for the elements):

            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };

            //To write Mike's name and Brad's name
            Console.WriteLine(students[4]);
            Console.WriteLine(students[0]);

            //Top 10 vacation spots: print the first and the last
            string[] vacationSpots = { "Europe", "Canada", "Paris", "Iceland", "New Zealand", "Cleveland", "New York", "California", "Taiwan", "Mexico" };
            Console.WriteLine(vacationSpots[0] + " and " + vacationSpots[9]);
            //To print last one:
            Console.WriteLine(vacationSpots[vacationSpots.Length-1]);

            //Age of three children: print each child's age
            int[] childAges = { 3, 6, 7 };

            Console.WriteLine(childAges[0] + " " + childAges[1] + " " + childAges[2]);

            //GPAs on 4.0 scale of 8 students (we DON'T know the values)
            //dataType[] nameOfArray = new dataType[#of Elements];
            float[] gpa = new float[8];

            //to add values
            gpa[0] = 4.0f;
            gpa[1] = 3.5f; //etc

            //First letter of four of your peers' names sitting near you

            char[] firstLetters = { 'i', 'k', 'j', 'g' };

            //a string is an array of chars. Can only print the contents of an array with the following code if they are CHARS. Otherwise it tells you
            //the data type (a "logic error")
            Console.WriteLine(firstLetters);

            //Declare and initialize a string array with the 7 days of the week as its elements
            string[] dayNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //the length of the array (built-in method)
            Console.WriteLine(dayNames.Length);

            //set value (built-in method)
            Console.WriteLine(dayNames[0]);
            dayNames.SetValue("Funday", 0);
            Console.WriteLine(dayNames[0]);

            //Declare and initialize an array of 5 student ages using the "new" keyword
            int[] studentAges = new int[5];
            studentAges[0] = 15;
            studentAges[1] = 24;
            studentAges[2] = 13;
            studentAges[3] = 6;
            studentAges[4] = 7;

            //IndexOf in an array: returns first index of what you are looking for
            //LastIndexOf returns the last index of what you are looking for
            string[] birthMonths = { "December", "July", "May", "July" };
            Console.WriteLine(Array.IndexOf(birthMonths,"July")); //1 is the first instance of July
            Console.WriteLine(Array.LastIndexOf(birthMonths,"July")); //3 is the last instance of July

            //To Reverse an Array
            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);

            //To Sort an Array
            Array.Sort(numbers);
            //Writes the last number after sorting smallest to largest
            Console.WriteLine(numbers[numbers.Length-1]);

            //Declare and initialize a string array of first names.Choose a name to find and print the IndexOf.
            string[] firstNames = { "Karen", "Ian", "Jackie", "Frank"};
            Console.WriteLine(Array.IndexOf(firstNames,"Karen"));

            //Create an array of lucky numbers. Each number should repeat at least once.Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 3, 4, 5, 4, 3, 5, 6, 7, 7, 6 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers,3));

            //Create an array of alphabet characters. Print the first index of the array.Now reverse the array and print the first index.
            char[] alphabetChars = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(alphabetChars[0]);
            Array.Reverse(alphabetChars);
            Console.WriteLine(alphabetChars[0]);

            //Create an array of student names in random order. Order the students’ names using the sort method.Print the first and last students’ names.
            string[] studentNames = { "Karen", "Taylor", "Erin", "Robert", "Walter" };
            Console.WriteLine(studentNames[0]);
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);

            //Ask 10 people for their favorite numbers and create an array of those numbers.Order the numbers using the sort method.Print the first and last numbers.
            int[] favoriteNumbers = { 3, 7, 9, 1, 20, 28, 38, 29, 2, 5 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[favoriteNumbers.Length-1]);

        }
    }
}
