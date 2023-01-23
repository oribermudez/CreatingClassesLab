using CreatingClassesLab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Format variables
            string newLine = "\n";

            // For this lab, we are skipping the Relation class, as instructed by the professor

            // a) Person objects
            Person firstPerson = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person secondPerson = new Person(2, "Gina", "James", "Green", 18, false);
            Person thirdPerson = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person fourthPerson = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            // b) Gina's information as a sentence
            secondPerson.DisplayPersonInfo();

            // c) Mike's information as a list
            Console.WriteLine(thirdPerson.ToString());


            // d) Change Ian's favorite color to white and display it
            firstPerson.ChangeFavoriteColour("White");
            firstPerson.DisplayPersonInfo();


            // e) Display Mary's age after 10 years
            Console.WriteLine(fourthPerson.GetAgeInTenYears() + newLine);


            // Skipping f) as instructed by the professor


            // g) Add all the Person objects to a list
            object[] persons = { firstPerson, secondPerson, thirdPerson, fourthPerson };


            // Creating PersonManager object
            PersonManager personManager = new PersonManager(persons);
            

            // g) 1. Average age of the people in the list
            Console.WriteLine("Average age is: " + personManager.GetAgeAverage() + newLine);


            // g) 2. Youngest person

            Console.WriteLine("The youngest person is: " + personManager.GetYoungestPerson() + newLine);


            // g) 3. Oldest person

            Console.WriteLine("The oldest person is: " + personManager.GetOldestPerson() + newLine);


            // g) 4. Names of the people whose first names start with M

            Console.WriteLine(personManager.GetNamesStartingWithM() + newLine);


            // g) 5. Person information of the person that likes color blue

            personManager.GetBlueFan();

        }
    }
}
