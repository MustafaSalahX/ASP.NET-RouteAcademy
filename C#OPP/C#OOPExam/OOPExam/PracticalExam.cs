using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestion()
        {
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Questions[i] = new TrueFalseQuestion();
                Questions[i].AddQuestion();

                Console.Clear();

            }

        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("------------------------------");

                int answerId;

                do
                {
                    Console.WriteLine("Please enter Id of the Right Choice: ");

                } while (!int.TryParse(Console.ReadLine(), out answerId) || (answerId < 1 || answerId > 3));

                question.UserAnswer = new Answer(answerId, question.Answers[answerId - 1].Text);



            }

            Console.Clear();

            for (int i = 0; i < Questions?.Length; i++)
            {

                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");

                Console.WriteLine($"Right Answer : {Questions[i].RightAnswer.Text}");

                Console.WriteLine("==========================");
            }
        }
    }
}
