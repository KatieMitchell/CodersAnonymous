using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashCourse
{
    public class Question
    {
        private static readonly List<Question> _all = new List<Question>();

        public static readonly Question One = new Question("Question 1");
        public static readonly Question Two = new Question("Question 2");
        public static readonly Question Three = new Question("Question 3");
        public static readonly Question Four = new Question("Question 4");
        public static readonly Question Five = new Question("Question 5");
        
        public readonly string question;

        private Question(string questions)
        {
            question = questions;
            _all.Add(this);
        }

    }
}
