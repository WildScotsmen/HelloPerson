using System.Collections.Generic;

/// <summary>
/// The namespace for the application.
/// </summary>
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
            Person person3 = new Person("Joe", "Biden", Enum.Gender.Male, Enum.SexualOrientation.Straight);

            // Giving qualities to the first person.
            person.FirstName = "Torahiko";
            person.LastName = "Ooshima";
            person.Gender = Enum.Gender.Male;
            person.SexualOrientation = Enum.SexualOrientation.Gay;

            // Giving qualities to the second person.
            person2.Gender = Enum.Gender.Nonbinary;
            person2.SexualOrientation = Enum.SexualOrientation.Pansexual;

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