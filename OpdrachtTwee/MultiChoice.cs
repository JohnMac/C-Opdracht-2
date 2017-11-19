using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpdrachtTwee
{
    class MultiChoice : IQues
    {
        string quest;
        string answ;
        int difficulty;
        string categ;

        public string Quest { get => quest; set => quest = value; }
        public string Answ { get => answ; set => answ = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public string Categ { get => categ; set => categ = value; }

        IList<string> choices = new List<string>();

        public Boolean CheckAnswer(string answer)
        {
            return answer.Equals(Answ);
        }

        public void ShowQues()
        {
            Console.WriteLine("\n" + Quest);

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(choices[i]);
            }

            String answer = Console.ReadLine();

            if (CheckAnswer(answer))
            {
                Console.WriteLine("\nWell done");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("\nTry again..");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }

        public void AddMultiChoice(String choice)
        {
            choices.Add(choice);
        }
    }
}
