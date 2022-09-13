using System;
using SIBKMNet.Abstraction;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Person : Behaviour, IBehaviour
    {
        public Person(int Id, string Name, string City, int Age, bool Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.City = City;
            this.Age = Age;
            this.Gender = Gender;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public int Age { get; private set; }
        public bool Gender { get; private set; }

        public override void Work( string Name)
        {
            base.Work(Name);
            Console.WriteLine(Name + "sedang bekerja dikantor");
        }

        public override void Istirahat()
        {
            Console.WriteLine("sedang istirahat");
        }

        public override void Kuota()
        {
            Console.WriteLine("dapat kuota dari kantor");
        }

        public override void UangMakan()
        {
            Console.WriteLine("dapat uang makan");
        }
        public void Salary (string Name)
        {
            Console.WriteLine(Name + " dapat gaji");
        }
    }
}
