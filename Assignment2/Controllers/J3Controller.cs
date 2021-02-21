using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController 
    { 
        public string Get(string word)
    {
            List<char> result = new List<char>();
            
            
            char[] alphabets = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            
            for(int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (consonants.Contains(letter))
                {
                    result.Add(letter);
                    int position = Array.IndexOf(alphabets, letter);
                }
            }
            
            return "";
    }

    }
}
