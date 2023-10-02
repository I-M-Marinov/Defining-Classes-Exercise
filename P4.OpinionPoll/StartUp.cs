namespace DefiningClasses;

public class StartUp
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> peopleOverThirty = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] personProps = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Person person = new(personProps[0], int.Parse(personProps[1]));

            if (person.Age > 30)
            {
                peopleOverThirty.Add(person);
            }
        }

        foreach (var person in peopleOverThirty.OrderBy(p => p.Name)) // ORDER BY ---------->>>> ascending order  ( A to Z ) 
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }


}






