using System;

namespace University
{
    public class Person
    {
        private static long personCounter;
        private const int idLength = 10;
        private const int nameLength = 20;

        private readonly long id;
        private string FirstName { get; set; }
        private string lastName;
        public System.DateTime Birthday { get; set; }
        public byte age;
        public Gender Gender { get; set; }

        static Person()
        {
            personCounter = 1;
        }

        public Person(string firstName, string lastName, DateTime birthday, Gender gender)
        {
            id = ++personCounter;
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
            Gender = gender;
        }

        public Person() : this("noName", "noLastname", new DateTime(rndYear(), rndMonth(), 27), default(Gender))
        {
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
                    {
                        throw new Exception("wrong name");
                    }

                    lastName = value;
                }
            }
        }

        public string Id
        {
            get { return new string('0', idLength - id.ToString().Length) + id; }
        }

        public byte Age
        {
            get
            {
                return (byte) ((DateTime.Today.Year - rndYear()) - 1 +
                               (Birthday.Month > DateTime.Today.Month || Birthday.Month == DateTime.Today.Month &&
                                   Birthday.Day >= DateTime.Today.Day
                                       ? 1
                                       : 0));
            }
        }

        public override string ToString() => $"{toShortString()}{Birthday.ToShortDateString(),15}{Gender,10}";

        public virtual string toShortString() =>
            $"{Id,-(idLength) + 5}: {FirstName + ' ' + LastName} ";

        public bool this[Gender g]
        {
            get { return g == this.Gender; }
        }

        private static int rndYear() => new Random().Next(1970, 2010);
        private static int rndMonth() => new Random().Next(1, 13);
    }
}