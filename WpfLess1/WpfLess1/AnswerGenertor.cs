using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLess1
{
    class AnswerGenertor
    {
        private static string[] answers = new string[] 
        {
            "ask one more time.",
            "I dont answer now.",
            "yes,sure",
            "it really is",
            "No.",
            "Yes indeed",
            "I do not think so",
            "Exactly.",
            "better don't say anything",
            "Bad point of view",
            "I believe it is so.",
            "very doubtful.",
            "as I see it, yes",
            "my answer is no",
            "you can be sure",
            "good point of view",
            "vague answer, try again.",
        };
        



        public static string GetRandomAnswer()
        {

            return answers[new Random().Next(answers.Length)];
        }
    }
}
