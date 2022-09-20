using Gr44ConsoleAppOOPPersonFruit.Model;

namespace Gr44ConsoleAppOOPPersonFruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OnePerson();
            //ListOfPeople();
            Fruit fruit = new Fruit(1, "Apple", FruitColor.Red, true);
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(fruit);

            Fruit fruit2 = new Fruit(2, "Orange", FruitColor.Yellow, false);
            fruits.Add(fruit2);
            foreach (Fruit fruit1 in fruits)
            {

                Console.WriteLine(fruit1.fruitId + " " + fruit1.fruitName + " " + fruit1.fruitColor + " " + fruit1.TasteOfFruit());//using ConsoleAppOOP.Model

            }

        }
        //static void OnePerson()
        //{
        //    Console.WriteLine("People count: " + Person.PersonsCreated);

        //    Person person = new Person("Ulf", "Bengttson");

        //    Console.WriteLine("People count: " + Person.PersonsCreated);

        //    //person.FirstName = "Ulf";
        //    //person.LastName = "Bengtsson";

        //    //Console.WriteLine(person);
        //    //Console.WriteLine($"{person.FirstName} {person.LastName}");
        //    //Console.WriteLine(person.FullName);

        //    Console.WriteLine(person.IntroduceYourself());
        //}

        //static void ListOfPeople()
        //{
        //    List<Person> people = new List<Person>();

        //    people.Add(new Person("K", "Svensson"));
        //    people.Add(new Person("Ola", "Andersson"));
        //    people.Add(new Person("Sandra", "Larsson"));

        //    foreach (Person listItem in people)
        //    {
        //        Console.WriteLine(listItem.IntroduceYourself());
        //    }

        //}
    }
}
}