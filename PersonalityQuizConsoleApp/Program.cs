using System;
using System.Collections.Generic;
using System.Threading;

namespace PersonalityQuizConsoleApp
{
   //this console app is a simple personality quiz
   //users will be prompted to answer five multiple-choice questions
   //their answers will be tallied to assign them one of four personality types
   
    public class Program
    {
        //this is the variable for user's answer input and validation
        public static string answer;
        //these variables represent the "personality types" and will tally up the score as the user progresses through the quiz
        //they are set to zero so that each type starts out with zero points; the type with the most points at the end is the winner
        public static int babkaScore = 0;
        public static int branScore = 0;
        public static int ladyGreyScore = 0;
        public static int cocoaScore = 0;

        //this method will collect the user's answers and validate them
        public static void InputAnswer()
        {
            Console.WriteLine("\nPlease answer a, b, c, or d:");
            answer = Console.ReadLine();
            answer = answer.ToLower();
            while (answer != "a" && answer != "b" && answer != "c" && answer != "d")
            {
                Console.WriteLine("Does not compute. Please answer a, b, c, or d: ");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            }
        }
        
        //adds a point to the corresponding personality type based on the answer
        public static void ScoreAnswer()
        {
            if (answer == "a")
            { babkaScore++; }
            else if (answer == "b")
            { branScore++; }
            else if (answer == "c")
            { ladyGreyScore++; }
            else if (answer == "d")
            { cocoaScore++; }
        }
        
        public static void Main(string[] args)
        {
            //this variable will help implement a pause just for fun
            int pauseTime = 500;
            //this dictionary stores the personality types and decriptions to be called up when the type is calculated
            var typeDescriptions = new Dictionary<string, string>()
            {
                {"Babka", "You're a kind-hearted soul with a rosy lens on the world (and the couch.) You're affectionate with your loved ones, and tasty morsels are often your love language. Your main goal in life is more couch time." },
                {"Bran", "You're a go-getter who isn't afraid to be the center of attention. Your favorite holiday is probably Halloween because you love doing tricks for treats (not in a weird way). Your mantra is \"nap hard, play hard.\"" },
                {"Lady Grey", "You're smart and scrappy and love to voice your opinion. Speaking of which, these opinions might be strong and come at inconvenient times of day for those around you. Only those you trust most ever see you in your happy place: snoozing belly-up style." },
                {"Cocoa", "You're curious by nature and love to learn about the world around you. Good weather brings out your playful side, but most days, you're probably avoiding most forms of social contact. Snack foods are your one true love." }
            };
            
            //quiz questions
            Console.WriteLine("Welcome! You're about to take a very scientific personality quiz. Get ready!");
            Thread.Sleep(pauseTime);
            Thread.Sleep(pauseTime);
            Console.WriteLine("\n1. When your friend has a problem, your instinct is to:\n(a) Find a creative way to brighten their day\n(b) Help them see the bigger picture\n(c) Grab a drink and talk it out\n(d) Get all the details to help solve the problem");
            InputAnswer();
            ScoreAnswer();
            Console.WriteLine("\n2. Where are you most likely to be found at a party?\n(a) Taking in the scene, wallflower-style\n(b) Dancing or chatting with everyone in the room\n(c) Serving up tasty drinks to your besties\n(d) Leaving it");
            InputAnswer();
            ScoreAnswer();
            Console.WriteLine("\n3. When something really amuses you, you react with:\n(a) A quiet chuckle\n(b) Slapping your knees and snorting\n(c) A big laugh\n(d) A sheepish smile");
            InputAnswer();
            ScoreAnswer();
            Console.WriteLine("\n4. Which extracurriculars did you do in school?\n(a) Volunteer work\n(b) Theater\n(c) Sports\n(d) Debate or book club");
            InputAnswer();
            ScoreAnswer();
            Console.WriteLine("\n5. Your dream home would feature:\n(a) A home theater, featuring a popcorn machine\n(b) A hot tub or claw foot bath with views to the surrounding countryside\n(c) A decked-out luxury kitchen\n(d) A pool");
            InputAnswer();
            ScoreAnswer();
            Console.WriteLine("\nCalculating your results...");
            Thread.Sleep(pauseTime);
            Console.WriteLine("...");
            Thread.Sleep(pauseTime);
            Console.WriteLine("...");
            Thread.Sleep(pauseTime);

            //who's the winner? calculate and display result
            if (babkaScore >= branScore && babkaScore >= ladyGreyScore && babkaScore >= cocoaScore)
            {
                Console.WriteLine("You are BABKA!");
                Console.WriteLine(typeDescriptions["Babka"]);
            }
            else if (branScore >= ladyGreyScore && branScore >= cocoaScore)
            {
                Console.WriteLine("You are BRAN!");
                Console.WriteLine(typeDescriptions["Bran"]);
            }
            else if (ladyGreyScore >= cocoaScore)
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
