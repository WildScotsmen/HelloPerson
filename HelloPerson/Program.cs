using System.Collections.Generic;

namespace HelloPerson
{
    /// <summary>
    /// The driving class of the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method. Ran at the start.
        /// </summary>
        static void Main()
        {
            // Creating some people.
            Person person = new Person();
            Person person2 = new Person("Scoots", "McCloughan");
            Person person3 = new Person("Joe", "Biden", Gender.Male, SexualOrientation.Straight);

            // Giving qualities to the first person.
            person.FirstName = "Torahiko";
            person.LastName = "Ooshima";
            person.Gender = Gender.Male;
            person.SexualOrientation = SexualOrientation.Gay;

            // Giving qualities to the second person.
            person2.Gender = Gender.Nonbinary;
            person2.SexualOrientation = SexualOrientation.Pansexual;

            // Creating a list of people.
            List<Person> people = new List<Person>
            {
                person,
                person2,
                person3
            };

            // Asking the people to say hello.
            foreach (Person p in people)
            {
                p.SayHello();
            }

            // Goodbyte.
            return;
        }
    }
}