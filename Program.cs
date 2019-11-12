using System;

namespace rts_labs_code_exercise_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = { 1, 5, 2, 1, 10 };
            Console.WriteLine(Above_and_Below(theArray, 6));
            Console.WriteLine(questionTwo("MyString", 2));
            Console.WriteLine(questionTwoSplit("MyString", 2));
        }

        // #1  Print the number of integers in an array that are above the given input and the number that are below, e.g. for the array [1, 5, 2, 1, 10] with input 6, print “above: 1, below: 4”.
        public static string Above_and_Below(int[] givenArray, int num)
        {
            int above = 0;
            int below = 0;
            if (givenArray.Length == 0)
            {
                return "you need numbers in your Array!";
            };
            for (int x = 0; x < givenArray.Length; x++)
            {
                if (givenArray[x] > num)
                {
                    above += 1;
                };
                if (givenArray[x] < num)
                {
                    below += 1;
                };
            };
            return ($"above: {above}, below: {below}");
        }

        // #2  Rotate the characters in a string by a given input and have the overflow appear at the beginning, e.g. “MyString” rotated by 2 is “ngMyStri”.
        public static string questionTwo(string givenString, int num)
        {
            if (num < 0)
            {
                return "You need a positive number to rotate";
            };
            if (givenString == "" || givenString == null)
            {
                return "you need to provide a string!";
            };
            num = num % givenString.Length;
            if (num == 0)
            {
                return givenString;
            };
            var tempString = "";
            var untouchedString = givenString.Length - num;
            var x = givenString.Length - 1;
            while (num > 0)
            {
                tempString = givenString[x] + tempString;
                num--;
                x--;
            };
            for (var i = 0; i < untouchedString; i++)
            {
                tempString += givenString[i];
            };
            return tempString;
        }
        // THE SECOND WAY
        public static string questionTwoSplit(string givenString, int num)
        {
            if (num < 0)
            {
                return "You need a positive number to rotate";
            };
            if (givenString == "" || givenString == null)
            {
                return "you need to provide a string!";
            };
            num = num % givenString.Length;
            if (num == 0)
            {
                return givenString;
            };
            var splitLocation = givenString.Length - num;

            string answer = "";
            string[] stringArray;
            int second = givenString.Length - 1;
            stringArray = new string[] { givenString.Substring(0, splitLocation), givenString.Substring(splitLocation) };
            for (var x = stringArray.Length - 1; x >= 0; x--)
            {
                answer = answer + stringArray[x];
            };
            return answer;
        }
    }
}
