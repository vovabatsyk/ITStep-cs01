using System;

namespace University
{
    public class Exam
    {
        public string Subject { get; }
        public DateTime DateExam { get; }
        private int mark;

        public int Mark
        {
            get => mark;

            private set
            {
                if (value >= 1 && value <= 12) mark = value;
                else new ArgumentException("Mark must be 1 - 12");
            }
        }

        public Exam(string subject, DateTime dateExam, int mark)
        {
            Subject = subject;
            DateExam = dateExam;
            Mark = mark;
        }

        public override string ToString() => $"{Subject,-20}{DateExam.ToShortDateString(),15}{Mark,5}";
    }
}