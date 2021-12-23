using System;

namespace NewRandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string upChars = "'QWERTASDFGZXCVBYUIOPHJKLNM";
            string loChars = upChars.ToLower();
            string nuChars = "7410258963";
            string spChars = "!@#$%^&*()=+?><";

            Console.WriteLine("How long would you like the password to be?");
            Int32 length = int.Parse(Console.ReadLine());

            string tempPasswordHolder = "";
            Int32 Counter = 0;
            while(Counter < length)
            {
                Int32 uCharIndex = random.Next(25);
                Int32 lCharIndex = random.Next(25);
                Int32 numberIndex = random.Next(8);
                Int32 spCharIndex = random.Next(14);

                Char tuch = upChars[uCharIndex];
                Char tlch = loChars[lCharIndex];
                Char tnch = nuChars[numberIndex];
                Char tsch = spChars[spCharIndex];

                String chosenChars = "";
                chosenChars += tuch;
                chosenChars += tlch;
                chosenChars += tnch;
                chosenChars += tsch;
                    
                Int32 finalCharIndex = random.Next(4);
                Char finalSeclectChar = chosenChars[finalCharIndex];
                tempPasswordHolder += finalSeclectChar;
               
                Counter++;
            }
            Console.WriteLine(tempPasswordHolder);
        }
    }
}