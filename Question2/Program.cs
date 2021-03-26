﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        // Question 2:
        // Find every position in an input string where a letter is succeeded by itself
        // Please note that space is not a letter, each time a duplicated letter is found, write this letter plus it's position into the duplicate list
        
        /*
         * Example if data is "letter" position of t is 3 and value is tt
        */
            
        // NOTE: Please include comments in your code
        
        static void Main(string[] args)
        {
            const string data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commmodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            var duplicates = GetDuplicatedCharacters(data);
            //add this to see output
            foreach (var item in duplicates)
            {
                Console.WriteLine(item.DuplicatedLetter +" "+item.DuplicatedPosition);
            }
            Console.ReadKey();
        }

        private static List<StringPosition> GetDuplicatedCharacters(string data)
        {
            // Write your code here
            // throw new NotImplementedException();
            //calls builder CreateDuplicateCheck
            var StrPostion = new StringPositionCreator( new StringPositionBuilder());
            var list = StrPostion.CreateDuplicateCheck(data);
            return list;
        }
    }
}
