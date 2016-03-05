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

            int questionCount = Question._all.Count();
            int question = Question.RandomNumber(1, questionCount);
            int correctCardNumber = CardGen();
            string correctAnswer = Question._all.ElementAt(question).answer;

        }
    }
}
