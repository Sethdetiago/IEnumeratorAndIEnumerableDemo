using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorAndIEnumerableDemo
{
    internal class DogShelter: IEnumerable<Dog> //must include IEnumerable to make the list of Dogs iterable
    {
        //list of type List<Dog>
        public List<Dog> Dogs;

        //Constuctor starts with some dogs on the list
        public DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog("Reggie", true),
                new Dog("Zuko", false),
                new Dog("Roku", false),
                new Dog("Pizza", true),
                new Dog("Nacho", false)
            };

        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return Dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
