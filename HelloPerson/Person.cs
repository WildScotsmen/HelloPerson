
using System;

namespace HelloPerson
{
    /// <summary>
    /// A class that represents a person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        /// <value>
        /// Gets and sets the first name of the person.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        /// <value>
        /// Gets and sets the last name of the person.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// The gender the person identifies as.
        /// </summary>
        /// <value>
        /// Gets and sets the gender identity of the person.
        /// </value>
        public Enum.Gender Gender { get; set; }

        /// <summary>
        /// The sexual orientation of the person.
        /// </summary>
        /// <value>
        /// Gets and sets the sexual orientation of the person.
        /// </value>
        public Enum.SexualOrientation SexualOrientation { get; set; }

        /// <summary>
        /// Basic constructor for the class.
        /// </summary>
        public Person() { }

        /// <summary>
        /// Parameterized constructor for the class.
        /// </summary>
        /// <param name="f">The person's first name.</param>
        /// <param name="l">The person's last name.</param>
        public Person(string f, string l) =>
            (FirstName, LastName) = (f, l);

        /// <summary>
        /// Parameterized constructor for the class.
        /// </summary>
        /// <param name="f">The person's first name.</param>
        /// <param name="l">The person's last name.</param>
        /// <param name="g">The person's gender identity.</param>
        /// <param name="s">The person's sexual orientation.</param>
        public Person(string f, string l, Enum.Gender g, Enum.SexualOrientation s) =>
            (FirstName, LastName, Gender, SexualOrientation) = (f, l, g, s);

        /// <summary>
        /// The person introduces themselves.
        /// </summary>
        /// <remarks>
        /// The greeting includes the person's full name, gender, and 
        /// sexual orientation.
        /// </remarks>
        public void SayHello()
        {
            Console.WriteLine("My name is {0} {1}. I identify as {2}, and I am {3}.",
                FirstName, LastName, Gender.ToString().ToLower(), SexualOrientation.ToString().ToLower());

            return;
        }
    }
}