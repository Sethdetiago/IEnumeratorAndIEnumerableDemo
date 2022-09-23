using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Use Ienumerable when dealing with large databases where you dont want to copy into memory
//Do not use when you wnat hte resul straight away or if you want to manipulate/edit the data
// in those cases simply use an array or list
namespace IEnumeratorAndIEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)//IEnumerable interface is needed for dogshelter see dogshelter class
            {
                if (!dog.IsNaughty)//if dog is a good they will get more treats
                {
                    dog.giveTreats(2);
                }
                else
                {
                    dog.giveTreats(1);
                }
            }

            Console.ReadKey();
        }
    }
}
