using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpdrachtTwee
{
    class Open : IQues
    {
        string quest;
        string answ;
        int difficulty;
        string categ;

        public string Quest { get => quest; set => quest = value; }
        public string Answ { get => answ; set => answ = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public string Categ { get => categ; set => categ = value; }

        public Boolean CheckAnswer(string answer)
        {
            return answer.Equals(answ);
        }

        public void ShowQues()
        {
            Console.WriteLine("\n" + quest);

            String ans = Console.ReadLine();

            if (CheckAnswer(ans))
            {
                Console.WriteLine("\nWell done");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("\nTry again...");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
    }
}
