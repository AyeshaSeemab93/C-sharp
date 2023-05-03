using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class Program


    public static void Main(string[] args)
    {

        List<string> words = new List<string>();
        Console.WriteLine("Plase tell word: ");
        string word = Console.ReadLine();
        words.Add(word);
        // checked palindrome
    }
    public bool IsPalindrome()
    {
        int length = word.Length;
        int end = word.Length - 1; /*index start from zero so total index will be length-1*/
        for (int i = 0; i < length / 2; i++) /*word.Length/2 bec check until half word*/
        {
            if (word[i] != word[end - i]) /*1 alphabet forward from start and 1- from end*/
            {
                return false;
            }

        }
        return true;
    }
}
