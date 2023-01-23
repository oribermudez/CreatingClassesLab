using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesLab.Classes
{
    /// <summary>
    ///  This class holds the methods to perform actions on a Persons list
    /// </summary>
    /// <remarks> Author: Ori Bermudez </remarks>
    /// <remarks> Date: January 22, 2023 </remarks>
    internal class PersonManager
    {
        // Fields
        private readonly object[] personList;
        
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="personList"> Inmutable list of Person objects </param>
        public PersonManager(object[] personList)
        {
            this.personList = personList;
        }

        /// <summary>
        /// Gets the average age of the persons in the list
        /// </summary>
        /// <returns> Returns a double </returns>
        public double GetAgeAverage()
        {
            double sum = 0;
            double personsNumber = this.personList.Length;
            foreach (Person person in this.personList)
            {
                sum += person.Age;
            }
            double averageAge = sum / personsNumber;
            return averageAge;
        }

        /// <summary>
        /// Gets the first name of the younger person in the list
        /// </summary>
        /// <returns> Returns a string </returns>
        public string GetYoungestPerson()
        {
            double minAge = 100;
            string youngestPerson = string.Empty;
            foreach (Person person in this.personList)
            {
                if (person.Age < minAge)
                {
                    minAge = person.Age;
                    youngestPerson = person.FirstName;
                }
            }
            return youngestPerson;
        }

        /// <summary>
        /// Gets the first name of the oldest person in the list
        /// </summary>
        /// <returns> Returns a string </returns>
        public string GetOldestPerson()
        {
            double minAge = 0;
            string oldestPerson = string.Empty;
            foreach (Person person in this.personList)
            {
                if (person.Age > minAge)
                {
                    minAge = person.Age;
                    oldestPerson = person.FirstName;
                }
            }
            return oldestPerson;
        }

        /// <summary>
        /// Gets all the first names of the people whose name start with "M"
        /// </summary>
        /// <returns> Returns a string </returns>
        public string GetNamesStartingWithM()
        {
            string namesWithM = string.Empty;
            foreach (Person person in this.personList)
            {
                string firstLetter = person.FirstName.Substring(0, 1);
                string mLetter = "M";
                if (firstLetter == mLetter)
                {
                    namesWithM += person.FirstName + " " + person.LastName + ", ";
                }
            }
            namesWithM += "first names start with M";
            return namesWithM;
        }

        /// <summary>
        /// Gets the data of the person whose favorite color is Blue
        /// </summary>
        public void GetBlueFan()
        {
            foreach (Person person in this.personList)
            {
                string favoriteColor = person.FavoriteColour;
                string blueColor = "Blue";
                if (favoriteColor == blueColor)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
