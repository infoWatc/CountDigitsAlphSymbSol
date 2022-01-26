/*
    Write a program in C# Sharp to count a total number of 
    alphabets, digits and special characters in a string.
*/
using System;

namespace CountDigitsAlphSymbProj
{
    class Program
    {
        static void Main()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string special = " `~!@#$%^&*()_+,./\\;:\"[]{}|<>?'";
            string words = "Welcome to w3resource.com";
           
            int alphaCount = 0;
            int numbersCount = 0;
            int specialCount = 0;

            foreach (char character in words)
            {
                for (int i = 0; i < alphabet.Length -1 ; i++)
                {
                    if (character == alphabet[i]) alphaCount++; 
                }
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (character == numbers[i]) numbersCount++;
                }
                for (int i = 0; i < special.Length - 1; i++)
                {
                    if (character == special[i]) specialCount++;
                }
            }
          
            Console.WriteLine($"Statistics of the string; number of:\n\n\tAlphabetic characters: {alphaCount}\n\tDigits: {numbersCount}\n\tSpecial characters: {specialCount}");

        }
    }
}
