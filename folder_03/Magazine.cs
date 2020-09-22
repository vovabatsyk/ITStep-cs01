using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Magazine
    {
        public string  Name { get; set; }
        public Frequency Release { get; set; }
        public DateTime DateOfIssue{ get; set; }
        public int Edition { get; set; }
        public Article[] Articles { get; private set; } = new Article[0];

        public Magazine(string name, Frequency release, DateTime dateOfIssue, int edition) {
            Name = name;
            Release = release;
            DateOfIssue = dateOfIssue;
            Edition = edition;
        }

        public Magazine():this("Metanit", Frequency.Weekly, new DateTime(2020, 10, 01), 1001) 
        {
        }

        public bool this[Frequency release]
        {
            get => Release == release;
        }

       
        public void AddArticles(params Article[] articles)
        {
            Article[] rArcticles = new Article[Articles.Length + articles.Length];
            Array.Copy(Articles, rArcticles, Articles.Length);
            Array.Copy(articles, 0, rArcticles, Articles.Length, articles.Length);
            Articles = rArcticles;
        }

        public decimal Rate => (decimal)Articles.Select(a => a.Rating).Average();

        public override string ToString()
        {
            string result = $"{Name} {Release,10}{DateOfIssue.ToString("d"),10}{Edition, 5}\n";
            foreach (Article item in Articles)
            {
                result += item.ToString() + '\n';
            }
            return result;
        }

        public string toShortString() => $"Name: {Name}, Release: {Release}, DateOfIssue: {DateOfIssue.ToString("d")}, Edition: #{Edition}, Rate: {Rate}";


    }
}
