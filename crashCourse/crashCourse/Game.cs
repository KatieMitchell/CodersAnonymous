using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashCourse
{
    public class Game
    {
        public int CardGen()
        {
            Random rnd = new Random();
            int chosenCard = rnd.Next(1, 6);
            return chosenCard;
        }

        public Game()
        {
            int questionCount = Question._all.Count;
            int question = Question.RandomNumber(1, questionCount);
            int correctCardNumber = Form1.CardGen();
            string correctAnswer = Question._all.ElementAt(question).answer;
            string chosenQuestion = Question._all.ElementAt(question).question;
            string[] answers = new string[5];

            int startPoint = RandomNumber(1, Question._all.Count - 7);
            for (int i = startPoint; i < startPoint + 5; i++)
            {
                if (i != question)
                {
                    if (i != correctCardNumber)
                    {
                        answers[i] = Question._all.ElementAt(i).answer;
                    }
                    else
                    {
                        answers[i] = correctAnswer;
                    }
                }
                else
                {
                    i--;
                }
            }
        }
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            min = 1;
            max = Question._all.Count - 7;

            lock (syncLock)
            {//synchronise
                return random.Next(min, max);
            }
        }
    }
}
