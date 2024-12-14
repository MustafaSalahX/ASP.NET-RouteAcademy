using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class TrueFalseQuestion : Question
    {
        public override string Header => "True Or False Question";

        public TrueFalseQuestion()
        {
            Answers = new Answer[2] 
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

        }

        public override void AddQuestion()
        {
            CreateQuestionBase();

            int rightAnswerId;
            do
            {
                Console.WriteLine("Please enter Id of the Right Choice:  (1 For True || 2 For False)");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId < 1 || rightAnswerId > 2));

            RightAnswer = new Answer(Answers[rightAnswerId - 1].Id, Answers[rightAnswerId - 1].Text);
        }
    }
}
