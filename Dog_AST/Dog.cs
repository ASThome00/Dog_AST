using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_AST
{
    /// <summary>
    /// This class is a converted copy of the Dog.java class written by Dr. Robert Kelley.
    /// </summary>
    class Dog
    {
        private int age;
        private String name;
        
        /// <summary>
        /// Empty argument constructor
        /// </summary>
        public Dog()
        {
            age = 0;
            name = "";
        }//end constructor

        /// <summary>
        /// Preferred constructor for Dog
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Name</param>
        public Dog(int age, String name)
        {

            this.setAge(age);
            this.setName(name);

        }//end constructor
        /// <summary>
        /// Calculates the age of the dog in dog years
        /// </summary>
        /// <returns>age in dog years</returns>
        public int calcDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
            return dogYears;
        }

        /// <summary>
        /// getter for age
        /// </summary>
        /// <returns>age</returns>
        public int getAge()
        {
            return age;
        }//end getAge

        /// <summary>
        /// setter for age, checks to make sure age is 0 or greater.
        /// </summary>
        /// <param name="age">age</param>
        public void setAge(int age)
        {
            if (age < 0)
                this.age = 0;
            else
                this.age = age;
        }//end setAge

        /// <summary>
        /// getter for name
        /// </summary>
        /// <returns>name</returns>
        public String getName()
        {
            return name;
        }//end getName

        /// <summary>
        /// Setter for name, makes sure only letters are allowed in the name
        /// </summary>
        /// <param name="name">Name</param>
        public void setName(String name)
        {
            bool valid = true;
            char[] n = name.ToCharArray();

            foreach (char c in n)
            {
                if (!char.IsLetter(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                this.name = name;
            else
                this.name = "";

        }//end setName
        public String toString()
        {
            return "Dog [age=" + age + ", name=" + name + "]";
        }//end toString

    }//end class

}
