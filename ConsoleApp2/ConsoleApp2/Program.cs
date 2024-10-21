using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int gueses;
            string response;

            while(playAgain){
                guess  = 0;
                gueses = 0;
                response = "";
                number = random.Next(min,max+1);
                while (guess !=number) {
                 Console.WriteLine("Guess a Number between "+min+" "+max+" : ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number) {
                        Console.WriteLine(guess + " is too High!!");
                    }
                    else if (guess < number ) {
                        Console.WriteLine(guess+" is too Low!!");
                    }
                    gueses++;
                
                }
                Console.WriteLine("Number: "+number);
                Console.WriteLine("You Win!!!");
                Console.WriteLine("Guesse : "+gueses);
                
                Console.WriteLine("Would you Like to play Again!! (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thank You for playing .. I guess");
            Console.ReadKey();
        }
    }
}
