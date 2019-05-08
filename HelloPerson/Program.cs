using System.Collections.Generic;

namespace HelloPerson
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            Person person2 = new Person("Scoots", "McCloughan");
            Person person3 = new Person("Joe", "Biden", Gender.Male, SexualOrientation.Straight);

            person.FirstName = "Torahiko";
            person.LastName = "Ooshima";
            person.Gender = Gender.Male;
            person.SexualOrientation = SexualOrientation.Gay;

            person2.Gender = Gender.Nonbinary;
            person2.SexualOrientation = SexualOrientation.Pansexual;

            List<Person> people = new List<Person>
            {
                person,
                person2,
                person3
            };

            foreach (Person p in people)
            {
                p.SayHello();
            }

            return;
        }
    }
}