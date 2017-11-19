using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace OpdrachtTwee
{
    class Controller
    {
        public List<MultiChoice> multiChoiceQuestions = new List<MultiChoice>();
        public List<Open> openQuest = new List<Open>();

        int[] difficultyLevels = new int[] { 1, 2, 3 };
        string[] categories = new String[] { "History", "Kekistan", "Cats", "Politics" };

        int diffic;
        int category;
        string categType;

        public void SetCategType(String categType)
        {
            this.categType = categType;
        }

        public void AddMultiChoiceQuest(MultiChoice mCQuest)
        {
            multiChoiceQuestions.Add(mCQuest);
        }

        public void AddOpenQuest(Open oQuest)
        {
            openQuest.Add(oQuest);
        }

        public void ChooseMode()
        {
            Console.WriteLine("\nType 1 to change difficulty or select a category \nType 2 to sort questions based on difficulty " +
                "\nType 3 to sort questions based on categories");

            string chosen = Console.ReadLine();

            if (chosen == "1")
            {
                Console.Clear();
                Choose();
            }
            else if (chosen == "2")
            {
                Console.Clear();
                OrderByGrade();
            }
            else if (chosen == "3")
            {
                Console.Clear();
                OrderByCategory();
            }
            else
            {
                Console.WriteLine("\nNice meme....");
                Thread.Sleep(1000);
            }
        }

        public void Choose()
        {
            Console.WriteLine("\nType 1 to choose a difficulty \nType 2 to choose a category");
            string chosen = Console.ReadLine();

            if (chosen == "1")
            {
                Console.Write("\nChoose difficulty: \n");

                for (int i = 0; i < difficultyLevels.Length; i++)
                {
                    Console.WriteLine(difficultyLevels[i]);
                }
                diffic = Convert.ToInt32(Console.ReadLine());
                SelectDifficulty();
            }

            else if (chosen == "2")
            {
                Console.WriteLine("\nChoose category: \n");

                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine(i + 1 + ": " + categories[i]);
                }
                category = Convert.ToInt32(Console.ReadLine());
                SelectCategory();
            }
            else Console.WriteLine("Memelord strikes again...");
        }

        public void SelectCategory()
        {
            if (categType == "1")
            {
                IEnumerable<Open> categQuery = from question in openQuest where question.Categ == categories[category - 1] select question;
                foreach (Open question in categQuery)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            else if (categType == "2")
            {
                IEnumerable<MultiChoice> categQuery = from question in multiChoiceQuestions where question.Categ == categories[category - 1] select question;
                foreach (MultiChoice question in categQuery)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            Done();
        }

        public void SelectDifficulty()
        {
            if (categType == "1")
            {
                IEnumerable<Open> categQuery = from question in openQuest where question.Difficulty == diffic select question;
                foreach (Open question in categQuery)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            else if (categType == "2")
            {
                IEnumerable<MultiChoice> categQuery = from question in multiChoiceQuestions where question.Difficulty == diffic select question;
                foreach (MultiChoice question in categQuery)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            Done();
        }

        public void OrderByGrade()
        {
            if (categType == "1")
            {
                var QuestByGrade = openQuest.OrderBy(question => question.Difficulty);
                foreach (Open question in QuestByGrade)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            else if (categType == "2")
            {
                var QuestByGrade = multiChoiceQuestions.OrderBy(question => question.Difficulty);
                foreach (MultiChoice question in QuestByGrade)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            Done();
        }

        public void OrderByCategory()
        {
            if (categType == "1")
            {
                var QuestByCateg = openQuest.OrderBy(question => question.Categ);
                foreach (Open question in QuestByCateg)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }

            else if (categType == "2")
            {
                var QuestByCateg = multiChoiceQuestions.OrderBy(question => question.Categ);
                foreach (MultiChoice question in QuestByCateg)
                {
                    Console.Clear();
                    question.ShowQues();
                }
            }
            Done();
        }

        public static void Done()
        {
            Console.Clear();
            Console.WriteLine("All done");
            Thread.Sleep(3000);

        }
    }
}
