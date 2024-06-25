using System;

namespace PigLatinGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //error handling
            try
            {
                Console.WriteLine("----------Pig Latin Generator----------");
            Console.Write("Enter your sentence: ");
            string sUserSentence = Console.ReadLine();
            string[] wordsToConvert = sUserSentence.ToLower().Split(' ');

            for (int i = 0; i< wordsToConvert.Length;i++) 
            {
                //check if word starts with a vowel
                if (wordsToConvert[i].StartsWith('a') || wordsToConvert[i].StartsWith('e') || wordsToConvert[i].StartsWith('i') || wordsToConvert[i].StartsWith('o') || wordsToConvert[i].StartsWith('u'))
                {
                    //add way to the end of the word
                    wordsToConvert[i] = wordsToConvert[i] + "way";
                }
                else
                {
                    string sWord = wordsToConvert[i];
                    char cFirstLetter = sWord[0];//get first letter of word
                    string sTrimmmedWord = sWord.Remove(0, 1);//remove first letter from word
                    wordsToConvert[i] = sTrimmmedWord + cFirstLetter + "ay";//add last letter and 'ay'
                }
            }

            //display the pig latin sentence
            Console.Write("Your sentence in pig latin: ");
            foreach (string word in wordsToConvert)
            {
                Console.Write(word + ' ');
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }//Try catch
        }//Main()
    }
}
