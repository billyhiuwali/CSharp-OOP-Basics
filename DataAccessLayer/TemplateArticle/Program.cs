using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TemplateArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonReader reader = new PersonReader();
            Collection<Person> people = reader.Execute();

            foreach (Person p in people)
                Console.WriteLine(string.Format("{0}, {1}: {2}", p.LastName, p.FirstName, p.Email));

            Console.ReadLine();

        }


    }
}
