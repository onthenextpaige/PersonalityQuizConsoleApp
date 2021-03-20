using System;
using System.Collections;
using System.Threading;

namespace PersonalityQuizConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            int babka = 0;
            int bran = 0;
            int ladyGrey = 0;
            int cocoa = 0;
            int milliseconds = 500;
            string answer;
            var typeDescriptions = new Hashtable()
            {
                {"Babka", "You're a kind-hearted soul with a rosy lens on the world (and the couch.) You're affectionate with your loved ones, and tasty morsels are often your love language. Your main goal in life is more couch time." },
                {"Bran", "You're a go-getter who isn't afraid to be the center of attention. Your favorite holiday is probably Halloween because you love doing tricks for treats (not in a weird way). Your mantra is \"nap hard, play hard.\"" },
                {"Lady Grey", "You're smart and scrappy and love to voice your opinion. Speaking of which, these opinions might be strong and come at inconvenient times of day for those around you. Only those you trust most ever see you in your happy place: snoozing belly-up style." },
                {"Cocoa", "You're curious by nature and love to learn about the world around you. Good weather brings out your playful side, but most days, you're probably avoiding most forms of social contact. Snack foods are your one true love." }
            };

            //set up "please answer" method
            void pleaseAnswer()
            {
                Console.WriteLine("\nPlease answer a, b, c, or d:");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            }
            
            //set up scoring method
            void scoreAnswer()
            {
                if (answer == "a") babka++;
                else if (answer == "b") bran++;
                else if (answer == "c") ladyGrey++;
                else if (answer == "d") cocoa++;
                else do
                    {
                        Console.WriteLine("Does not compute. Please answer a, b, c, or d: ");
                        answer = Console.ReadLine();
                        answer = answer.ToLower();
                    } while (answer != "a" && answer != "b" && answer != "c" && answer != "d");
            }

            //quiz questions
            Console.WriteLine("Welcome! You're about to take a very scientific personality quiz. Get ready!");
            Thread.Sleep(milliseconds);
            Thread.Sleep(milliseconds);
            Console.WriteLine("\n1. When your friend has a problem, your instinct is to:\n(a) Find a creative way to brighten their day\n(b) Help them see the bigger picture\n(c) Grab a drink and talk it out\n(d) Get all the details to help solve the problem");
            pleaseAnswer();
            scoreAnswer();
            Console.WriteLine("\n2. Where are you most likely to be found at a party?\n(a) Taking in the scene, wallflower-style\n(b) Dancing or chatting with everyone in the room\n(c) Serving up tasty drinks to your besties\n(d) Leaving it");
            pleaseAnswer();
            scoreAnswer();
            Console.WriteLine("\n3. When something really amuses you, you react with:\n(a) A quiet chuckle\n(b) Slapping your knees and snorting\n(c) A big laugh\n(d) A sheepish smile");
            pleaseAnswer();
            scoreAnswer();
            Console.WriteLine("\n4. Which extracurriculars did you do in school?\n(a) Volunteer work\n(b) Theater\n(c) Sports\n(d) Debate or book club");
            pleaseAnswer();
            scoreAnswer();
            Console.WriteLine("\n5. Your dream home would feature:\n(a) A home theater, featuring a popcorn machine\n(b) A hot tub or claw foot bath with views to the surrounding countryside\n(c) A decked-out luxury kitchen\n(d) A pool");
            pleaseAnswer();
            scoreAnswer();
            Console.WriteLine("\nCalculating your results...");
            Thread.Sleep(milliseconds);
            Console.WriteLine("...");
            Thread.Sleep(milliseconds);
            Console.WriteLine("...");
            Thread.Sleep(milliseconds);

            //who's the winner? calculate and display result
            if (babka >= bran && babka >= ladyGrey && babka >= cocoa)
            {
                Console.WriteLine("You are BABKA!");
                Console.WriteLine(typeDescriptions["Babka"]);
            }
            else if (bran >= ladyGrey && bran >= cocoa)
            {
                Console.WriteLine("You are BRAN!");
                Console.WriteLine(typeDescriptions["Bran"]);
            }
            else if (ladyGrey >= cocoa)
            {
                Console.WriteLine("You are LADY GREY!");
                Console.WriteLine(typeDescriptions["Lady Grey"]);
            }
            else
            {
                Console.WriteLine("You are COCOA!");
                Console.WriteLine(typeDescriptions["Cocoa"]);
            }
        }
    }
}
