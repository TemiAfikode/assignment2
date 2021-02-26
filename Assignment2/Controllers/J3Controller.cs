using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController 
    { [HttpGet]
    [Route("api/J3/wordformation/{word}")]
        public string Get(string word)
    {
            //Initialize a list for the new word
            List<char> result = new List<char>();
            
            
            char[] alphabets = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //For loop
            for(int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                //Check if letter is consonant using an if statement
                if (consonants.Contains(letter))
                {
                  //Add the consonant to the list
                    result.Add(letter);
                    //Get index of the consonant in the alphabets
                    int position = Array.IndexOf(alphabets, letter);
                    int preVowelPosition = -1;
                    char preVowel = char.MinValue;
                    int postVowelPosition = -1;
                    char postVowel = char.MinValue;

                    //Loop backwards to get the vowel before the consonant
                    //TODO:Code
                    //Loop to get the vowel after the consonant
                    //TODO:Code
                    //Determine which vowel is closer to the consonant and add the closer one to the result
                    //Get the index of the letter in the consonants
                    int posInConsonant = Array.IndexOf(consonants, letter);
                    //Using an if statement to check
                    if(posInConsonant<consonants.Length - 1)
                    {
                        result.Add(consonants[posInConsonant + 1]);
                    }
                    else
                    {
                        //if the letter is a vowel, add it to the list of the character
                        result.Add(letter);
                    }
                }
            }
            
            return string.Join("",result);
    }

    }
}
