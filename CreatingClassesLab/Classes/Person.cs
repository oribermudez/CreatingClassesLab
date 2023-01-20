using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassesLab.Classes
{
    /// <summary>
    ///  This class represents a person
    /// </summary>
    /// <remarks> Author: Ori Bermudez </remarks>
    /// <remarks> Date: January 19, 2023 </remarks>
    internal class Person
    {
        // Fields
        private int personId;
        public string firstName;
        private string lastName;
        public string favoriteColour;
        public int age;
        private bool isWorking;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="personId"> Inmutable string that holds the personId </param>
        /// <param name="firstName"> Inmutable string that holds the firstName </param>
        /// <param name="lastName"> Inmutable string that holds the lastName </param>
        /// <param name="age"> Inmutable int that holds the age </param>
        /// <param name="favoriteColour"> Mutable string that holds the favorite colour </param>
        /// <param name="isWorking"> Inmutable boolean that holds the working status </param>
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColour = favoriteColour;
            this.isWorking = isWorking;
        }

        /// <summary>
        /// Public method that displays the person's name and favorite color
        /// </summary>
        public void DisplayPersonInfo()
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            string favoriteColor = this.favoriteColour;

            Console.WriteLine(personId + ": " +firstName + " " + lastName + " favorite colour is " + favoriteColor);
        }

        /// <summary>
        /// Public method that sets a new value to favoriteColour field
        /// </summary>
        /// <param name="favoriteColor"></param>
        public void ChangeFavoriteColour(string favoriteColor)
        {
            this.favoriteColour = favoriteColor;
        }

        /// <summary>
        /// Method that adds 10 years to the person's age
        /// </summary>
        /// <returns> Returns an int </returns>
        public string GetAgeInTenYears()
        {
            int tenYearsOlder = age + 10;
            string ageSentence = firstName + " " + lastName + "'s age in 10 years will be: " + tenYearsOlder;
            return ageSentence;
        }

        /// <summary>
        /// Method that displays all the person data as a list
        /// </summary>
        /// <returns> Returns a string </returns>
        public override string ToString()
        {
            object[] fieldValues = { this.personId, this.firstName, this.lastName, this.favoriteColour, this.age, this.isWorking };
            string[] fieldNames = { "Person Id", "First Name", "Last Name", "Favorite Color", "Age", "Is working" };

            string dataList = string.Empty;
            for (int index = 0; index < fieldValues.Count(); index++)
            {
                var item = fieldNames[index] + ": " + fieldValues[index] + "\n";
                dataList += item;
            }

            return dataList;
        }

    }
}
