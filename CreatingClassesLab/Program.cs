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
            //For this lab, we are skipping the Relation class and the exercise f

            // Person objects
            Person firstPerson = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person secondPerson = new Person(2, "Gina", "James", "Green", 18, false);
            Person thirdPerson = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person fourthPerson = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            // Gina's information as a sentence
            secondPerson.DisplayPersonInfo();

            Console.WriteLine("\n------------------------ \n");
           
            // Mike's information as a list
            Console.WriteLine(thirdPerson.ToString());

            Console.WriteLine("------------------------ \n");

            // Change Ian's favorite color to white and display it.
            firstPerson.ChangeFavoriteColour("White");
            firstPerson.DisplayPersonInfo();

            Console.WriteLine("\n------------------------ \n");

            // Display Mary's age after 10 years
            Console.WriteLine(fourthPerson.GetAgeInTenYears());

            Console.WriteLine("\n------------------------ \n");

            // Add all the Person objects to a list
            object[] persons = { firstPerson, secondPerson, thirdPerson, fourthPerson };

            // Average age of the people in the list

            double getAgeAverage()
            {
                double sum = 0;
                double personsNumber = persons.Length;
                foreach (Person person in persons)
                {
                    sum += person.age;
                }
                double averageAge = sum/personsNumber;
                return averageAge;
            }

            Console.WriteLine("Average age is: " + getAgeAverage());

            Console.WriteLine("\n------------------------ \n");

            // Youngest person

            string getYoungestPerson()
            {
                double minAge = 100;
                string youngestPerson = string.Empty;
                foreach (Person person in persons)
                {
                    if (person.age < minAge)
                    {
                        minAge = person.age;
                        youngestPerson = person.firstName;
                    } 
                }
                return youngestPerson;
            }

            Console.WriteLine("The youngest person is: " + getYoungestPerson());

            Console.WriteLine("\n------------------------ \n");

            // Oldest person

            string getOldestPerson()
            {
                double minAge = 0;
                string oldestPerson = string.Empty;
                foreach (Person person in persons)
                {
                    if (person.age > minAge)
                    {
                        minAge = person.age;
                        oldestPerson = person.firstName;
                    }
                }
                return oldestPerson;
            }

            Console.WriteLine("The oldest person is: " + getOldestPerson());

            Console.WriteLine("\n------------------------ \n");

            // Names of the people whose first names start with M

            string getNamesStartingWithM()
            {
                string namesWithM = string.Empty;
                foreach (Person person in persons)
                {
                    string firstLetter = person.firstName.Substring(0, 1);
                    string mLetter = "M";
                    if (firstLetter == mLetter)
                    {
                        namesWithM += person.firstName + ", ";
                    }
                }
                namesWithM += "first names start with M"; 
                return namesWithM;
            }

            Console.WriteLine(getNamesStartingWithM());

            Console.WriteLine("\n------------------------ \n");

            // Person information of the person that likes color blue

            void getBlueFan()
            {
                foreach (Person person in persons)
                {
                    string favoriteColor = person.favoriteColour;
                    string blueColor = "Blue";
                    if (favoriteColor == blueColor)
                    {
                        Console.WriteLine(person.ToString());
                    }
                }
            }
            
            getBlueFan();
        }
    }
}
