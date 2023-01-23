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
    /// <remarks> Date: January 22, 2023 </remarks>
    internal class Person
    {
        // Fields
        private readonly int personId;
        private readonly string firstName;
        private readonly string lastName;
        private string favoriteColour;
        private readonly int age;
        private readonly bool isWorking;

        // Properties
        public string FirstName
        {   
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string FavoriteColour
        {
            get
            {
                return this.favoriteColour;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

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

            Console.WriteLine(personId + ": " + firstName + "'s " + lastName + " favorite colour is " + favoriteColor + "\n");
        }

        /// <summary>
        /// Public method that changes the value of favorite colour field
        /// </summary>
        /// <param name="favoriteColor"></param>
        public void ChangeFavoriteColour(string favoriteColor)
        {
            this.favoriteColour = favoriteColor;
        }

        /// <summary>
        /// Public method that adds 10 years to the person's age
        /// </summary>
        /// <returns> Returns a string </returns>
        public string GetAgeInTenYears()
        {
            int tenYearsOlder = age + 10;
            string ageSentence = firstName + " " + lastName + "'s age in 10 years will be: " + tenYearsOlder;
            return ageSentence;
        }

        /// <summary>
        /// Public method that displays all the person data as a list
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
