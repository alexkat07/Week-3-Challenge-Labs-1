using System.Security.Cryptography.X509Certificates;

namespace Week_3_Challenge_Labs_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome: ");
            string myWord = Console.ReadLine();
            Console.WriteLine(IsPalindrome(myWord));


            static string IsPalindrome(string userInput) 
            {
               int L = 0;
                int R = userInput.Length - 1;
                while (L < R) 
                {
                    if (userInput[L] != userInput[R])
                    {
                        return $"{userInput} is not a palindrome.";
                    }
                    else 
                    {
                        L++;
                        R--;
                    }
                    
                }
                return $"{userInput} is a palindrome.";
            }
        }
    }
}
