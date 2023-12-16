using System;

    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number you want to check:");
            int EnteredNumber = int.Parse(Console.ReadLine());
            
            CheckPalindrome(EnteredNumber);
           
        }
        
            public static void CheckPalindrome(int number)
            {
                int InitialNumber = number;
                int reversed = 0;

                while (number > 0)
                {
                    int digit = number % 10;
                    reversed = (reversed * 10) + digit;
                    number /= 10;
                }
                if(InitialNumber == reversed)
                {
                    Console.WriteLine("{0} is a palindrome ", InitialNumber);
                }
                else
                {
            Console.WriteLine("{0} is not a palindrome, ", InitialNumber);
                }
            }
        }
    
