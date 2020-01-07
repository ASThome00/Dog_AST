using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_AST
{
    class DogTester
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(5, "Fido");
            Console.WriteLine(dog.getName() + " is " + dog.calcDogYears() + " years old in dog years!");
            dog.setAge(8);
            Console.WriteLine(dog.getAge());
            Console.WriteLine(dog.toString());
            System.Threading.Thread.Sleep(10000);
        }//end main
    }
}
