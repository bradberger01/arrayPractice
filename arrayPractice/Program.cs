using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            //dataType[] nameOfArray = { elements};
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //Console.WriteLine(students[4]); //Mike
            //Console.WriteLine(students[0]); //Brad

            //Top 10 vacation spots; print out first and last

            //String[] vacaSpots = { "Paris", "Barcelona", "St. Martin", "Bahamas", "Israel", "Florida", "New York", "Amsterdam", "Toronto", "San Diego" };

            //Console.WriteLine(vacaSpots[0]);
            //Console.WriteLine(vacaSpots[9]);
            //Console.WriteLine(vacaSpots.Length - 1); //easy way to get to the last element

            //Ages of 3 children; print each childs age

            //int[] childrenAges = { 1, 5, 9 };
            //Console.WriteLine(childrenAges[0]);
            //Console.WriteLine(childrenAges[1]);
            //Console.WriteLine(childrenAges[2]);

            //GPA on a 4.0 scale of 8 students
            //When you DON'T KNOW the elements of your array upfront 
            //datatype[] nameOfArray = new dataType[#ofElements];

            //float[] gpa = new float[8];//DECLARING AN ARRAY
            //gpa[0] = 4.0f;
            //gpa[1] = 3.5f;

            //first letter of your peers names who are sitting near you
            //char[] classPeers = { 's', 's', 'a' };//INITIALIZING ARRAY - YOU KNOW INFO UPFRONT
            //Console.WriteLine(classPeers);

            //DECLARE AND INITIALIZE an array for the days of the week
            //string[] daysOfTheWeek = new string[7];//Declaring an array with 7 indexes
            //daysOfTheWeek[0] = "Sunday";
            //daysOfTheWeek[2] = "Monday";
            //daysOfTheWeek[3] = "Tuesday";
            //daysOfTheWeek[4] = "Wednesday";
            //daysOfTheWeek[5] = "Thursday";
            //daysOfTheWeek[6] = "Friday";
            //daysOfTheWeek[7] = "Saturday";
            ////DECLARE AND INITIALIZE an array of student ages using the "new" keyword
            ////int[] studentAges = new int[3];
            ////studentAges[0] = 15;
            ////studentAges[1] = 25;
            ////studentAges[2] = 28;
            //Console.WriteLine(daysOfTheWeek[0]);
            ////daysOfTheWeek.SetValue("Funday", 0);
            ////Console.WriteLine(daysOfTheWeek[0]);

            //string[] birthMonths = { "December", "July", "May", "July" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "July"));//IndexOf finds the 1st element of "July" and returns it
            //Console.WriteLine(Array.LastIndexOf(birthMonths, "July"));



            //DO IT
            //Create an array of names and choose a name to pring IndeoOf

            string[] names = { "Jane", "Joey", "Mika", "Bradley", "Paul" };
            Console.WriteLine(Array.IndexOf(names, "Bradley"));


            //Create an array of Lucky numbers, each number should repeat at least once. Choose a lucky number, find and print the last of it

            int[] luckyNumbers = { 8, 24, 37, 24, 8, 37 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 8));

            //Create an array of alphabet characters. Print the first index of the array. Now reverse the array and print the first index.

            char[] alphabetLetters = { 'a', 'c', 'e', 'g', 'i' };
            Console.WriteLine(alphabetLetters[0]);
            Array.Reverse(alphabetLetters);
            Console.WriteLine(alphabetLetters[0]);






        }
    }
}
