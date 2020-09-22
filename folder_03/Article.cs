using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Article
    {
        public Person Author { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }

        public Article(Person author, string title, double rate)
        {
            Author = author;
            Title = title;
            Rating = rate;
        }

        public Article() : this(new Person("Volodymyr", "Batsyk", new DateTime(1987, 07, 27), Gender.Male),
                "Programming Languages", 10.00) { }

        public override string ToString() => $"{Author.ToString(), 15} {Title} , {Rating}";
    }
}
