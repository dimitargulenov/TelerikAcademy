// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            //Having fun :D
            Console.WriteLine("Hello! Would you be so much very kind enough to input your year of birth? \n I promise not to turn it against you. \n Trust me? \n Fine, put it right about here (YYYY/MM/DD):");

            DateTime input = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;

            int age = today.Year - input.Year;
            if (input > today.AddYears(-age)) age--;
            int ageTen = age + 10;

            Console.WriteLine("This was fun, isn't? \n OK now, let me check how old are you... \n Calculating... \n Calculating... \n Still calculating... \n Well this took some time now didn't it... \n STILL CALCULATING... \n There - {0} \n Oh my, you are mega old, like MEGA old! You know what's worst though? After 10 years you'll be GIGA old. Something like ~{1} years old. It's hard to say exact number, since this program is not powerful enough to calculate it (or you're just too old, which is the most likely scenario). Sorry about that. We accept donations though, so we can get kick-ass ultra setup with quad CrossFire and dual Opterons. \n No, it wont be used to make a more powerful program, I just love to play games :D Powerful programs can be made on less powerful machines. \n Anyway, look at the bright side. \n Yes, there is a bright side, as hard it is to believe. \n Thanks to this very program your life was extended with another ~10 years for free. \n Don't believe me? \n Look above, I've already told you (approximately) how old you're going to be. \n Have a nice life :D", age, ageTen);                 
        } 
    }

