using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/*
 * Welcome to Disva's Code College, Zovael!
 * Here, Disva will teach you all about coding!
 * From Git to C# to design patterns, you'll learn it all!
 * Using the handy dandy C# yellow book as reference, follow along!
 */


namespace ZovPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * A)
             * Make a program that asks a user for 2 numbers, then adds them and prints the value.
            Console.WriteLine("P L E A S E");
            Thread.Sleep(1000);
            Console.WriteLine("I N S E R T");
            Thread.Sleep(1000);
            Console.WriteLine("T W O ( 2 )");
            Thread.Sleep(1000);
            Console.WriteLine("////");
            Thread.Sleep(1000);
            Console.Write("[inte");
            Thread.Sleep(1000);
            Console.WriteLine("ger]");
            Thread.Sleep(1000);
            Console.WriteLine("T O");
            Thread.Sleep(1000);
            Console.WriteLine("T H E");
            Thread.Sleep(1000);
            Console.WriteLine("G R I N D E R");
            string NumberOneText = Console.ReadLine();
            int NumberOne = int.Parse(NumberOneText);
            Console.WriteLine("First number inserted. Thank you for your co-operation.");
            string NumberTwoText = Console.ReadLine();
            int NumberTwo = int.Parse(NumberTwoText);
            Console.WriteLine("Second number inserted. Thank you for your co-operation.");
            Thread.Sleep(1000);
            Console.WriteLine("G R I N D I N G . . .");
            Thread.Sleep(1000);
            Console.WriteLine("G R I N D I N G . . .");
            Thread.Sleep(1000);
            Console.WriteLine("G R I N D I N G . . .");
            int SumOfOnePlusTwo = (NumberOne + NumberTwo);
            Thread.Sleep(2000);
            Console.WriteLine("W E");
            Thread.Sleep(1000);
            Console.WriteLine("H A V E");
            Thread.Sleep(1000);
            Console.WriteLine("B E E N");
            Thread.Sleep(1000);
            Console.WriteLine("S A T E D");
            Thread.Sleep(1000);
            Console.WriteLine("////");
            Thread.Sleep(1000);
            Console.WriteLine("Thank you for your assistance. Your result is: " + SumOfOnePlusTwo);
            Thread.Sleep(5000);

            Environment.Exit(0); 

            [DISVA]: A+!
            Part A is complete!
             */

            /*
             * B)
             * Make a program that asks a user for 2 numbers, then prints the larger one */
            int SmolD = 2000;
            int LargD = 4500;
            Console.Write("You're awoken by a sudden and sharp noise from within your ears, akin to the hard friction of a great mass of metals. ");
            Thread.Sleep(SmolD);
            Console.WriteLine("It's an unnerving and disorienting awakening, to be sure. ");
            Thread.Sleep(LargD);
            Console.WriteLine();
            Console.Write("You feel nothing at first, but your senses return soon; at least, in part. ");
            Thread.Sleep(SmolD);
            Console.Write("Your visibility is poor; in the darkness you can't make out anything. ");
            Thread.Sleep(SmolD);
            Console.Write("Yet, you feel restraints against yourself. ");
            Thread.Sleep(SmolD);
            Console.Write("You can't feel below your waist, but you can feel cold metal wrapping around your belly and chest. ");
            Thread.Sleep(SmolD);
            Console.Write("You can't turn your head, and you can't even try to make a sound; as if your vocal cords are missing. ");
            Thread.Sleep(SmolD);
            Console.WriteLine("As feeling begins to return, you realize you only have one arm: it's a robotic limb, protruding out from the center of your chest.");
            Thread.Sleep(LargD);
            Console.WriteLine();
            Console.Write("Then, a flash of light, emitting from your forehead. ");
            Thread.Sleep(SmolD);
            Console.WriteLine("As though you're wearing a headlamp, the area before you is illuminated, revealing a large number panel...");
            Thread.Sleep(SmolD);
            Console.WriteLine("...and beyond it, a garguantuan steel skull, easily twice your body's size if not larger.");
            Thread.Sleep(SmolD);
            Console.WriteLine();
            Thread.Sleep(LargD);
            Console.WriteLine();
            Console.WriteLine("The skull was adorned with mangled claws and teeth, those bits visibly bolted and screwed onto it in an almost makeshift, DIY fashion, without any semblance of patterns or symmetry.");
            Thread.Sleep(LargD);
            Console.WriteLine("Suddenly the skeletal abberation's jaw seemed to unhinge at one side, dropping to the ground with a loud clank.");
            Thread.Sleep(SmolD);
            Console.WriteLine("From deep within the construct's open maw called out an oddly soft, female robotic voice; it was grainy, as if it were emitting from a speaker in disrepair.");
            Thread.Sleep(LargD);
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(SmolD);
                Random random = new Random();
                string SelectedGroup = "";
                int rng = random.Next(0, 2);
                if (rng == 0)
                    { SelectedGroup = "Azazel"; }
                if (rng == 1)
                    { SelectedGroup = "Baphomet"; }
                if (rng == 2)
                    { SelectedGroup = "Caim"; }
            Console.WriteLine("\"We will be conducting a diagnostic trial to cross-evaluate the capacity of your mental functioning. You are designated as part of Specimen Control Group {0}.\"", SelectedGroup);
            Thread.Sleep(LargD);
            Console.WriteLine("\"Please answer the following queries within the given parameters.\"");
            Thread.Sleep(SmolD);
            Console.WriteLine("\"Successful completion of these trials will result in your return to sleep.\"");
            Thread.Sleep(SmolD);
            Console.WriteLine("\"Failure to comply with expected parameters will result in immediate termination.\"");
            Thread.Sleep(SmolD);
            Console.WriteLine();
            bool Failure = false;
            while (Failure == false)
            {

                Console.Write("First Number: ");
                string Num1Txt = Console.ReadLine();
                int Num1;
                bool ParseAttempt = true;
                ParseAttempt = int.TryParse(Num1Txt, out Num1);
                if (ParseAttempt == false)
                {
                    Failure = true;
                }
                Console.WriteLine();
                Console.Write("Second Number: ");
                string Num2Txt = Console.ReadLine();
                int Num2;
                ParseAttempt = int.TryParse(Num2Txt, out Num2);
                if (ParseAttempt == false)
                {
                    Failure = true;
                }

                if (Num1 > Num2)
                {
                    Console.WriteLine("Valid input. The surviving specimen will be #" + Num1);
                }
                if (Num2 > Num1)
                {
                    Console.WriteLine("Valid input. The surviving specimen will be #" + Num2);
                }
                if (Num1 == Num2)
                {
                    Failure = true;
                }



                Console.WriteLine("Phase one complete. Initializing phase two.");
                Console.ReadLine();

            /* C)
            * Make a program that asks a user for 2 numbers, then divides them and prints the answer, but checks to make sure it isn't dividing by zero. */
                Console.WriteLine("Insert Num3");
                string Num3Txt = Console.ReadLine();
                double Num3 = int.Parse(Num3Txt);
                Console.WriteLine("Num3 = " + Num3);
                Console.WriteLine("Insert Num4");
                string Num4Txt = Console.ReadLine();
                double Num4 = int.Parse(Num4Txt);
                Console.WriteLine("Num4 = " + Num4);

                double Sum = 0;

                if (Num4 <= 0)
                {
                    Console.WriteLine("Invalid division.");
                    Console.WriteLine("You have failed the trial.");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else Sum = (Num3 / Num4);

                {
                    Math.Round(Sum, 3);
                    Console.WriteLine("The result is " + Sum);
                }

                Console.WriteLine("Phase two complete. Initializing the final phase.");
                Console.ReadLine();


            /* D)
            * Make a program that takes two names and two ages, and does the following:
            * If the names are the same, and the ages are within 5 years of each other: Print "How neat!"
            * If the ages are within 2 years of each other: Print: "They might know each other!" BUT
            * If the ages are the same: Print: "They probably know each other well!" instead
            * If the ages and names are the same: Print: "Uh oh, how confusing!" instead of anything else
            * If the names are not the same, and the ages are further than 2 years apart: Print: "They probably don't know each other" instead of anything else
            */

                Console.WriteLine("Insert Name1");
                string Name1 = Console.ReadLine();
                Console.WriteLine("Name1 = " + Name1);
                Console.WriteLine("Insert Age1");
                string Age1Txt = Console.ReadLine();
                int Age1 = int.Parse(Age1Txt);
                Console.WriteLine("Age1 = " + Age1);

                Console.WriteLine("Insert Name2");
                string Name2 = Console.ReadLine();
                Console.WriteLine("Name2 = " + Name2);
                Console.WriteLine("Insert Age2");
                string Age2Txt = Console.ReadLine();
                int Age2 = int.Parse(Age2Txt);
                Console.WriteLine("Age2 = " + Age2);

                if ((Name1 == Name2) && (Age1 >= (Age2 - 5)) && (Age1 <= (Age2 + 5)))
                {
                    Console.WriteLine("How neat!");
                }
                if (Age1 >= (Age2 - 2) && Age1 <= (Age2 + 2))
                {
                    Console.WriteLine("They might know each other!");
                }
                if (Age1 == Age2)
                {
                    Console.WriteLine("They probably know each other well!");
                }
                if ((Name1 == Name2) && (Age1 == Age2))
                {
                    Console.WriteLine("Uh oh, how confusing!");
                }
                else
                {
                    Console.WriteLine("They probably don't know each other.");
                }
                Console.ReadLine();
            }
            if (Failure == true)
                {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The construct's jaw hits the ground with a loud clank one last time, and that female robotic voice rang out in a much sharper tone, clearly angered.");
                Console.WriteLine("\"You have failed to answer within expected parameters.\"");
                Console.WriteLine("\"You will now be terminated.\"");
                Console.WriteLine("With a painfully loud blast akin to a cannon's shot, a great obsidian pillar burst out from the depths of the construct's unhinged maw like a mechanical tongue, impaling through your skull and decapitating you in the process.");
                Console.ReadLine();
                Environment.Exit(0);
                }

        }
    }
}
