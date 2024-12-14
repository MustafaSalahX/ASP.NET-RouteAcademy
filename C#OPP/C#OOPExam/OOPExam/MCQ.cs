using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class MCQ : Question
    {
        public override string Header => "MCQ Question";

        public MCQ()
        {
            Answers = new Answer[3];
        }
        public override void AddQuestion()
        {
            CreateQuestionBase();

            Console.WriteLine("Choices of the Question");

            for (int i = 0; i < 3; i++)
            {
                Answers[i] = new Answer() { Id = i + 1 };

                do
                {
                    Console.WriteLine($"Please enter the Answer {i + 1}: ");
                    Answers[i].Text = Console.ReadLine()!;

                } while (string.IsNullOrEmpty(Answers[i].Text));

            }

            int rightAnswerId;

            do
            {
                Console.WriteLine("Please enter Id of the Right Choice: ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId < 1 || rightAnswerId > 3));

            RightAnswer = new Answer(Answers[rightAnswerId - 1].Id, Answers[rightAnswerId - 1].Text);


        }
    }
}
