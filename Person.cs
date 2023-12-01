using System;
using System.Collections.Generic;
namespace Intermediate
{
    public class Person 
    {
        public string name;
        public int age;
        List<string> friendsNames = new  List<string>();
        private DateTime birthDate;
        

        public void SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public Person()
        {
            System.Console.WriteLine("I m the base constructor");
        }
        
        public Person(string name = null , int age = 0)
        :this()
        {
            
            friendsNames.Add("ashraf");
           System.Console.WriteLine(friendsNames[0]);  

            this.name = name;
            this.age = age;
        }
        public void Introduce(string to)
        {
            System.Console.WriteLine("hi {0} , i am {1}",to ,name);
            System.Console.WriteLine("i am {0} years old" , age);
        }
        public static Person Parse(string personName , int age)
        {
             
            Person person = new Person(personName , age);
            return person;
        }
    }
}