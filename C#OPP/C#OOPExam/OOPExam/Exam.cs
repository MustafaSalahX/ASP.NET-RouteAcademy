namespace OOPExam
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
            
        }

        public abstract void CreateListOfQuestion();

        public abstract void ShowExam();
    }
}
