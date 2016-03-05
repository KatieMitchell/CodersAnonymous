using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashCourse
{
    public class Question
    {
        public static string Q1 = "In 2005 how many accidents in total occured on Saturdays?";
        public static string Q2 = "In 2006 how many accidents in total occured on Wednesdays?";
        public static string Q3 = "In total how many serious accident occured when the road surface was wet?";
        public static string Q4 = "How many accidents in total occured in Greater Manchester";
        public static string Q5 = "In total how many accidents occured when the speed limit was 60mph?";
        public static string Q6 = "How many serious accidents occured in the dark/night?";

        public static readonly List<Question> _all = new List<Question>();

        public static readonly Question One = new Question(Q1, "Answer 1");
        public static readonly Question Two = new Question(Q2, "Answer 2");
        public static readonly Question Three = new Question(Q3, "Answer 3");
        public static readonly Question Four = new Question(Q4, "Answer 4");
        public static readonly Question Five = new Question(Q5, "Answer 5");
        public static readonly Question Six = new Question(Q6, "Answer 5");


        public string question;
        public string answer;

        public Question(string questions, string answers)
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
            {//synchronise
                return random.Next(min, max);
            }

        }

    }
}
