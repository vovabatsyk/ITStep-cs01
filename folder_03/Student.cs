using System;
using System.Linq;

namespace University
{
    public class Student
    {
        private Person _studentData;
        private Education _educationForm;
        private int _numberOfGroup;
        public Exam[] Exams { get; private set; } = new Exam[0];

        public Student(Person studentData, Education educationForm, int numberOfGroup, params Exam[] exams)
        {
            _studentData = studentData;
            _educationForm = educationForm;
            _numberOfGroup = numberOfGroup;
            AddExams(exams);
        }

        public Student() : this(new Person("Volodymyr", "Batsyk", new DateTime(1987, 07, 27), Gender.Male),
            Education.Master, 2, new Exam[0])
        {
        }

        public Person StudentData
        {
            get => _studentData;
            set => _studentData = value;
        }

        public Education EducationForm
        {
            get => _educationForm;
            set => _educationForm = value;
        }

        public int NumberOfGroup
        {
            get => _numberOfGroup;
            set => _numberOfGroup = value;
        }


        public void AddExams(params Exam[] exams)
        {
            Exam[] rExams = new Exam[Exams.Length + exams.Length];
            Array.Copy(Exams, rExams, Exams.Length);
            Array.Copy(exams, 0, rExams, Exams.Length, exams.Length);
            Exams = rExams;
        }

        public override string ToString()
        {
            string result = $"{StudentData.ToString()}{EducationForm,10}{NumberOfGroup,10}\n";
            foreach (Exam item in Exams)
            {
                result += item.ToString() + '\n';
            }
            return result;
        }

        public string toShortString() =>
          $"LastName: {StudentData.LastName}, Birthday: {StudentData.Birthday.ToString("d")}, {StudentData.Gender}, Rate: {Rate}";


        public decimal Rate => (decimal)Exams.Select(e => e.Mark).Average();

        public bool this[Education education]
        {
            get => EducationForm == education;
        }

    }
}