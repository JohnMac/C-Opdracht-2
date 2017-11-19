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
                Ques = "Vraag: Hoeveel poten heeft een normale hond?\n",
                Ans = "A",
                Grade = 1,
                Category = "Dier"
            };

            quest1.AddKeuzen("A: 4");
            quest1.AddKeuzen("B: 2");
            quest1.AddKeuzen("C: 5");
            quest1.AddKeuzen("D: Geen");

            MultiVraag v2 = new MultiVraag()
            {
                Ques = "Vraag: Noem een Japans auto merk\n",
                Ans = "D",
                Grade = 3,
                Category = "Auto"
            };

            v2.AddKeuzen("A: BMW");
            v2.AddKeuzen("B: Mercedus");
            v2.AddKeuzen("C: Volkswagen");
            v2.AddKeuzen("D: Honda");

            MultiVraag v3 = new MultiVraag()
            {
                Ques = "Vraag: 1+1=\n",
                Ans = "D",
                Grade = 2,
                Category = "Wiskunde"
            };

            v3.AddKeuzen("A: 1.1");
            v3.AddKeuzen("B: 11");
            v3.AddKeuzen("C: 10");
            v3.AddKeuzen("D: 2");

            MultiVraag v4 = new MultiVraag()
            {
                Ques = "Hoeveel magen heeft een koe?\n",
                Ans = "C",
                Grade = 2,
                Category = "Dier"
            };

            v4.AddKeuzen("A: 1");
            v4.AddKeuzen("B: 2");
            v4.AddKeuzen("C: 4");
            v4.AddKeuzen("D: Geen");

            controller.AddMultiChoiceQuest(quest1);
            controller.AddMultiChoiceQuest(v2);
            controller.AddMultiChoiceQuest(v3);
            controller.AddMultiChoiceQuest(v4);
        }

        public static void FillOpen()
        {
            OpenVraag v1 = new OpenVraag()
            {
                Ques = "Hoeveel 9's zitter en tussen 1 en 100?",
                Ans = "20",
                Grade = 1,
                Category = "Wiskunde"
            };

            OpenVraag v2 = new OpenVraag()
            {
                Ques = "Wat is de eerste automerk?\n",
                Ans = "Benz",
                Grade = 2,
                Category = "Auto"
            };

            OpenVraag v3 = new OpenVraag()
            {
                Ques = "Wat is de grootste dier ter wereld?\n",
                Ans = "Blauwe Vinvis",
                Grade = 3,
                Category = "Dier"
            };

            controller.AddOpenQuest(v1);
            controller.AddOpenQuest(v2);
            controller.AddOpenQuest(v3);
        }
    }
}
