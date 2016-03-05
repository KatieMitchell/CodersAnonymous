using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashCourse
{
    public class Question
    {
        public static readonly List<Question> _all = new List<Question>();

        public static readonly Question One = new Question("Question 1", "Answer1");
        public static readonly Question Two = new Question("Question 2", "Answer1");
        public static readonly Question Three = new Question("Question 3", "Answer1");
        public static readonly Question Four = new Question("Question 4", "Answer1");
        public static readonly Question Five = new Question("Question 5", "Answer1");
        
        public readonly string question;
        public readonly string answer;

        private Question(string questions, string answers)
        {
            question = questions;
            answer = answers;
            _all.Add(this);

        }
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            min = 1;
            max = _all.Count;

            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }



        //public int QuestionCount = _all.Count;
        //Random rnd = new Random();
        //int QuestionNumber = rnd.Next(1, _all.Count);
        //    return QuestionNumber;
    }
}
