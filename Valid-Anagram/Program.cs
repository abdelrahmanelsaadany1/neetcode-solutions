using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length !=t.Length ) return false;
                Dictionary<char,int> D = new Dictionary<char,int>();
                foreach (char letter in s)
                {
                    if (D.ContainsKey(letter))
                    {
                        D[letter] += 1;

                        
                    }
                    else
                    {
                        D[letter] = 1;
                    }
                }
                foreach (var letter in t)
                {
                    if (D.ContainsKey(letter))
                    {
                        D[letter]--;
                    }
                    else
                    {
                        D[letter]=1;
                    }
                    
                }
                foreach (var Value in D.Values)
                {
                    if (Value !=0)
                    {
                        return false;
                        
                    }

                }
                return true;




            }
        }

    }
}
