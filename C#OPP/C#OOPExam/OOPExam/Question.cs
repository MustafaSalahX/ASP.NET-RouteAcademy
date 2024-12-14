using System.Text;

namespace OOPExam
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; } = default!;

        public Answer RightAnswer { get; set; } = default!;

        public Answer UserAnswer { get; set; } = default!;

        public abstract void AddQuestion(); 

        public void CreateQuestionBase()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Please enter the body of the question: ");
                Body = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(Body));

            int mark;
            do
            {
                Console.WriteLine("Please enter the mark of the question: ");

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);
            Mark = mark;

        }


        public override string ToString()
        {
            StringBuilder answers = new StringBuilder();
            foreach (var answe in Answers)
            {
                answers.Append($"{answe}\t");
            }

            return $"{Header}\n{Body}\t Mark : {Mark}:\n{answers}";
        }


    }
}
