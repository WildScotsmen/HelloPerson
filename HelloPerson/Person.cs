
using System;

public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Gender Gender { get; set; }

    public SexualOrientation SexualOrientation { get; set; }

    public Person() { }

    public Person(string f, string l) =>
        (FirstName, LastName) = (f, l);

    public Person(string f, string l, Gender g, SexualOrientation s) =>
        (FirstName, LastName, Gender, SexualOrientation) = (f, l, g, s);

    public void SayHello()
    {
        Console.WriteLine("My name is {0} {1}. I identify as {2}, and I am {3}.",
            FirstName, LastName, Gender.ToString().ToLower(), SexualOrientation.ToString().ToLower());

        return;
    }
}