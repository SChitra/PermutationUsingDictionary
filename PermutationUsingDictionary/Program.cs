using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationUsingDictionary
{
    class Program
    {
        //Given two strings, write a method to decide if one is a permutation of the other? 
        public static bool IsPermutation(string str1,string str2)
        {
            ////Check lenght of the string to see if they are not same then they cannot be permutation
            if (str1.Length != str2.Length)
            {
                return false;
            }
            //Create a dictionary and store the characters of string1
            var StringDictionary =   new Dictionary<char, int>();
            foreach(char character in str1)
            {
                if (StringDictionary.ContainsKey(character))
                    StringDictionary[character] = 2;
                else
                    StringDictionary.Add(character, 1);
            }
            //Check the dictionary to see if the character in string2 already exists in string1, if it is in the dictionary then remove it from the dictionary
            foreach(char character in str2)
            {
                if (StringDictionary.ContainsKey(character))
                    StringDictionary.Remove(character);
            }
            if (StringDictionary.Count == 0)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            string s1 = "dap";
            string s2 = "add";
            var result = IsPermutation(s1, s2);
            if (result == true)
                Console.WriteLine("String 1 is permutation of String 2 ");
            else
                Console.WriteLine("String 1 is not permutation of String 2");
        }
    }
}
