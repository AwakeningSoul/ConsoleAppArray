﻿using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of string
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                //Add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that selection is invalid. Please select a number between 0 and 9. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //List of strings
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast Host",
                "Software Developer",
                "QA Tester"
            };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                // Add a message to display if the user picks and index that doesnt't exist
                catch
                {
                    Console.WriteLine("Sorry, ThreadStaticAttribute number is InvalidCastException. Select a number between 0 and 9. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
    

