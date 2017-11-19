
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace OpdrachtTwee
{
    class Program
    {
        static int[] difficultyLevels = new int[] { 1, 2, 3 };
        static string[] categories = new String[] { "History", "Kekistan", "Cats", "Politics", "Meaning of life" };
        static Controller controller = new Controller();

        static void Main(string[] args)
        {
            Console.WriteLine("Answer correctly according to: [A, B, C, D]\nWatch out for CAPS, Lower caps are for the lower classes ( ͡° ͜ʖ ͡°)\n");
            OpenOrMultiChoice();
            Console.ReadKey();
        }

        public static void OpenOrMultiChoice()
        {
            Console.WriteLine("Type 1 for open questions \nType 2 for multiple choice\n");
            string chosen = Console.ReadLine();

            if (chosen == "1")
            {
                FillOpen();
                controller.SetCategType("1");
                controller.ChooseMode();
            }
            else if (chosen == "2")
            {
                FillMultiChoice();
                controller.SetCategType("2");
                controller.ChooseMode();
            }
            else
            {
                Console.WriteLine("\nPraise Pepe, oh and, wrong answer....");
                Thread.Sleep(3000);
            }
        }

        public static void FillMultiChoice()
        {
            MultiChoice quest1 = new MultiChoice()
            {
                Quest = "Question: When did Kekistan exist and where was it located?\n",
                Answ = "A",
                Difficulty = 2,
                Categ = "History"
            };

            quest1.AddMultiChoice("A: 2300 B.P.(Before Pepe), to the north of Iran, to the east of Cuckistan and to the south/southeast of Normistan");
            quest1.AddMultiChoice("B: Modern ages, doesn't have a country(choose only if you're a fucking normie)");
            quest1.AddMultiChoice("C: Stone age, stone kek men");
            quest1.AddMultiChoice("D: Are you serious right now?");

            MultiChoice quest2 = new MultiChoice()
            {
                Quest = "Question: who is the lord and saviour of Kekistan?\n",
                Answ = "D",
                Difficulty = 3,
                Categ = "Kekistan"
            };

            quest2.AddMultiChoice("A: Pepe?");
            quest2.AddMultiChoice("B: Pepe!");
            quest2.AddMultiChoice("C: Pepe!!!1");
            quest2.AddMultiChoice("D: Pepe");

            MultiChoice quest3 = new MultiChoice()
            {
                Quest = "Question: meow?\n",
                Answ = "C",
                Difficulty = 1,
                Categ = "Cats"
            };

            quest3.AddMultiChoice("A: Buck Buck!");
            quest3.AddMultiChoice("B: Raff Raff");
            quest3.AddMultiChoice("C: Meow");
            quest3.AddMultiChoice("D: Gaaaaaaaaaaaaaaaaaaay");

            MultiChoice quest4 = new MultiChoice()
            {
                Quest = "Question: when did Kekistan get invaded?\n",
                Answ = "B",
                Difficulty = 3,
                Categ = "History"
            };

            quest4.AddMultiChoice("A: Circa 2300 B.P.");
            quest4.AddMultiChoice("B: Circa 2100 B.P.");
            quest4.AddMultiChoice("C: Circa 1120 B.P.");
            quest4.AddMultiChoice("D: 16 A.P.(After Pepe)");

            MultiChoice quest5 = new MultiChoice()
            {
                Quest = "Question: What is the national anthem of Kekistan called?\n",
                Answ = "B",
                Difficulty = 2,
                Categ = "Kekistan"
            };

            quest4.AddMultiChoice("A: Queen and Country");
            quest4.AddMultiChoice("B: Shadilay(My Brothers)");
            quest4.AddMultiChoice("C: Mawtini Mawtini");
            quest4.AddMultiChoice("D: I dunno lol");

            MultiChoice quest6 = new MultiChoice()
            {
                Quest = "Question: What do you call a mountain of kittens?\n",
                Answ = "C",
                Difficulty = 1,
                Categ = "Cats"
            };

            quest4.AddMultiChoice("A: A mountain of kittens");
            quest4.AddMultiChoice("B: Mount Everest");
            quest4.AddMultiChoice("C: Meowntain");
            quest4.AddMultiChoice("D: Mount Rushmore");

            controller.AddMultiChoiceQuest(quest1);
            controller.AddMultiChoiceQuest(quest2);
            controller.AddMultiChoiceQuest(quest3);
            controller.AddMultiChoiceQuest(quest4);
            controller.AddMultiChoiceQuest(quest5);
            controller.AddMultiChoiceQuest(quest6);
        }

        public static void FillOpen()
        {
            Open quest1 = new Open()
            {
                Quest = "Question: Which two candidates were prominent in the 2016 US election?",
                Answ = "Trump And Hillary",
                Difficulty = 1,
                Categ = "Politics"
            };

            Open quest2 = new Open()
            {
                Quest = "Question: What is the meaning of life?\n",
                Answ = "42",
                Difficulty = 3,
                Categ = "Meaning of life"
            };

            Open quest3 = new Open()
            {
                Quest = "Question: If con is the opposite of pro, then what is the opposite of Congress?\n",
                Answ = "Progress",
                Difficulty = 2,
                Categ = "Politics"
            };

            controller.AddOpenQuest(quest1);
            controller.AddOpenQuest(quest2);
            controller.AddOpenQuest(quest3);
        }
    }
}
